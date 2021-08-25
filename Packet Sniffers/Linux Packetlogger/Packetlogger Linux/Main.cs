using System;
using System.Text;
using System.IO;
namespace PacketloggerLinux
{
	class MainClass
	{
		public static StringBuilder clientLog;
		public static void Main (string[] args)
		{
			Console.Title = "Linux Packetlogger -- LittleJ";
			clientLog = new StringBuilder();
			new HabboConnection();
			while(true)
			{
				string w = Console.ReadLine();
				switch(w)
				{
					case "clear":
						Console.Clear();
						clientLog = new StringBuilder();
						break;
					case "save":
						
						StreamWriter wr = new StreamWriter("logger.txt");
						wr.WriteLine(clientLog.ToString());
						wr.Close();
					
						clientLog = new StringBuilder();
						break;
					
				default:
					Console.WriteLine(Convert.ToInt32(w[0]));
					break;
				}
			}
		}
	}
}

