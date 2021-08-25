using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
namespace Packetlogger_Varoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Process p = new Process();
            p.StartInfo = new ProcessStartInfo("cmd", "/c \"start www.varoke.es\"")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void handle_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EnterInfo().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (handle.Text)
            {
                case "Wait...":
                    handle.Text = "3";
                    break;
                case "3":
                    handle.Text = "2";
                    break;
                case "2":
                    handle.Text = "1";
                    break;
                case "1":
                    handle.Text = "Start Packetlogger";
                    handle.Enabled = true;
                    timer1.Stop();
                    break;
            }
        }
    }
}
