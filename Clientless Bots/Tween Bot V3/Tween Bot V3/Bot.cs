using Sulakore.Communication;
using Sulakore.Crypto;
using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tween_Bot_V3
{
    class Bot
    {
        private Main _main;
        private readonly HKeyExchange _keyExchange;
        private HNode _server;
        private RC4 _crypto;

        private readonly string _sso;
        public int _tentativas;

        public bool IsConnected;
        public int Id;

        private readonly Random _rand;
        private Stopwatch _time;
        private Header _header;

        private bool _isAFK;
        private bool _isRotationAround;
        private bool _isWalkingAround;
        private bool _randomActions;
        private bool _randomBubbles;
        private bool _antiBobba;

        private readonly string _proxyServer;
        private readonly int _proxyPort;

        private List<string> visus;
        private List<string> visus2;

        public Bot(string sso, Main main, int id, string server = null, int port = 0)
        {
            _sso = sso;
            _main = main;
            Id = id;
            _keyExchange = new HKeyExchange(65537, "bd214e4f036d35b75fee36000f24ebbef15d56614756d7afbd4d186ef5445f758b284647feb773927418ef70b95387b80b961ea56d8441d410440e3d3295539a3e86e7707609a274c02614cc2c7df7d7720068f072e098744afe68485c6297893f3d2ba3d7aaaaf7fa8ebf5d7af0ba2d42e0d565b89d332de4cf898d666096ce61698de0fab03a8a5e12430cb427c97194cbd221843d162c9f3acf74da1d80ebc37fde442b68a0814dfea3989fdf8129c120a8418248d7ee85d0b79fa818422e496d6fa7b5bd5db77e588f8400cda1a8d82efed6c86b434bafa6d07dfcc459d35d773f8dfaf523dfed8fca45908d0f9ed0d4bceac3743af39f11310eaf3dff45");
            _rand = new Random();
            _time = new Stopwatch();
            _tentativas = 0;

            _proxyServer = server;
            _proxyPort = port;

            _header = new Header();

            visus = new List<string>();
            visus2 = new List<string>();

            #region Clothes
            visus.Add("ha-1002-70.lg-270-79.sh-305-62.ch-215-66.hr-100-0.wa-2007-0.hd-180-8");
            visus.Add("hr-893-34.lg-285-1320.hd-209-1.sh-290-1408.ha-1002-71.ch-210-64");
            visus.Add("hr-170-45.lg-281-64.hd-190-14.ha-3254-1408.ch-267-1408");
            visus.Add("hr-893-45.lg-270-85.hd-209-10.sh-906-1408.ch-3109-64-64");
            visus.Add("hr-893-42.cc-3294-81-82.lg-3023-82.hd-209-1.sh-3068-82-66.ch-255-91.ca-1802-0");
            visus.Add("hr-3090-36.lg-281-82.hd-207-1.ea-1404-64.ch-3110-82-73");
            visus.Add("hr-110-45.lg-3116-1408-1408.hd-209-1371.sh-906-1408.ch-255-73");
            visus.Add("hr-110-40.lg-281-64.hd-205-1.ch-210-1408.ca-3176-64-1408.fa-1205-1408");
            visus.Add("hr-893-44.cc-260-64.lg-3023-64.hd-209-10.sh-300-64.ch-3030-81.ca-1804-73");
            visus.Add("hr-893-45.lg-270-64.hd-205-10.sh-290-64.ch-3030-64.he-1608-0");
            visus.Add("hr-802-40.lg-3023-73.hd-209-1370.sh-295-80.ch-215-80");
            visus.Add("hr-893-45.lg-275-1408.hd-180-10.sh-295-1408.ch-215-82");
            visus.Add("hr-893-39.lg-3023-64.hd-207-1.sh-295-64.ha-1013-64.fa-1212-0.ch-876-64-1408");
            visus.Add("sh-3068-82-1408.hd-209-1.hr-155-35.ch-3109-73-1408.lg-3078-1408");
            visus.Add("hd-180-1.hr-155-31.ch-255-81.lg-275-64");
            visus.Add("hd-180-10.hr-802-45.ch-225-90.lg-285-64.fa-1201-0.sh-300-1408");
            visus.Add("sh-908-1408.hd-207-8.hr-893-42.ch-267-64.lg-3023-64");
            visus.Add("sh-300-64.hd-180-10.hr-802-42.ch-255-1408.lg-275-73");
            visus.Add("he-1608-0.hd-209-14.hr-893-48.lg-3116-72-1408.fa-1201-0.ha-1002-1408.ch-267-81.sh-906-1408");
            visus.Add("sh-3068-1408-1408.hd-190-1.hr-802-42.ch-804-82.lg-3088-64-81");
            visus.Add("ha-1003-64.hd-180-1.hr-125-42.ch-210-64.lg-275-1408");
            visus.Add("hd-180-1370.hr-125-34.lg-3116-64-64.cp-3127-73.ch-267-73.sh-305-1408");
            visus.Add("fa-1202-73.hd-206-1369.hr-893-40.ch-804-84.lg-281-64");
            visus.Add("hd-180-12.ch-3030-72.lg-280-64"); //demonio
            visus.Add("hd-180-10.hr-155-31.lg-275-64.ha-3173-63.ch-3030-85.cc-3294-85-85"); //soldadin doido

            visus2.Add("hr-515-33.lg-716-66-62.hd-600-1.sh-735-68.ch-635-70");
            visus2.Add("hr-540-42.lg-710-1408.hd-625-1.sh-725-1408.ch-635-1408");
            visus2.Add("hr-890-44.lg-3216-73.hd-600-10.sh-907-91.ch-685-73.he-3274-82");
            visus2.Add("hr-890-42.lg-720-1408.hd-627-1.sh-725-1408.ch-665-1408.he-1605-1408.wa-3210-81-1408");
            visus2.Add("hr-890-37.lg-3216-73.hd-629-1.sh-3115-73-1408.ch-665-1408.he-3274-82");
            visus2.Add("hr-890-45.lg-3216-80.hd-600-1.sh-907-64.ha-3117-1408.wa-3210-80-1408.ch-665-72");
            visus2.Add("hr-555-39.lg-700-64.hd-626-10.ha-1005-72.wa-2001-0.ch-665-72");
            visus2.Add("hr-515-31.lg-710-1408.hd-600-1.sh-908-1408.ch-665-64.wa-2004-71");
            visus2.Add("hr-890-34.lg-3216-82.hd-627-1.sh-730-1408.ch-665-83.he-3274-82.wa-3210-82-1408");
            visus2.Add("hr-890-38.lg-720-71.hd-627-1.sh-3068-74-1408.ha-3117-74.ch-655-71");
            visus2.Add("hr-540-38.lg-710-82.hd-600-1.ha-1003-74.ch-665-74");
            visus2.Add("hd-615-1.hr-890-46.ch-685-76.lg-3216-76");
            visus2.Add("he-1609-73.hd-615-12.hr-890-46.ch-685-64.lg-715-72");
            visus2.Add("ha-3173-84.hd-629-8.hr-890-46.ch-884-85.lg-3023-85");
            visus2.Add("hd-600-1.hr-890-34.ch-884-68.ea-1404-64.lg-715-68.wa-2004-68");
            #endregion
        }

        public async void Connect()
        {
            try
            {
                _server = new HNode();
                if (_proxyServer != null)
                    _server.SOCKS5EndPoint = new IPEndPoint(IPAddress.Parse(_proxyServer), _proxyPort);

                _time.Start();
                await _server.ConnectAsync("game-br.habbo.com", 30000);

                if (_server.IsConnected)
                {
                    await _server.SendPacketAsync(4000, _header.ReleaseVersion, "FLASH", 1, 0);
                    await _server.SendPacketAsync(_header.InitCrypto);

                    HandlePacket(await _server.ReceivePacketAsync());
                }
                else
                {
                    BotHandler.Start(_sso, _main);
                    _main.RemoveBotFromLists(Id);
                    BotHandler.Bots.Remove(this);
                    _main.LogError($"[BOT {Id}] Desconectado. SSO Salvo!");
                    _main.lblBotsOn.Text = $"[{BotHandler.Bots.Count}/{BotHandler._lastId}]";
                }
            }
            catch { }
        }

        private async void HandlePacket(HMessage packet)
        {
            try
            {
                if (packet.Header == _header.Ping)
                {
                    SendPong();
                }
                else if (packet.Header == _header.GenerateSecretKeyIn)
                {
                    GenerateSecretKey(packet.ReadString());
                }
                else if (packet.Header == _header.VerifyPrimes)
                {
                    VerifyPrimes(packet.ReadString(), packet.ReadString());
                }
                else if (packet.Header == _header.SecureLoginOK)
                {
                    _tentativas = 3;
                    _time.Stop();
                    IsConnected = true;
                    if (_main.isUsingProxy)
                        _main.LogSuccess($"[BOT {Id}] Conectado! ({_proxyServer})");
                    else
                        _main.LogSuccess($"[BOT {Id}] Conectado!");
                    _main.lblBotsOn.Text = $"[{BotHandler.Bots.Count}/{BotHandler._lastId}]";
                    _main.lblBotsOn.ForeColor = Color.FromArgb(0, 192, 0);
                    //RandomRotate(true);
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
            SendToServer(_crypto.Parse(HMessage.Construct(_header.ClientVariables0, 401, _header.ClientVariables1, _header.ClientVariables2)));
            SendToServer(_crypto.Parse(HMessage.Construct(_header.MachineID, "", $"{GenMID()}", "WIN/31,0,0,122")));
            SendToServer(_crypto.Parse(HMessage.Construct(_header.SSOTicket, _sso, _rand.Next(600, 4000))));
            SendToServer(_crypto.Parse(HMessage.Construct(_header.RequestUserData)));
        }

        private async void SendToServer(byte[] parse)
        {
            await _server.SendAsync(parse);
        }

        public void VerifyPrimes(string prime, string generator)
        {
            _keyExchange.VerifyDHPrimes(prime, generator);
            _keyExchange.Padding = PKCSPadding.RandomByte;
            SendToServer(HMessage.Construct(_header.GenerateSecretKeyOut, _keyExchange.GetPublicKey()));
        }

        private void SendPong()
        {
            SendToServerCrypto(HMessage.Construct(_header.Pong));
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
            if (_tentativas < 2)
            {
                _main.LogWarning($"[BOT {Id}] Reconectando... ({_tentativas + 1}/2)");
                Connect();
                _tentativas++;
                return;
            }

            _main.RemoveBotFromLists(Id);
            BotHandler.Bots.Remove(this);
            _main.LogError($"[BOT {Id}] Desconectado.");
            _main.lblBotsOn.Text = $"[{BotHandler.Bots.Count}/{BotHandler._lastId}]";
        }

        public void Logout()
        {
            _tentativas = 3;
            _server.Disconnect();
        }

        public void LeaveRoom()
        {
            SendToServerCrypto(HMessage.Construct(_header.LeaveRoom));
        }

        public void LoadRoom(int room)
        {
            SendToServerCrypto(HMessage.Construct(_header.RequestRoomLoad, room, "", -1));
        }

        public void Shout(string msg)
        {
            if (_antiBobba)
            {
                if (_randomBubbles)
                {
                    var newmsg = new StringBuilder();
                    foreach (var character in msg.Trim())
                    {
                        newmsg.Append($"Щ{character}Ж");
                    }
                    SendToServerCrypto(HMessage.Construct(_header.RoomUserShout, $"[Tween Bot V3] {newmsg}", _rand.Next(0, 7)));
                }
                else
                {
                    var newmsg = new StringBuilder();
                    foreach (var character in msg.Trim())
                    {
                        newmsg.Append($"Щ{character}Ж");
                    }
                    SendToServerCrypto(HMessage.Construct(_header.RoomUserShout, $"[Tween Bot V3] {newmsg}", 38));
                }
            }
            else
            {
                if (_randomBubbles)
                {
                    SendToServerCrypto(HMessage.Construct(_header.RoomUserShout, $"[Tween Bot V3] {msg}", _rand.Next(0, 7)));
                }
                else
                {
                    SendToServerCrypto(HMessage.Construct(_header.RoomUserShout, $"[Tween Bot V3] {msg}", 38));
                }
            }
        }

        public void Whisper(string user, string msg)
        {
            if (_antiBobba)
            {
                if (_randomBubbles)
                {
                    var newmsg = new StringBuilder();
                    foreach (var character in msg.Trim())
                    {
                        newmsg.Append($"Щ{character}Ж");
                    }
                    SendToServerCrypto(HMessage.Construct(_header.RoomUserWhisper, $"{user} [Tween Bot V3] {newmsg}", _rand.Next(0, 7)));
                }
                else
                {
                    var newmsg = new StringBuilder();
                    foreach (var character in msg.Trim())
                    {
                        newmsg.Append($"Щ{character}Ж");
                    }
                    SendToServerCrypto(HMessage.Construct(_header.RoomUserWhisper, $"{user} [Tween Bot V3] {newmsg}", 38));
                }
            }
            else
            {
                if (_randomBubbles)
                {
                    SendToServerCrypto(HMessage.Construct(_header.RoomUserWhisper, $"{user} [Tween Bot V3] {msg}", _rand.Next(0, 7)));
                }
                else
                {
                    SendToServerCrypto(HMessage.Construct(_header.RoomUserWhisper, $"{user} [Tween Bot V3] {msg}", 38));
                }
            }
        }

        public void LoadRoomPass(int roomId, string roomPass)
        {
            SendToServerCrypto(HMessage.Construct(_header.RequestRoomLoad, roomId, roomPass, -1));
        }

        public void Dance(bool status)
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomUserDance, status ? 1 : 0));
        }

        public void Wave()
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomUserAction, 1));
        }

        public void ChangeClothes(string figureId)
        {
            SendToServerCrypto(HMessage.Construct(_header.UserSaveLook, "M", figureId));
        }

        public void Sit(bool status)
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomUserSit, status ? 1 : 0));
        }

        public void RandomClothesM()
        {
            SendToServerCrypto(HMessage.Construct(_header.UserSaveLook, "M", visus[_rand.Next(0, visus.Count)]));
        }

        public void RandomClothesF()
        {
            SendToServerCrypto(HMessage.Construct(_header.UserSaveLook, "F", visus2[_rand.Next(0, visus2.Count)]));
        }

        public void ThumbsUp()
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomUserAction, 7));
        }

        public void Idle()
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomUserAction, 5));
        }

        public void JoinGroup(int grpId)
        {
            SendToServerCrypto(HMessage.Construct(_header.RequestGuildJoin, grpId));
        }

        public void LikeRoom()
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomVote, 1));
        }

        public void FriendRequest(string friend)
        {
            SendToServerCrypto(HMessage.Construct(_header.FriendRequest, friend));
        }

        public void ChangeMotto(string motto)
        {
            SendToServerCrypto(HMessage.Construct(_header.SaveMotto, motto));
        }

        public void WalkTo(int x, int y)
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomUserWalk, x, y));
        }

        public void LookTo(int x, int y)
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomUserLookAtPoint, x, y)); //RoomUserLookAtPoint
        }

        public void Respect(int user)
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomUserGiveRespect, user));
        }

        public void Scratch(int pet)
        {
            SendToServerCrypto(HMessage.Construct(_header.ScratchPet, pet));
        }

        public void Sign(int sign)
        {
            SendToServerCrypto(HMessage.Construct(_header.RoomUserSign, sign));
        }

        public void RandomBubbles(bool status)
        {
            _randomBubbles = status;
        }

        public void AntiBobba(bool status)
        {
            _antiBobba = status;
        }

        public void RandomActions(bool status)
        {
            _randomActions = status;
            if (_randomActions)
                new Task(RandomActionsTask).Start();
        }

        public void AFK(bool status)
        {
            _isAFK = status;
            if (_isAFK)
                new Task(AFKTask).Start();
        }

        public async void SignCountdown()
        {
            int sign = 10;
            while (sign > -1)
            {
                Sign(sign);
                sign--;
                await Task.Delay(1000);
            }
        }

        public void RandomRotate(bool status)
        {
            _isRotationAround = status;
            if (_isRotationAround)
                new Task(RotationTask).Start();
        }

        public void WalkAround(bool status)
        {
            _isWalkingAround = status;
            if (_isWalkingAround)
                new Task(WalkAroundTask).Start();
        }

        private async void RandomActionsTask()
        {
            while (_randomActions)
            {
                Sit(true);
                await Task.Delay(777);
                Sit(false);
                await Task.Delay(777);
                Idle();
                await Task.Delay(777);
                Sign(6);
                await Task.Delay(777);
                ThumbsUp();
                await Task.Delay(777);
                Dance(true);
                await Task.Delay(777);
                Dance(false);
            }
        }

        private async void RotationTask()
        {
            while (_isRotationAround)
            {
                LookTo(_rand.Next(0, 20), _rand.Next(0, 20));
                await Task.Delay(350);
            }
        }

        private async void AFKTask()
        {
            while (_isAFK)
            {
                SendToServerCrypto(HMessage.Construct(1321, 99, 99));
                await Task.Delay(TimeSpan.FromMinutes(5));
            }
        }

        private async void WalkAroundTask()
        {
            while (_isWalkingAround)
            {
                WalkTo(_rand.Next(1, 21), _rand.Next(1, 21));
                await Task.Delay(1000);
            }
        }

        private string GenMID(int length = 32)
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
                    return "~" + sb.ToString();
                }
            }
        }
    }
}
