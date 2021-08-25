using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Axed
{
    public partial class FrmOtherBrowser : Form
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);

        public FrmOtherBrowser()
        {
            InitializeComponent();
        }
        internal void SetupWindow(string sessionID, string Hotel)
        {
            InternetSetCookie("http://www.habbo" + Hotel, "JSESSIONID", sessionID);
            brOther.Navigate("http://www.habbo" + Hotel + "/profile/profile");
        }
        private void brOther_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}