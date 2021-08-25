using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tween_Bot_V3.Properties;

namespace Tween_Bot_V3
{
    public partial class AuthFrm : Form
    {
        public static Main main = new Main();
        private int mouseX = 0;
        private int mouseY = 0;
        public AuthFrm()
        {
            InitializeComponent();
        }

        private async void btnAuth_Click(object sender, EventArgs e)
        {
            try
            {
                btnAuth.Text = "Autenticando...";
                btnAuth.Enabled = false;
                var responseString = await "http://tween.ueuo.com/login.php"
                    .PostUrlEncodedAsync(new { username = txtUser.Text, password = txtPass.Text })
                    .ReceiveString();
                if (responseString == "true")
                {
                    Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Credenciais incorretas.", "Tween Bot V3");
                    btnAuth.Enabled = true;
                    btnAuth.Text = "Autenticar";
                }
            }
            catch
            {
                btnAuth.Enabled = true;
                btnAuth.Text = "Autenticar";
                MessageBox.Show("Não foi possível conectar ao servidor de autenticação.", "Tween Bot V3");
            }
        }

        #region Design shit
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
            Application.Exit();
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }
        #endregion

        private void AuthFrm_Load(object sender, EventArgs e)
        {
            txtUser.Text = "tween";
            txtPass.Text = "tati";
            btnAuth.PerformClick();
        }
    }
}
