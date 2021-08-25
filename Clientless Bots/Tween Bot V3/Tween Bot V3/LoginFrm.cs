using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tween_Bot_V3.Properties;

namespace Tween_Bot_V3
{
    public partial class LoginFrm : Form
    {
        private Intercept _intercept;
        private Main _main;
        private int mouseX = 0;
        private int mouseY = 0;

        public LoginFrm(Main main)
        {
            InitializeComponent();
            VerifyVersion(webBrowser1);
            webBrowser1.ScriptErrorsSuppressed = true;
            _main = main;
            _intercept = new Intercept(main, this);
        }

        public void Auth(string email, string pass)
        {
            _intercept.Start();
            webBrowser1.Navigate("https://www.habbo.com.br/hotel");
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("input"))
            {
                if (element.GetAttribute("name") == "email")
                    element.SetAttribute("value", email);
                if (element.GetAttribute("name") == "password")
                    element.SetAttribute("value", pass);
            }
            foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("button"))
                if (element.GetAttribute("className") == "login-form__button")
                    element.InvokeMember("click");
        }

        public void VerifyVersion(WebBrowser webbrowser)
        {
            string appName = "";
            try
            {
                appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";

                RegistryKey fbeKey = null;
                ////For 64 bit Machine 
                fbeKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                if (fbeKey == null)
                    fbeKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION");
                using (fbeKey)
                {
                    fbeKey.SetValue(appName, 11000, RegistryValueKind.DWord);
                }


                //For 32 bit Machine 
                fbeKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                if (fbeKey == null)
                    fbeKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION");
                using (fbeKey)
                {
                    fbeKey.SetValue(appName, 11000, RegistryValueKind.DWord);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(appName + "\n" + ex.ToString(), "Unexpected error setting browser mode!");
            }
        }

        #region Design shit
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.errorred;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.errorwhite;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _intercept.Stop();
            _main.btnLoginBot.Enabled = true;
            _main.btnLoginBot.Text = $"Logar ({_main.currentAccount + 1}/{_main.emails.Count})";
            Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.Crimson;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.White;
        }
        #endregion

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //MessageBox.Show("Test");
        }
    }
}
