using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Packetlogger_Varoke
{
    public partial class EnterInfo : Form
    {
        public EnterInfo()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            AppManager.OnClose();
        }
        private void port_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            if (Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
                return;
            }
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Connecting...";
            button1.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Text == "Connecting...")
            {
                if (this.hostname.Text == "" || this.port.Text == "")
                {
                    button1.Text = "Connect";
                    button1.Enabled = true;
                    MessageBox.Show(null, "Please enter hostname and port", "Packetlogger Varoke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    timer1.Stop();
                    return;
                }
                button1.Text = "Editing hosts...";
            }
            else if (button1.Text == "Editing hosts...")
            {
                AppManager.Connection = new HabboTcp.ConnectionManager(this.hostname.Text, Convert.ToInt32(this.port.Text));
                AppManager.Packetlogger = new Logger();
                AppManager.Packetlogger.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
