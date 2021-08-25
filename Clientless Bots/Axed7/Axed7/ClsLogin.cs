using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace Axed
{
    class ClsLogin
    {
        internal string SessionID;
        private string Username;
        private string Password;
        private string Hotel;
        private string DCR = "";
        private string Ext_Vars;
        private string Ext_Texts;
        private long info_Port;
        private string info_Host;
        private long mus_Port;
        private string mus_Host;
        private string SSOTicket;
        private FrmBrowser MyBrowser;
        private FrmMain Main;
        Jeax.Habbo.Website.Login Login1 = new Jeax.Habbo.Website.Login();
        public ClsLogin(string Username, string Password, string Hotel, FrmBrowser MyBrowser, FrmMain Main, string JSESSIONID)
        {
            this.SessionID = JSESSIONID;
            this.Username = Username;
            this.Password = Password;
            this.Hotel = Hotel;
            this.MyBrowser = MyBrowser;
            this.Main = Main;
            if (Main.LoginScreen.chkSaveDetails.Checked == true)
            {
                Ini.IniFile INI = new Ini.IniFile(System.Windows.Forms.Application.StartupPath + "\\config.ini");
                INI.IniWriteValue("login", "username", Username);
                INI.IniWriteValue("login", "password",Password);
            }
            if (JSESSIONID == "")
            {
                Login1.LoginToHotel(Username, Password, Hotel);
                if (Login1.SSOTicket != "")
                {
                    //DealWithSource();
                    LoginUser();
                    return;
                }
            }
            else // Login with only JSESSIONID
            {
                Login1.LoginToHotel(Hotel, JSESSIONID);
                if (Login1.SSOTicket != "")
                {
                    LoginUser();
                    return;
                }
                else
                    Main
            }

        }
        internal void LoginUser()
        {
            Main.UpHabbo.SetupWindow(SessionID, Hotel);
            Main.lblStatus.Text = "Creating HTML file";
            TextWriter tw = new StreamWriter("./tmp.html", false);
            tw.WriteLine(@"<!DOCTYPE HTML PUBLIC -//W3C//DTD HTML 4.01 Transitional//EN>");
            tw.WriteLine(@"<meta http-equive = content-type content = text/html; charset= iso-8859-1>");
            tw.WriteLine(@"<html>");
            tw.WriteLine("");
            tw.WriteLine(@"<head>");
            tw.WriteLine(@"</head><body bgcolor=""#000000"">");
            tw.WriteLine(@"<object classid=""clsid:166B1BCA-3F9C-11CF-8075-444553540000"" codebase=""http://download.macromedia.com/pub/shockwave/cabs/director/sw.cab#version=8,5,1,0"" id=""axed"" width=""720"" height=""540"">");
            tw.WriteLine(@"<param name=""src"" value=" + Login1.DCR);
            tw.WriteLine(@"<param name=swText value="""">");
            tw.WriteLine(@"<param name=""sw8"" value=""use.sso.ticket=1;sso.ticket=" + Login1.SSOTicket + @""">");
            tw.WriteLine(@"<param name=""sw1"" value=""connection.info.host=" + System.Windows.Forms.SystemInformation.ComputerName + @""">");
            tw.WriteLine(@"<param name=""sw2"" value=""connection.info.port=" + Login1.info_Port + @""">");
            tw.WriteLine(@"<param name=""sw4"" value=""connection.mus.host=" + Login1.mus_Host + @""">");
            tw.WriteLine(@"<param name=""sw5"" value=""connection.mus.port=" + Login1.mus_Port + @""">");
            tw.WriteLine(@"<param name=""sw6"" value=""external.variables.txt="+ Login1.Ext_Vars + @""">""""");
            tw.WriteLine(@"<param name=""sw7"" value=""external.texts.txt=" + Login1.Ext_Texts + @""">""""");
            tw.WriteLine(@"<embed src=" + Login1.DCR);
            tw.WriteLine(@"bgColor=""#000000"" width=""720"" height=""540""");
            tw.WriteLine(@"sw1 = ""connection.info.host=" + System.Windows.Forms.SystemInformation.ComputerName + @"""");
            tw.WriteLine(@"sw2 = ""connection.info.port=" + Login1.info_Port + @"""");
            tw.WriteLine(@"sw4 = ""connection.mus.host=" + Login1.mus_Host + @"""");
            tw.WriteLine(@"sw5 = ""connection.mus.port="+ Login1.mus_Port + @"""");
            tw.WriteLine(@"sw6 = ""external.variables.txt="+ Login1.Ext_Vars + @"""");
            tw.WriteLine(@"sw7 = ""external.texts.txt=" + Login1.Ext_Texts + @"""");
            tw.WriteLine(@"sw8 = ""use.sso.ticket=1;sso.ticket=" + Login1.SSOTicket + @"""");
            tw.WriteLine("</embed>");
            tw.WriteLine("</Object");
            tw.WriteLine("/Body");
            tw.WriteLine("/Html");
            tw.Flush();
            tw.Close();
            if (!Main.LoginScreen.chkVista.Checked)
            {
                MyBrowser.brHabbo.Navigate(System.Windows.Forms.Application.StartupPath + @"\tmp.html");
            }
            else
            {
                System.Diagnostics.Process.Start("File://" + System.Windows.Forms.Application.StartupPath + @"\tmp.html");
            }
            Main.lblStatus.Text = "Loading...";
            ConnectionHandler CnHandle = new ConnectionHandler(Login1.info_Host, (int)Login1.info_Port, Main,SessionID,Hotel,Login1.SSOTicket);
            //ConnectionManager.activeSockets.Remove(0);
            //ConnectionManager.activeSockets.Add(0, CnHandle);
            ConnectionManager.activeSockets.Remove(0);
            ConnectionManager.activeSockets.Add(0, CnHandle);
        }
        private string GetLoginTicket()
        {
            string Source;
            string session;
            string loginTicket;
            WebClient wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727)");
            wc.Headers.Add("Cache-Control", "no-cache");
            wc.Headers.Add(HttpRequestHeader.Cookie, "LOGINCOOKIE=OK");
            Source = wc.DownloadString("https://www.habbo" + Hotel + "/account/login");
            loginTicket = Source.Substring(Source.IndexOf("loginTicket\" value=\"") + "loginTicket\" value=\"".Length);
            loginTicket = loginTicket.Split("\"".ToCharArray())[0];
            session = wc.ResponseHeaders.Get("Set-Cookie");
            SessionID = session.Substring(session.IndexOf("JSESSIONID=") + "JSESSIONID=".Length).Split(";".ToCharArray())[0];
            return loginTicket;
        }

        private void Initialise()
        {
            Main.lblStatus.Text = "Attempting to login to account '" + Username + "'";
            GetLoginTicket();
            string postData = /*"loginTicket=" + GetLoginTicket() + "&" + */"page=%2F&service=%2Fsecurity_check&credentials.username=" + Username + "&credentials.password=" + Password;
            HttpWebRequest ObjRequest = (HttpWebRequest)WebRequest.Create("https://www.habbo" + Hotel + "/account/submit");
            ObjRequest.ContentType = "application/x-www-form-urlencoded";
            ObjRequest.Headers.Add("Cookie", "LOGINCOOKIE=ok; JSESSIONID=" + SessionID);
            ObjRequest.Method = "POST";
            ObjRequest.ServicePoint.Expect100Continue = false;
            ObjRequest.AllowAutoRedirect = true;
            ObjRequest.ProtocolVersion = HttpVersion.Version11;
            //ObjRequest.CookieContainer = new CookieContainer();
            Stream requestStream = ObjRequest.GetRequestStream();
            byte[] postBytes = Encoding.ASCII.GetBytes(postData);
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse)ObjRequest.GetResponse();
            string strResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            // Logged In (SHOULD BE :@)
            DealWithSource();
        }
        private void DealWithSource()
        {
            WebClient wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.Cookie, "JSESSIONID=" + Login1.JSESSIONID);
            string Source = wc.DownloadString("http://www.habbo" + Hotel + "/client");
            if (Source.IndexOf("external.texts.txt") == -1) // Failed To Login
            {

                Main.lblStatus.Text = "Failed to login";
                Main.cmdConnect.Enabled = true;
                Main.cmdDisconnect.Enabled = false;
                Main.LoginScreen.Show();
                Main.LoginScreen.Focus();
                return;
            }
            Main.lblStatus.Text = "Grabbing loader information";
            string sessTicket = Source.Substring(Source.IndexOf(";sso.ticket=") + "sso.ticket=".Length + 1).Split("\"".ToCharArray())[0];
            DCR = Source.Substring(Source.IndexOf("<embed src=\"") + "embed src=\"".Length + 1).Split("\"".ToCharArray())[0];
            Ext_Vars = Source.Substring(Source.IndexOf("external.variables.txt=") + "external.variables.txt=".Length).Split(";".ToCharArray())[0];
            Ext_Texts = Source.Substring(Source.IndexOf("external.texts.txt=") + "external.texts.txt=".Length).Split("\"".ToCharArray())[0];
            mus_Host = Source.Substring(Source.IndexOf("connection.mus.host=") + "connection.mus.host=".Length).Split(";".ToCharArray())[0];
            mus_Port = long.Parse(Source.Substring(Source.IndexOf("connection.mus.port=") + "connection.mus.port=".Length).Split("\"".ToCharArray())[0]);
            info_Host = Source.Substring(Source.IndexOf("connection.info.host=") + "connection.info.host=".Length).Split(";".ToCharArray())[0];
            info_Port = long.Parse(Source.Substring(Source.IndexOf("connection.info.port=") + "connection.info.port=".Length).Split("\"".ToCharArray())[0]);
            SSOTicket = sessTicket;
        }

    }
}
