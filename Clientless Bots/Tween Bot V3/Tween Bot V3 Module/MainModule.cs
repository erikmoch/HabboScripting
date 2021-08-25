using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Tangine;
using Tween_Bot_V3_Module.Properties;
using WebSocketSharp;

namespace Tween_Bot_V3_Module
{
    [Module("Tween Bot V3", "Controle seus bots dinamicamente")]
    [Author("Tween")]
    public partial class MainModule : ExtensionForm
    {
        private WebSocket _server;
        private int mouseX = 0;
        private int mouseY = 0;

        private bool clothes = false;
        private bool respect = false;
        private bool scratch = false;
        private bool walk = false;
        private bool room = false;

        private List<HEntity> _entities;

        public MainModule()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _entities = new List<HEntity>();
            if (!File.Exists("websocket-sharp.dll"))
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("http://tween.ueuo.com/websocket-sharp.dll", "websocket-sharp.dll");
                }
            }
            _server = new WebSocket("ws://localhost/tweenbotv3");
            _server.OnOpen += OnOpen;
            _server.OnClose += OnClose;
        }

        private void OnOpen(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.LimeGreen;
            lblStatus.Text = "Conectado.";
            _server.Send("connection");
            btnConnect.Enabled = false;
        }

        private void OnClose(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Crimson;
            lblStatus.Text = "Desconectado.";
            btnConnect.Enabled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Text = "Conectando...";
            btnConnect.Enabled = false;
            _server.Connect();
            btnConnect.Enabled = true;
            btnConnect.Text = "Conectar";
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            _server.Send("disconnection");
            _server.Close();
        }

        [InDataCapture("RoomUsers")]
        private void OnUsers(DataInterceptedEventArgs e)
        {
            foreach (var entity in HEntity.Parse(e.Packet))
            {
                _entities.Add(entity);
            }
        }

        [OutDataCapture("RequestWearingBadges")]
        private void OnClick(DataInterceptedEventArgs e)
        {
            int id = e.Packet.ReadInteger();
            _server.Send($"frespect:{id}");
            if (clothes)
                _server.Send($"clothes:{_entities.Find(obj => obj.Id == id).FigureId}");

            if (respect)
                _server.Send($"respect:{_entities.Find(obj => obj.Id == id).Id}");
        }

        [OutDataCapture("RequestPetInformation")]
        private void OnPet(DataInterceptedEventArgs e)
        {
            int id = e.Packet.ReadInteger();
            _server.Send($"fpet:{id}");
            if (scratch)
                _server.Send($"scratch:{id}");
        }

        [OutDataCapture("RoomUserWalk")]
        private void OnWalk(DataInterceptedEventArgs e)
        {
            int x = e.Packet.ReadInteger();
            int y = e.Packet.ReadInteger();
            _server.Send($"fwalk:{x}:{y}");
            if (walk)
                _server.Send($"walk:{x}:{y}");
        }

        [OutDataCapture("RequestRoomLoad")]
        private void OnRoom(DataInterceptedEventArgs e)
        {
            int id = e.Packet.ReadInteger();
            _entities.Clear();
            _server.Send($"froom:{id}");
            if (room)
                _server.Send($"room:{id}");
        }

        [OutDataCapture("499eef89e0da2f29c486c41222808b5f")]
        private void OnGroup(DataInterceptedEventArgs e)
        {
            _server.Send($"fgroup:{e.Packet.ReadInteger()}");
        }

        private void cbTanjiClothes_CheckedChanged(object sender, EventArgs e)
        {
            clothes = cbTanjiClothes.Checked;
        }

        private void cbTanjiRespect_CheckedChanged(object sender, EventArgs e)
        {
            respect = cbTanjiRespect.Checked;
        }

        private void cbTanjiScratch_CheckedChanged(object sender, EventArgs e)
        {
            scratch = cbTanjiScratch.Checked;
        }

        private void cbTanjiWalk_CheckedChanged(object sender, EventArgs e)
        {
            walk = cbTanjiWalk.Checked;
        }

        private void cbTanjiRoom_CheckedChanged(object sender, EventArgs e)
        {
            room = cbTanjiRoom.Checked;
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
            _server.Send("disconnection");
            _server.Close();
            Close();
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void lblStatus_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void lblStatus_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
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
        #endregion
    }
}
