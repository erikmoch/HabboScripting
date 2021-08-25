using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PacketLogger.Classes;

namespace PacketLogger
{
    public partial class wndLogin : Form
    {
        internal wndMain mainForm;

        public wndLogin(wndMain main)
        {
            InitializeComponent();
            this.mainForm = main;
        }

        private void wndLogin_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            HabboLogin login = new HabboLogin(this.txtUser.Text, this.txtPass.Text, this.txtHotel.Text, this, this.mainForm);
        }
    }
}
