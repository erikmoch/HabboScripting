using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axed
{
    public partial class FrmBrowser : Form
    {
        public FrmBrowser()
        {
            InitializeComponent();
        }

        private void brHabbo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void FrmBrowser_FrmUnload(object sender, FormClosingEventArgs e)
        {
                e.Cancel = true;
        }

        private void FrmBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}