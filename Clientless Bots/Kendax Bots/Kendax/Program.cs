using System;
using Sulakore;
using System.Linq;
using Sulakore.Habbo;
using System.Windows.Forms;
using System.Collections.Generic;
using Sulakore.Protocol.Encryption;

namespace Kendax
{
    static class Program
    {
        public static Dictionary<string, HSession> Emails { get; set; }
        public static Dictionary<string, HSession> Accounts { get; set; }
        public static Dictionary<HSession, HKeyExchange> Connections { get; set; }

        [STAThread]
        static void Main()
        {
            LoadHeaders();
            Emails = new Dictionary<string, HSession>();
            Accounts = new Dictionary<string, HSession>();
            Connections = new Dictionary<HSession, HKeyExchange>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        static void LoadHeaders()
        {
            HHeaders.Motto = 2868;
            HHeaders.Say = 2169;
            HHeaders.Walk = 195;
            HHeaders.Pong = 3936;
            HHeaders.Dance = 3973;
            HHeaders.Sign = 2592;
            HHeaders.Shout = 2738;
            HHeaders.Rotate = 3390;
            HHeaders.Stance = 1183;
            HHeaders.Trade = 3319;
            HHeaders.Respect = 3016;
            HHeaders.AddFriend = 637;
            HHeaders.Clothes = 422;
            HHeaders.Gesture = 3923;
            HHeaders.Navigate = 244;
        }
    }
}