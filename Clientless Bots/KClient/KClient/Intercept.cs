using System.Collections.Generic;
using System.Web.Script.Serialization;
using Fiddler;

namespace KClient
{
    class Intercept
    {
        private readonly MainFrm _main;

        public Intercept(MainFrm main)
        {
            _main = main;
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
                var dictionary = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(sess.GetResponseBodyAsString());
                if (!dictionary.ContainsKey("clienturl")) return;
                var strArray = dictionary["clienturl"].Split('/');
                _main.LogSucess($"SSO Gerado [{strArray[strArray.Length - 1]}]");
                _main.AppendText(strArray[strArray.Length - 1]);
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
