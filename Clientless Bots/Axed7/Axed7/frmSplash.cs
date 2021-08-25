using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axed
{
    public partial class frmSplash : Form
    {
        FrmMain Mn = new FrmMain();
        public frmSplash()
        {
            InitializeComponent();
        }
        internal delegate void NullMethod();
        internal void EnableMe()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new NullMethod(EnableMe));
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.Show();
            return;

            try
            {

                if (System.IO.File.Exists(Application.StartupPath + "\\config.ini") == false)
                {
                    System.IO.StreamWriter BP = new System.IO.StreamWriter(Application.StartupPath + "\\config.ini");
                    BP.WriteLine("[login]");
                    BP.WriteLine("username=");
                    BP.WriteLine("password=");
                    BP.Close();
                }
                Ini.IniFile INI = new Ini.IniFile(Application.StartupPath + "\\config.ini");
                Mn.LoginScreen.txtUsername.Text = INI.IniReadValue("login", "username");
                Mn.LoginScreen.txtPassword.Text = INI.IniReadValue("login", "password");
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
            Mn.Opacity = 0;
            Application.DoEvents();
            Mn.Show();
        }
    }
}