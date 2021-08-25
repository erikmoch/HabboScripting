using Fiddler;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Tween_Bot_V3
{
    class Intercept
    {
        private LoginFrm _login;
        private Main _main;

        public Intercept(Main main, LoginFrm login)
        {
            _main = main;
            _login = login;
        }

        public void Start()
        {
            FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
            FiddlerApplication.Startup(8888, true, true, true);
        }

        public void Stop()
        {
            FiddlerApplication.AfterSessionComplete -= FiddlerApplication_AfterSessionComplete;
            if (!FiddlerApplication.IsStarted())
                return;
            FiddlerApplication.Shutdown();
        }

        private void FiddlerApplication_AfterSessionComplete(Session sess)
        {
            if (sess?.oRequest?.headers == null)
                return;

            if (sess.GetResponseBodyAsString().Contains("clienturl"))
            {
                //Stop();
                //_login.webBrowser1.Navigate("https://www.habbo.com.br/logout");
                //_login.Hide();
                //_main.currentAccount++;
                //_main.btnLoginBot.Enabled = true;
                //_main.btnLoginBot.Text = $"Logar ({_main.currentAccount + 1}/{_main.emails.Count})";
                var dictionary = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(sess.GetResponseBodyAsString());
                if (!dictionary.ContainsKey("clienturl")) return;
                var strArray = dictionary["clienturl"].Split('/');
                //_main.LogInfo($"[BOT {_main.currentAccount}] Conectando...");
                BotHandler.Start(strArray[strArray.Length - 1], _main);
                _main.LogInfo($"[BOT {BotHandler._lastId}] Conectando...");
            }
        }

        public bool HasInstalledCertificate()
        {
            return CertMaker.trustRootCert();
        }

        public bool InstallCertificate()
        {
            return HasInstalledCertificate() || CertMaker.createRootCert() && CertMaker.trustRootCert();
        }
    }
}
