using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Fiddler;

using Kroogle;
using Kroogle.Tags;

using Sulakore;
using Sulakore.Communication;
using Sulakore.Habbo.Protocol.Encryption;

namespace TheClient
{
    public class Program
    {
        #region E/N/D
        /// <summary>
        /// If you want to use another pair of keys, use <see cref="RsaKey.Create(int, int)"/>.
        /// </summary>
        const int FAKE_EXPONENT = 3;
        const string FAKE_MODULUS = "86851dd364d5c5cece3c883171cc6ddc5760779b992482bd1e20dd296888df91b33b936a7b93f06d29e8870f703a216257dec7c81de0058fea4cc5116f75e6efc4e9113513e45357dc3fd43d4efab5963ef178b78bd61e81a14c603b24c8bcce0a12230b320045498edc29282ff0603bc7b7dae8fc1b05b52b2f301a9dc783b7";
        const string FAKE_PRIVATE_EXPONENT = "59ae13e243392e89ded305764bdd9e92e4eafa67bb6dac7e1415e8c645b0950bccd26246fd0d4af37145af5fa026c0ec3a94853013eaae5ff1888360f4f9449ee023762ec195dff3f30ca0b08b8c947e3859877b5d7dced5c8715c58b53740b84e11fbc71349a27c31745fcefeeea57cff291099205e230e0c7c27e8e1c0512b";
        #endregion

        static byte[] _fakeServerKey, _fakeClientKey;

        static StreamWriter LogWriter { get; }
        static HKeyExchange LocalExchange { get; }
        static HKeyExchange RemoteExchange { get; set; }
        static HConnection Connection { get; } = new HConnection();

        static Program()
        {
            LogWriter = File.AppendText
                ($"Log-{DateTime.Now:yyyy-MM-dd_hh-mm-ss-tt}.txt");
            LogWriter.AutoFlush = true;

            LocalExchange = new HKeyExchange(FAKE_EXPONENT,
                FAKE_MODULUS, FAKE_PRIVATE_EXPONENT);
        }
        static void Main(string[] args)
        {
            Console.Title = "TheClient";

            Initiate().Wait();
            Console.Read();
        }

        static void EndFiddler()
        {
            FiddlerApplication.BeforeRequest -= FiddlerApplication_BeforeRequest;
            FiddlerApplication.BeforeResponse -= FiddlerApplication_BeforeResponse;
            FiddlerApplication.Shutdown();
        }
        static void StartFiddler()
        {
            FiddlerApplication.BeforeRequest += FiddlerApplication_BeforeRequest;
            FiddlerApplication.BeforeResponse += FiddlerApplication_BeforeResponse;
            FiddlerApplication.Startup(8081, FiddlerCoreStartupFlags.Default);
        }
        static async Task Initiate()
        {
            Write("Installing FiddlerCore Certificate...");
            InstallFiddlerCertificate();

            Console.Clear();
            Write("Enabling FiddleCore...");
            StartFiddler();

            Console.Clear();
            Write("Replacing Client...");

            Connection.DataIncoming += Connection_DataIncoming;
            Connection.DataOutgoing += Connection_DataOutgoing;
            await Connection.ConnectAsync("game-us.habbo.com", 38101).ConfigureAwait(false);
        }

        static void Write(string line)
        {
            line += "\r\n---------------";
            Console.WriteLine(line);
            LogWriter.WriteLine(line);
        }
        static bool InstallFiddlerCertificate()
        {
            if (!CertMaker.rootCertExists() && !CertMaker.createRootCert())
                return false;

            if (!CertMaker.rootCertIsTrusted() && !CertMaker.trustRootCert())
                return false;

            return true;
        }

