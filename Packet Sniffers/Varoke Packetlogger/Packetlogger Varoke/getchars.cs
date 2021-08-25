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
    public partial class getchars : Form
    {
        public getchars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = textBox1.Text;
            conn = conn.Replace("[0]", Convert.ToChar(0).ToString());
            conn = conn.Replace("[1]", Convert.ToChar(1).ToString());
            conn = conn.Replace("[2]", Convert.ToChar(2).ToString());
            conn = conn.Replace("[3]", Convert.ToChar(3).ToString());
            conn = conn.Replace("[4]", Convert.ToChar(4).ToString());
            conn = conn.Replace("[10]", Convert.ToChar(10).ToString());
            conn = conn.Replace("[13]", Convert.ToChar(13).ToString());

            char[] ToSepare = conn.ToCharArray();
            foreach (char i in ToSepare)
            {
                int z = Encoding.ASCII.GetBytes(i.ToString())[0];
                    if (!GeneralSystem.IsValidName(i.ToString()))
                        conn = conn.Replace(Convert.ToChar(z).ToString(), "{char" + z + "}");
            }
            textBox2.Text = conn;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
