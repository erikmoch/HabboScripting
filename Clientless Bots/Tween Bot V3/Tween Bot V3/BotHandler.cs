using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tween_Bot_V3
{
    class BotHandler
    {
        public static List<Bot> Bots = new List<Bot>();
        public static int _lastId;
        public static int count;

        public static async void Start(string sso, Main main)
        {
            try
            {
                if (main.isUsingProxy)
                {
                    string ip = main.Proxies.First().Key;
                    int port = main.Proxies.First().Value;
                    _lastId++;
                    count++;
                    Bot bot;

                    if (main.Proxies.Count is 0) return;
                    bot = new Bot(sso, main, _lastId, ip, port);
                    if (count == 1)
                    {
                        main.Proxies.Remove(ip);
                        count = 0;
                    }
                    main.lblProxy.Text = $"/ Proxies disponíveis: {main.Proxies.Count}";
                    main.lblBotsOn.ForeColor = Color.FromArgb(255, 128, 0);
                    bot.Connect();

                    main.AddBot(_lastId);
                    Bots.Add(bot);
                    await Task.Delay(1000);
                }
                else
                {
                    _lastId++;
                    Bot bot = new Bot(sso, main, _lastId);
                    bot.Connect();
                    main.AddBot(_lastId);
                    Bots.Add(bot);
                    await Task.Delay(1000);
                }
            }
            catch { }
        }

        public static void SendToAllUsingBots(List<int> ids, Action<Bot> callback)
        {
            var usingBots = Bots.Select(bot => bot).Where(bot => ids.Contains(bot.Id));
            Parallel.ForEach(usingBots, callback);
        }

        public static void SendToAllBots(Action<Bot> callback)
        {
            Parallel.ForEach(Bots, callback);
        }
    }
}
