using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace PacketLogger.Classes
{
    class HabboLogin
    {
        // Habbo Login Class
        // Variables
        private string habboUsername;
        private string habboPassword;
        private string hotel;
        // Habbo Session Variables
        private string JSESSIONID;
        private string ssoTicket;
        private string habboDCR;
        private string habboExternalTexts;
        private string habboExternalVariables;
        private string musHost;
        private string habboProccessLog;
        private long musPort;
        private long infoPort;
        private string accountID;

        // Forms
        internal wndMain mainForm;
        internal wndLogin loginForm;
        internal SockHandler sock;

        public HabboLogin(string username, string password, string hotel, wndLogin loginForm, wndMain mainForm)
        {
            // ~Constructor
            this.habboPassword = password;
            this.habboUsername = username;
            this.hotel = hotel;
            this.loginForm = loginForm;
            this.mainForm = mainForm;
            // Disable shizzle :-)

            // Start login Routine
            this.StartRoutine();
        }

        private static string GenerateRandomString(int Length)
        {
            string tmp = "";
            Random Rnd = new Random();
            for (int x = 0; x < Length; x++)
            {
                char tmp2 = (char)Rnd.Next(65, 122);
                tmp += tmp2.ToString();
            }
            return tmp;
        }

        private void StartRoutine()
        {
            this.JSESSIONID = GenerateRandomString(16);
            // Web Request
            HttpWebRequest habboRequest = (HttpWebRequest)WebRequest.Create("https://" + this.hotel + "/account/submit");
            habboRequest.ContentType = "application/x-www-form-urlencoded";
            habboRequest.Method = "POST";
            habboRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            habboRequest.Headers.Add("Cookie: __utma=149361455.1661130071.1210787490.1210787490.1210787490.1; __utmb=149361455.23.10.1210787490198; __utmc=149361455; __utmz=149361455.1210787490.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none); __qca=1210787490-25694890-213627; __qcb=751284920; __utmv=149361455.habboab%3Asecond; JSESSIONID=" + this.JSESSIONID);
            habboRequest.ServicePoint.Expect100Continue = false;
            habboRequest.AllowAutoRedirect = true;
            habboRequest.ProtocolVersion = HttpVersion.Version11;
            Stream habboStream = habboRequest.GetRequestStream();
            byte[] postData = Encoding.ASCII.GetBytes("credentials.username=" + this.habboUsername + "&credentials.password=" + this.habboPassword);
            habboStream.Write(postData, 0, postData.Length);
            habboStream.Close();
            HttpWebResponse habboResponse = (HttpWebResponse)habboRequest.GetResponse();
            habboResponse.Close();
            habboRequest = null;
            this.GenerateLoader();
        }


        private void GenerateLoader()
        {
            WebClient iNet = new WebClient();
            iNet.Headers.Add(HttpRequestHeader.Cookie, "JSESSIONID=" + this.JSESSIONID);
            string loaderSource = iNet.DownloadString("http://" + this.hotel + "/client");

            // Do a check
            if (loaderSource.IndexOf("external.texts.txt=") == -1)
            {
                // Login Failed.. Epic.
            }

            // Grab SSOTicket
            this.ssoTicket = loaderSource.Substring(loaderSource.IndexOf("sso.ticket=") + "sso.ticket=".Length).Split("\"\\".ToCharArray())[0];
            this.ssoTicket = this.ssoTicket.Split(";".ToCharArray())[0];

            // Split Proccess Log...
            this.habboProccessLog = loaderSource.Substring(loaderSource.IndexOf("processlog.url=") + "processlog.url=".Length).Split("\"\\".ToCharArray())[0];

            // Split DCR
            this.habboDCR = loaderSource.Substring(loaderSource.IndexOf("<embed src=\"") + "<embed src=\"".Length).Split("\"".ToCharArray())[0];

            // Split Mus Host
            this.musHost = loaderSource.Substring(loaderSource.IndexOf("connection.mus.host=") + "connection.mus.host=".Length).Split(";".ToCharArray())[0];

            // Split Mus Port
            try
            {
                this.musPort = long.Parse(loaderSource.Substring(loaderSource.IndexOf("connection.mus.port=") + "connection.mus.port=".Length).Split("\\\"".ToCharArray())[0]);
            }
            catch (FormatException)
            {
                // Epic Fail...
            }

            // Split Externals
            this.habboExternalVariables = loaderSource.Substring(loaderSource.IndexOf("external.variables.txt=") + "external.variables.txt=".Length).Split("\\\"".ToCharArray())[0];

            // Split Texts
            this.habboExternalTexts = loaderSource.Substring(loaderSource.IndexOf("external.texts.txt=") + "external.texts.txt=".Length).Split("\\\"".ToCharArray())[0];
            
            this.habboExternalTexts = this.habboExternalTexts.Substring(0, this.habboExternalTexts.LastIndexOf(";"));
            
            // Split Infoport [InfoHost is obsolete]
            this.infoPort = long.Parse(loaderSource.Substring(loaderSource.IndexOf("connection.info.port=") + "connection.info.port=".Length).Split("\\\"".ToCharArray())[0]);

            // Split AccountID
            this.accountID = loaderSource.Substring(loaderSource.IndexOf("account_id=") + "account_id=".Length).Split("\"\\".ToCharArray())[0];
            
            // Generate Loader
            this.GenerateLoaderFile();
        }

        private void GenerateLoaderFile()
        {
            string param = "\" bgColor=\"#000000\" width=\"960\" height=\"540\" swRemote=\"swSaveEnabled='true' swVolume='true' swRestart='false' swPausePlay='false' swFastForward='false' swTitle='Habbo Hotel' swContextMenu='true'\" swStretchStyle=\"stage\" swText=\"\" type=\"application/x-director\" pluginspage=\"http://www.macromedia.com/shockwave/download/\"";
            TextWriter io = new StreamWriter("./loader.html", false);
            // Start printing :-)
            io.WriteLine(@"<!DOCTYPE HTML PUBLIC -//W3C//DTD HTML 4.01 Transitional//EN>");
            io.WriteLine(@"<meta http-equive = content-type content = text/html; charset= iso-8859-1>");
            io.WriteLine(@"<html>");
            io.WriteLine(@"<head>");
            io.WriteLine(@"<title>Office.Boys Packet Logger :-)</title>");
            io.WriteLine(@"</head>");
            io.WriteLine(@"<body bgcolor=""#000000"">");
            io.WriteLine(@"<object classid=""clsid:166B1BCA-3F9C-11CF-8075-444553540000"" codebase=""http://download.macromedia.com/pub/shockwave/cabs/director/sw.cab#version=10,0,0,0"" id=""habbo"" width=""960"" height=""540"">");
            io.WriteLine(@"<param name=""src"" value=""" + this.habboDCR + "\">");
            io.WriteLine(@"<param name=""swRemote"" value=""swSaveEnabled='true' swVolume='true' swRestart='false' swPausePlay='false' swFastForward='false' swTitle='Habbo Hotel' swContextMenu='true' "">");
            io.WriteLine(@"<param name=""swStretchStyle"" value=""stage"">");
            io.WriteLine(@"<param name=swText value="""">");
            io.WriteLine(@"<param name=""bgColor"" value=""#000000"">");
            io.WriteLine(@"<param name=""sw6"" value=""client.connection.failed.url=http://" + this.hotel + "/client_connection_failed;external.variables.txt=" + this.habboExternalVariables + "\">");
            io.WriteLine(@"<param name=""sw8"" value=""sso.ticket=" + this.ssoTicket + ";processlog.url=" + this.habboProccessLog + "\">");
            io.WriteLine(@"<param name=""sw2"" value=""connection.info.host=" + SystemInformation.ComputerName + ";connection.info.port=" + this.infoPort + "\">");
            io.WriteLine(@"<param name=""sw4"" value=""site.url=http://" + this.hotel + ";url.prefix=http://" + this.hotel + "\">");
            io.WriteLine(@"<param name=""sw3"" value=""connection.mus.host=" + this.musHost + ";connection.mus.port=" + this.musPort + "\">");
            io.WriteLine(@"<param name=""sw1"" value=""client.allow.cross.domain=0;client.notify.cross.domain=1"">");
            io.WriteLine(@"<param name=""sw7"" value=""external.texts.txt=" + this.habboExternalTexts + ";use.sso.ticket=1\">");
            io.WriteLine(@"<param name=""sw9"" value=""account_id=" + this.accountID + "\">");
            io.WriteLine(@"<param name=""sw5"" value=""client.reload.url=https://" + this.hotel + "/account/reauthenticate?page=/client;client.fatal.error.url=http://" + this.hotel + "/client_error\">");
            io.WriteLine(@"<param name=""playerVersion"" value=""11"">");
            io.WriteLine(@"<embed src=""" + this.habboDCR + param);
            io.WriteLine(@"sw6=""client.connection.failed.url=http://" + this.hotel + "/client_connection_failed;external.variables.txt=" + this.habboExternalVariables + "\"");
            io.WriteLine(@"sw8=""sso.ticket=" + this.ssoTicket + ";processlog.url=" + this.habboProccessLog + "\"");
            io.WriteLine(@"sw2=""connection.info.host=" + SystemInformation.ComputerName + ";connection.info.port=" + this.infoPort + "\"");
            io.WriteLine(@"sw4=""site.url=http://" + this.hotel + ";url.prefix=http://" + this.hotel + "\"");
            io.WriteLine(@"sw3=""connection.mus.host=" + this.musHost + ";connection.mus.port=" + this.musPort + "\"");
            io.WriteLine(@"sw1=""client.allow.cross.domain=0;client.notify.cross.domain=1""");
            io.WriteLine(@"sw7=""external.texts.txt=" + this.habboExternalTexts + ";use.sso.ticket=1\"");
            io.WriteLine(@"sw9=""account_id=" + this.accountID + "\"");
            io.WriteLine(@"sw5=""client.reload.url=https://" + this.hotel + "/account/reauthenticate?page=/client;client.fatal.error.url=http://" + this.hotel + "/client_error\"");
            io.WriteLine(@"playerVersion=""11"" ></embed>");
            io.WriteLine(@"</object>");
            io.WriteLine(@"</body>");
            io.WriteLine(@"</html>");
            io.Close();
            // Start Sockets
            sock = new SockHandler((int)this.infoPort, this.musHost, this.mainForm);
            socketManage.mySockets.Add(0, sock);
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + "/loader.html");
            // Hide Login Form
            this.loginForm.Hide();
        }
    }
}
