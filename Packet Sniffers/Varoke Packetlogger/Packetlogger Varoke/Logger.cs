using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Packetlogger_Varoke
{
    public partial class Logger : Form
    {
        private delegate void textLogger(string Text);
        private textLogger ServerLogger;
        private textLogger ClientLogger;

        public Logger()
        {
            try
            {
                this.ClientLogger = new textLogger(WriteClientLine);
                this.ServerLogger = new textLogger(WriteServerLine);
            }
            catch
            {
            }
            this.FormClosing += ClosingAction;
            InitializeComponent();
        }

        private void Logger_Load(object sender, EventArgs e)
        {

        }
        public void WriteClientLine(string Data)
        {
            if (checkBox1.Checked)
            {
                return;
            }
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(ClientLogger, Data);
                }
                else
                {
                    client.Text += Data + "\r\n";
                    this.client.SelectionStart = client.Text.Length;
                    this.client.ScrollToCaret();
                }
            }
            catch { }
        }
        public void WriteServerLine(string Data)
        {
            if (checkBox2.Checked)
            {
                return;
            }
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(ServerLogger, Data);
                }
                else
                {
                    server.Text += Data + "\r\n";
                    this.server.SelectionStart = server.Text.Length;
                    this.server.ScrollToCaret();
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.client.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.server.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string packet = this.textBox1.Text;
            packet = packet.Replace("{char2}", Convert.ToChar(2).ToString());
            packet = packet.Replace("{char1}", Convert.ToChar(1).ToString());
            packet = packet.Replace("{char0}", Convert.ToChar(0).ToString());

            AppManager.Connection.HabboConnection.SendToClient(packet);
        }
        private void ClosingAction(Object sender, FormClosingEventArgs e)
        {
            AppManager.OnClose();
        }
        private void getAdminLEVELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*StringBuilder Packet = new StringBuilder();
            Packet.Append("@B");
            Packet.Append("J");
            Packet.Append("SA");
            Packet.Append((char)1);

            Packet.Append("BK");
            Packet.Append("Activated :chooser, :furni, furni id and 'select staff rooms'");
            Packet.Append((char)1);*/

           //AppManager.Connection.HabboConnection.SendToClient(Packet.ToString());
        }

        internal void startbn()
        {
            getchars bn = new getchars();
            bn.ShowDialog();
        }

        private void separeoncharsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread b = new Thread(new ThreadStart(startbn));
            b.Start();
        }
    }
}
