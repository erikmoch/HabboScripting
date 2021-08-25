using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KClient
{
    public static class Handler
    {
        public static List<Connection> Bots = new List<Connection>();
        private static int _lastId;

        public static async void Start(string ssoList, MainFrm main)
        {
            var count = 0;

            string[] sso = { };
            try
            {
                sso = ssoList.Split('|');
            }
            catch
            {
                sso[0] = ssoList;
            }

            foreach (var s in sso)
            {
                _lastId++;
                Connection bot;

                if (main.IsUsingProxy)
                {
                    if (main.Proxies.Count is 0) break;
                    count++;
                    bot = new Connection(s, main, _lastId, main.Proxies.First().Key, main.Proxies.First().Value);
                    if (count == main.BotsPerProxy)
                    {
                        main.Proxies.Remove(main.Proxies.First().Key);
                        count = 0;
                    }
                }
                else
                {
                    bot = new Connection(s, main, _lastId);
                }

                bot.Connect();

                main.AddBot(_lastId);
                Bots.Add(bot);
                await Task.Delay(1000);
            }
        }

        public static void SendToAllUsingBots(List<int> ids, Action<Connection> callback)
        {
            var usingBots = Bots.Select(bot => bot).Where(bot => ids.Contains(bot.Id));
            Parallel.ForEach(usingBots, callback);
        }

        public static void SendToAllBots(Action<Connection> callback)
        {
            Parallel.ForEach(Bots, callback);
        }
    }
}
