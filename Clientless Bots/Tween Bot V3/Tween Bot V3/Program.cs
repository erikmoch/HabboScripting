using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Tween_Bot_V3
{
    public class Server : WebSocketBehavior
    {
        protected override void OnClose(CloseEventArgs e)
        {
            AuthFrm.main.lblTanji.ForeColor = Color.Crimson;
            AuthFrm.main.lblTanji.Text = "OFF";
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            if (e.Data == "connection")
            {
                AuthFrm.main.lblTanji.ForeColor = Color.LimeGreen;
                AuthFrm.main.lblTanji.Text = "ON";
            }

            if (e.Data == "disconnection")
            {
                AuthFrm.main.lblTanji.ForeColor = Color.Crimson;
                AuthFrm.main.lblTanji.Text = "OFF";
            }

            #region fill data
            if (e.Data.StartsWith("frespect"))
            {
                AuthFrm.main.FillRespect(Convert.ToInt32(e.Data.Split(':')[1]));
            }

            if (e.Data.StartsWith("fpet"))
            {
                AuthFrm.main.FillPet(Convert.ToInt32(e.Data.Split(':')[1]));
            }

            if (e.Data.StartsWith("fwalk"))
            {
                AuthFrm.main.FillWalk(Convert.ToInt32(e.Data.Split(':')[1]), Convert.ToInt32(e.Data.Split(':')[1]));
            }

            if (e.Data.StartsWith("froom"))
            {
                AuthFrm.main.FillWalk(Convert.ToInt32(e.Data.Split(':')[1]), Convert.ToInt32(e.Data.Split(':')[1]));
            }

            if (e.Data.StartsWith("fgroup"))
            {
                AuthFrm.main.FillGroup(Convert.ToInt32(e.Data.Split(':')[1]));
            }
            #endregion

            #region perform actions
            if (e.Data.StartsWith("clothes"))
            {
                AuthFrm.main.TanjiClothes(e.Data.Split(':')[1]);
            }

            if (e.Data.StartsWith("respect"))
            {
                AuthFrm.main.TanjiRespect(Convert.ToInt32(e.Data.Split(':')[1]));
            }

            if (e.Data.StartsWith("scratch"))
            {
                AuthFrm.main.TanjiScratch(Convert.ToInt32(e.Data.Split(':')[1]));
            }

            if (e.Data.StartsWith("walk"))
            {
                AuthFrm.main.TanjiWalk(Convert.ToInt32(e.Data.Split(':')[1]), Convert.ToInt32(e.Data.Split(':')[2]));
            }

            if (e.Data.StartsWith("room"))
            {
                AuthFrm.main.TanjiRoom(Convert.ToInt32(e.Data.Split(':')[1]));
            }
            #endregion
        }
    }

    public static class Program
    {
        public static WebSocketServer _server;
        public static Server server;
        [STAThread]
        public static void Main()
        {
            _server = new WebSocketServer();
            _server.AddWebSocketService<Server>("/tweenbotv3");
            _server.Start();
            server = new Server();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthFrm());
        }
    }
}
