using System;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sulakore.Communication;
using Sulakore.Crypto;
using Sulakore.Protocol;

namespace KClient
{
    public class Connection
    {
        private readonly HKeyExchange _keyExchange;
        private RC4 _crypto;

        private readonly string _sso;

        public bool IsConnected;

        private readonly Random _rand;

        private bool _isWalkingAround;
        private int _tentativas;
        public int Id;

        private readonly MainFrm _main;
        private readonly string _proxyServer;
        private readonly int _proxyPort;

        private const int Exponent = 65537;
        private const string Modulus =
            "e052808c1abef69a1a62c396396b85955e2ff522f5157639fa6a19a98b54e0e4d6e44f44c4c0390fee8ccf642a22b6d46d7228b10e34ae6fffb61a35c11333780af6dd1aaafa7388fa6c65b51e8225c6b57cf5fbac30856e896229512e1f9af034895937b2cb6637eb6edf768c10189df30c10d8a3ec20488a198063599ca6ad";

        private HNode _server; 

        public Connection(string sso, MainFrm main, int id, string server = null, int port = 0)
        {
            _sso = sso;
            _main = main;
            Id = id;
            _keyExchange = new HKeyExchange(Exponent, Modulus);
            _rand = new Random();
            _tentativas = 0;

            _proxyServer = server;
            _proxyPort = port;
        }

        public async void Connect()
        {
            _server = new HNode();
            if(_proxyServer != null)
                _server.SOCKS5EndPoint = new IPEndPoint(IPAddress.Parse(_proxyServer), _proxyPort);

            await _server.ConnectAsync("game-it.habbo.com", 30000);
            await _server.SendPacketAsync(Headers.ReleaseVersion, Headers.Variables.Production, "FLASH", 1, 0);
            await _server.SendPacketAsync(Headers.InitCrypto);

            HandlePacket(await _server.ReceivePacketAsync());
        }

        private async void HandlePacket(HMessage hmessage)
        {
            try
            {
                if (hmessage.Header == Headers.Ping)
                {
                    SendPong();
                }
                else if (hmessage.Header == Headers.InGenerateSecretKey)
                {
                    GenerateSecretKey(hmessage.ReadString());
                }
                else if (hmessage.Header == Headers.VerifyPrimes)
                {
                    VerifyPrimes(hmessage.ReadString(), hmessage.ReadString());
                }

                HandlePacket(await _server.ReceivePacketAsync());
            }
            catch
            {
                Disconnect();
            }
        }

        public void GenerateSecretKey(string publicKey)
        {
            _crypto = new RC4(_keyExchange.GetSharedKey(publicKey));
            SendToServer(_crypto.Parse(HMessage.Construct(Headers.ClientVariables, 401, Headers.Variables.ClientVariables_1, Headers.Variables.ClientVariables_2)));
            SendToServer(_crypto.Parse(HMessage.Construct(Headers.MachineID, GenMid(), "WIN/30,0,0,154")));
            SendToServer(_crypto.Parse(HMessage.Construct(Headers.SSOTicket, _sso, _rand.Next(400, 4600))));
            SendToServer(_crypto.Parse(HMessage.Construct(Headers.RequestUserData)));
            IsConnected = true;
            _main.LogSucess($"[BOT {Id}] Conectado.");
        }

        private async void SendToServer(byte[] parse)
        {
            await _server.SendAsync(parse);
        }

        public void VerifyPrimes(string prime, string generator)
        {
            _keyExchange.VerifyDHPrimes(prime, generator);
            _keyExchange.Padding = PKCSPadding.RandomByte;
            SendToServer(HMessage.Construct(Headers.OutGenerateSecretKey, _keyExchange.GetPublicKey()));
        }

        private void SendPong()
        {
            SendToServerCrypto(HMessage.Construct(Headers.Pong));
        }

        private async void SendToServerCrypto(byte[] data)
        {
            if (CanEncrypt())
                _crypto.RefParse(data);
            await _server.SendAsync(data);
        }

        private bool CanEncrypt()
        {
            return _crypto != null;
        }

        public void Disconnect()
        {
            IsConnected = false;

            if (_tentativas < 3)
            {
                _main.LogWarning($"[BOT {Id}] Tentando reconectar ({_tentativas + 1}/3)");
                Connect();
                _tentativas++;
                return;
            }

            _main.LogError($"[BOT {Id}] Desconectado.");

            _main.RemoveBotFromLists(Id);
            Handler.Bots.Remove(this);
        }

        public void LoadRoom(int room)
        {
            SendToServerCrypto(HMessage.Construct(Headers.RequestRoomLoad, room, "", -1));
        }

        public void Shout(string msg)
        {
            SendToServerCrypto(HMessage.Construct(Headers.RoomUserShout, msg, 1));
        }

        public void ChangeClothes(string figureId)
        {
            SendToServerCrypto(HMessage.Construct(Headers.UserSaveLook, "M", figureId));
        }

        public void WalkTo(int x, int y)
        {
            SendToServerCrypto(HMessage.Construct(Headers.RoomUserWalk, x, y));
        }

        public void Respect(int id)
        {
            SendToServerCrypto(HMessage.Construct(Headers.RoomUserGiveRespect, id));
        }

        public void Sit(bool status)
        {
            SendToServerCrypto(HMessage.Construct(Headers.RoomUserSit, status ? 1 : 0));
        }

        public void Scratch(int petId)
        {
            SendToServerCrypto(HMessage.Construct(Headers.ScratchPet, petId));
        }

        public void Dance(bool status)
        {
            SendToServerCrypto(HMessage.Construct(Headers.RoomUserDance, status ? 1 : 0));
        }

        public void WalkAround(bool status)
        {
            _isWalkingAround = status;
            if(_isWalkingAround)
                new Task(WalkAroundTask).Start();
        }

        private async void WalkAroundTask()
        {
            while (_isWalkingAround)
            {
                WalkTo(_rand.Next(1, 24), _rand.Next(1, 24));
                await Task.Delay(400);
            }
        }

        private string GenMid(int length = 32)
        {
            using (var rngProvider = new RNGCryptoServiceProvider())
            {
                var bytes = new byte[length];
                rngProvider.GetBytes(bytes);

                using (var md5 = MD5.Create())
                {
                    var md5Hash = md5.ComputeHash(bytes);

                    var sb = new StringBuilder();
                    foreach (var data in md5Hash)
                    {
                        sb.Append(data.ToString("x2"));
                    }
                    return sb.ToString();
                }
            }
        }

    }
}
