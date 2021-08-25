using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Windows.Forms;
using System.IO;

namespace Packetlogger_Varoke.HabboTcp
{
    class ConnectionManager
    {
        public string HostIp;
        public string Normalhost;
        public int Port;
        public HabboTCP HabboConnection;
        string WINDIR = "";
        public ConnectionManager(string Host, int Port)
        {
            WINDIR = Environment.GetEnvironmentVariable("SystemRoot");
            this.Normalhost = Host;
            this.CheckHost(Host);
            IPAddress[] IPs = Dns.GetHostAddresses(Host);
            foreach (IPAddress IP in IPs)
            {
                this.HostIp = IP.ToString();
            }
            this.Port = Port;
            this.AddHost(Host);
            this.HabboConnection = new HabboTCP(this.Port, this.HostIp);
        }
        public void CheckHost(string Host)
        {
            StreamReader File = new StreamReader(WINDIR + @"\System32\drivers\etc\hosts");
            Dictionary<string, string> Options = new Dictionary<string, string>();
            string Data = @File.ReadLine();
            while (Data != null)
            {
                if (!Data.StartsWith("1"))
                {
                    Data = @File.ReadLine();
                    continue;
                }
                if (Data.Split(' ')[1] != Host)
                {
                    Options.Add(Options.Count.ToString(), Data.Split(' ')[1]);
                }
                Data = @File.ReadLine();
            }
            File.Close();
            StreamWriter mFile = new StreamWriter(WINDIR + @"\System32\drivers\etc\hosts");
            foreach (string Words in Options.Keys)
            {
                mFile.WriteLine("127.0.0.1 " + Options[Words]);
            }
            mFile.Close();
        }
        private void AddHost(string Host)
        {
            StreamReader File = new StreamReader(WINDIR + @"\System32\drivers\etc\hosts");
            Dictionary<string, string> Options = new Dictionary<string, string>();

            string Data = File.ReadLine();
            while (Data != null)
            {
                if (!Data.StartsWith("1"))
                {
                    Data = @File.ReadLine();
                    continue;
                }
                Options.Add(Options.Count.ToString(), Data.Split(' ')[1]);
                Data = File.ReadLine();
            }
            File.Close();
            if (!Options.ContainsValue(Host))
            {
                StreamWriter mFile = new StreamWriter(WINDIR + @"\System32\drivers\etc\hosts");
                foreach (string Words in Options.Keys)
                {
                    mFile.WriteLine("127.0.0.1 " + Options[Words]);
                }
                mFile.WriteLine("127.0.0.1 " + Host);
                mFile.Close();
            }
        }
    }
}