        static void DecodeRsaKeys(string base64RsaKeys)
        {
            byte[] data = Convert.FromBase64String(base64RsaKeys);
            string mergedKeys = Encoding.UTF8.GetString(data);

            int modLength = mergedKeys[0];
            string modulus = mergedKeys.Substring(1, modLength);

            mergedKeys = mergedKeys.Substring(modLength);
            int exponent = int.Parse(mergedKeys.Substring(2));

            RemoteExchange = new HKeyExchange(exponent, modulus);
        }
        static void ReplaceRsaKeys(ShockwaveFlash flash)
        {
            foreach (IFlashTag flashTag in flash.Tags)
            {
                if (flashTag.TagType != TagType.DefineBinaryData) continue;

                var binaryDataTag = (DefineBinaryDataTag)flashTag;
                string binaryData = Encoding.UTF8.GetString(binaryDataTag.Data);
                if (binaryData.Contains("habbo_login_dialog"))
                {
                    string extractedRsaKeys = binaryData.GetChild("name=\"dummy_field\" caption=\"", '"');
                    DecodeRsaKeys(extractedRsaKeys);

                    string generatedRsaKeys = EncodeRsaKeys(FAKE_EXPONENT, FAKE_MODULUS);
                    binaryData = binaryData.Replace(extractedRsaKeys, generatedRsaKeys);
                    binaryDataTag.Data = Encoding.UTF8.GetBytes(binaryData);

                    flash.Build();
                    break;
                }
            }
        }
        static string EncodeRsaKeys(int exponent, string modulus)
        {
            string mergedKeys = string.Format("{0}{1} {2}",
                (char)modulus.Length, modulus, exponent);

            byte[] data = Encoding.UTF8.GetBytes(mergedKeys);
            return Convert.ToBase64String(data);
        }
        static byte[] ProcessResponse(byte[] payload, bool isFlash)
        {
            if (isFlash && payload.Length > 3000000)
            {
                var flash = new ShockwaveFlash(payload);

                ReplaceRsaKeys(flash);
                payload = flash.ToBytes();

                EndFiddler();
                Console.Clear();
                Write("Connecting...");

                return payload;
            }

            string response = Encoding.UTF8.GetString(payload);
            if (response.Contains("connection.info.host") && response.Contains("connection.info.port"))
            {
                response = response.Replace("/Habbo.swf", "/Habbo.swf?" + DateTime.Now.Millisecond);
                payload = Encoding.UTF8.GetBytes(response);
            }
            return payload;
        }

        static void FiddlerApplication_BeforeRequest(Session oSession)
        {
            oSession.bBufferResponse = true;
        }
        static void FiddlerApplication_BeforeResponse(Session oSession)
        {
            oSession.utilDecodeResponse();

            bool isFlash = (oSession.oResponse["Content-Type"] == "application/x-shockwave-flash");
            oSession.ResponseBody = ProcessResponse(oSession.responseBodyBytes, isFlash);
        }

        static void Connection_DataOutgoing(object sender, InterceptedEventArgs e)
        {
            switch (e.Step)
            {
                case 3:
                {
                    _fakeServerKey = LocalExchange.GetSharedKey(e.Packet.ReadString());
                    e.Packet.Replace<string>(0, RemoteExchange.GetPublicKey());
                    break;
                }
                case 4:
                {
                    Write("Handshake Finished!");
                    Connection.Local.Encrypter = new Rc4(_fakeServerKey);
                    Connection.Remote.Encrypter = new Rc4(_fakeClientKey);
                    break;
                }
            }

            Write($"> Outgoing({e.Packet.Header} - {e.Packet.Length}) > {e.Packet}");
        }
        static void Connection_DataIncoming(object sender, InterceptedEventArgs e)
        {
            switch (e.Step)
            {
                case 1:
                {
                    Write("Processing Handshake...");
                    RemoteExchange.DoHandshake(e.Packet.ReadString(), e.Packet.ReadString(e.Packet.Position));

                    e.Packet.Replace<string>(0, LocalExchange.GetSignedPrime());
                    e.Packet.Replace<string>(e.Packet.Position, LocalExchange.GetSignedGenerator());
                    break;
                }
                case 2:
                {
                    _fakeClientKey = RemoteExchange.GetSharedKey(e.Packet.ReadString());
                    e.Packet.Replace<string>(0, LocalExchange.GetPublicKey());

                    Connection.Local.Decrypter = new Rc4(_fakeServerKey);
                    Connection.Remote.Decrypter = new Rc4(_fakeClientKey);
                    break;
                }
            }

            Write($"< Incoming({e.Packet.Header} - {e.Packet.Length}) < {e.Packet}");
        }
    }
}