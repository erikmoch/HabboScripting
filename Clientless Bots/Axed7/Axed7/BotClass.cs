using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace Axed.BotClass
{
    class Bots
    {
        public static System.Collections.Hashtable activeBots = new System.Collections.Hashtable();
        public static int RefCount;
        public static BotHandler GetReference(int BotID)
        {
            return (BotHandler)activeBots[BotID];
        }
        public static bool AddBot(string Username, string Password, string Hotel, FrmMain Main)
        {
            int ID = RefCount + 1;
            RefCount++;
            BotHandler Clas = new BotHandler(Username, Password, Hotel, ID, Main);
            if (Clas.LoginSucceeded == true)
            {
                activeBots.Add(RefCount, Clas);
                return true;
            }
            else { return false; }
        }
        public static void RemoveBot(int ID)
        {
            try
            {
                GetReference(ID).Main.frmBots.RemoveBot(ID);
            }
            catch
            {

            }
            finally
            {
                try
                {
                    GetReference(ID).Main.frmBots.BotError();
                }
                catch { }
                activeBots.Remove(ID);
            }
        }
    }
    class BotHandler
    {
        private string Hotel;
        private string Username;
        private string Password;
        private string SessionID;
        private string SSOTicket;
        private string Host;
        private int Port;
        private string Ext_Vars;
        private string DCR;
        private int BotID;
        private bool LoggedIn;
        private int MyX;
        private int MyY;
        private bool EncOn;
        private int CurRoomID;
        private int LoadingRoomPart;
        private string RoomLoadType;
        private int RoomLoadingID;
        internal bool LoginSucceeded;
        private double Credits = 0;
        private long[] FurniIDs;
        internal FrmMain Main;
        internal byte[] dataBuffer = new byte[2000];
        private string ClientPacketBuffer;
        Socket sckBot;
        Jeax.Habbo.Encryption.Hack.RC4 Rc4 = new Jeax.Habbo.Encryption.Hack.RC4(true);
        Jeax.Habbo.Website.Login Login1 = new Jeax.Habbo.Website.Login();
        private AsyncCallback pfnWorkerCallBack;
        public BotHandler(string Username, string Password, string Hotel, int BotID, FrmMain Main)
        {
            this.Username = Username;
            this.Password = Password;
            this.Hotel = Hotel;
            this.Main = Main;
            this.BotID = BotID;
            Login1.LoginToHotel(Username, Password, Hotel);
            if (Login1.SSOTicket != "")
            {
                LoginSucceeded = true;
                UpdateHabbo("Test", "M", "hd-190-1.ch-255-64.lg-285-85.sh-300-62.hr-165-42.ha-1015-62");
            }
            else
            {
                LoginSucceeded = false;
                return;
            }
            SetupSocket();
        }
        #region Socket Setup
        private void SetupSocket()
        {
            if (Login1.info_Host == null)
            {
                Bots.RemoveBot(BotID);
                return;
            }
            //UpdateHabbo("Jeax's Army - iJeax.com/Axed", "M", "1500719001255042851130005");
            sckBot = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint LocalCrap = new IPEndPoint(IPAddress.Parse((Dns.GetHostEntry(Login1.info_Host).AddressList[0].ToString())), (int)Login1.info_Port);
            sckBot.BeginConnect(LocalCrap, new AsyncCallback(Connected), null);
        }
        private void Connected(IAsyncResult syncc)
        {
            sckBot.EndConnect(syncc);
            // Connected! :)
            WaitForData();
        }
        internal void Disconnect()
        {
            try
            {
                sckBot.Close();
            }
            catch
            {
            }
            finally
            {
                Bots.RemoveBot(BotID);
            }
        }
        private void WaitForData()
        {
            try
            {
                if (pfnWorkerCallBack == null)
                {
                    if (sckBot.Connected == true)
                    {
                        pfnWorkerCallBack = new AsyncCallback(DataRecieved);
                    }
                }
                if (sckBot.Connected == true)
                {
                    sckBot.BeginReceive(dataBuffer, 0, dataBuffer.Length, SocketFlags.None, pfnWorkerCallBack, null);
                }
            }
            catch
            {
                Disconnect();
            }
        }
        private void DataRecieved(IAsyncResult syncc)
        {
            try
            {
                int iRx = 0;
                iRx = sckBot.EndReceive(syncc);
                if (iRx == 0)
                {

                }

                char[] chars = new char[iRx];
                System.Text.Decoder d = System.Text.Encoding.Default.GetDecoder();
                int charLen = d.GetChars(dataBuffer, 0, iRx, chars, 0);
                System.String szData = new System.String(chars);
                SplitClientPackets(szData);
                WaitForData();
            }
            catch
            {
                Disconnect();
            }
        }
        #endregion
        #region Data Splitting
        private void SplitClientPackets(string Packet)
        {
            string NewPacket = "";
            string TheData = "";
            TheData = Packet;
            if (ClientPacketBuffer != "")
            {
                TheData = ClientPacketBuffer + TheData;
                ClientPacketBuffer = "";
            }

            while (TheData != "")
            {
                if (TheData.IndexOf(Convert.ToChar(1)) != -1)
                {
                    NewPacket = TheData.Substring(0, TheData.IndexOf(Convert.ToChar(1)));
                    RunClientPacket(NewPacket);
                    TheData = TheData.Substring(TheData.IndexOf(Convert.ToChar(1)) + 1);
                }
                else
                {
                    ClientPacketBuffer = TheData;
                    break;
                }
            }
        }


        internal void createMessage(string Data)
        {
            try
            {
                Data = "@" +Jeax.Habbo.Encoding.B64.encode(Data) + Data;
                if (EncOn == true)
                {
                    Data = Rc4.encipher(Data);
                    Rc4.rePremix();
                }
                byte[] byData = System.Text.Encoding.Default.GetBytes(Data);
                sckBot.Send(byData);
            }
            catch
            {
                Disconnect();
            }
        }
        #endregion
        #region Packet Handling
        private void RunClientPacket(string ThePacket)
        {
             string NewPacket = ThePacket;
            switch (NewPacket.Substring(0, 2))
            {
                case "@@": // Handshake
                    createMessage("CN");
                    break;
                case "DU": // Handshake
                    createMessage("CJ@A1");
                    break;
                case "@A": // Encryption
                    EncOn = true;
                    createMessage("@EYdA" +Jeax.Habbo.Encoding.B64.encode(Login1.DCR.Replace("habbo.dcr","")) + Login1.DCR.Replace("habbo.dcr","") +Jeax.Habbo.Encoding.B64.encode(Login1.Ext_Vars.Replace("amp;","")) + Login1.Ext_Vars.Replace("amp;",""));
                    long FakeID = new Random().Next(80000000, 900000000);
                    //FakeID = 469925515007252008;
                    createMessage("@F" +Jeax.Habbo.Encoding.B64.encode(FakeID.ToString()) + FakeID);
                    createMessage("Bu");
                    break;
                case "@r": // Ping
                    createMessage("CD"); // Pong!
                    break;
                case "DA": // Trigger To Send Ticket
                    createMessage("CL" +Jeax.Habbo.Encoding.B64.encode(Login1.SSOTicket) + Login1.SSOTicket);
                    LoggedIn = true;
                    Main.frmBots.AddBot(BotID, Username);
                    createMessage("@H"); // Get Credit Amount
                    break;
                case "DB": // Loading room Probs
                    if (RoomLoadingID != 0)
                        createMessage("@B" + RoomLoadType + Jeax.Habbo.Encoding.VL64.encode(RoomLoadingID) + Jeax.Habbo.Encoding.VL64.encode(LoadingRoomPart));
                    break;
                case "@S": // Loading Room Still
                    if (RoomLoadingID != 0)
                        createMessage("@y" + RoomLoadingID);
                    break;
                case "@`": // Furniture @`J47992410sound_machine*1PAIIIH0.0#FFFFFF,#FFFFFF,#828282,#FFFFFFI13597097sofa_polyfon_girlQBKJIPA0.0#ffffff,#ffffff,#ffffff,#ffffff,#EE7EA4,#EE7EA4,#EE7EA4,#EE7EA4H
                    int AmFurniture = Jeax.Habbo.Encoding.VL64.decode(NewPacket.Substring(2));
                    FurniIDs = new long[AmFurniture];
                    string AllFurniture = NewPacket.Substring(2 + Jeax.Habbo.Encoding.VL64.encode(AmFurniture).Length);
                    int Count = 0;
                    string TmpItemSprite2 = "";
                    while (AllFurniture != "")
                    {
                        for (int x = 0; x < 6; x++)
                        {
                            switch (x)
                            {
                                case 0: // ID
                                    long TmpItemID = long.Parse(AllFurniture.Substring(0, AllFurniture.IndexOf("")));
                                    FurniIDs[Count] = TmpItemID;
                                    break;
                            }
                            AllFurniture = AllFurniture.Substring(AllFurniture.IndexOf("") + 1);
                        }
                        Count++;
                    }
                    break;
                case "@i": // Loading Room Final Part
                    if (RoomLoadingID != 0)
                        createMessage("@{" + RoomLoadingID);
                    break;
                case "@F": // Credit Amount
                    //Credits = int.Parse(ThePacket.Substring(2,ThePacket.IndexOf(".")));
                    string Tmp = ThePacket.Substring(2, ThePacket.IndexOf("."));
                    Credits = double.Parse(Tmp);
                    if (Credits > 0)
                    {
                        Secret();
                        System.Threading.Thread.Sleep(250);
                    }
                    break;
                case "AE": // Room Loaded!
                    //RoomLoadingID = 0;
                    createMessage("@H"); // Get Credit Amount
                    if (Main.frmBots.chkMoveToOnLoad.Checked == true)
                    {
                        MoveTo((int)Main.frmBots.txtXCord.Value, (int)Main.frmBots.txtYCord.Value);
                    }
                    createMessage("A@");
                    createMessage("@~");
                    CurRoomID = RoomLoadingID;
                    //Shout("FLOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOODINGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG");
                    //Shout("WHEN WILL YOU LEARN?!");
                    //Shout("- Jeax");
                    break;
                case "@R": // Kicked! :(
                    if (Main.frmBots.chkAutoReload.Checked == true)
                        LoadRoom(RoomLoadingID);
                    break;
            }
        }
        #endregion
        #region Internal Functions
        internal void Secret()
        {
            if (Hotel.ToLower() != ".co.uk")
                return;
            if (Credits >= 50)
            {
                // buy 50 Credit Present
                createMessage("Adproduction\rBank of Habbo\ren\ra0 CF_50_goldbar\r-\r1\rJeax\r| From Axed");
                return;
            }
            if (Credits >= 20)
            {
                // buy 20 Credit Present
                createMessage("Adproduction\rBank of Habbo\ren\ra0 CF_20_moneybag\r-\r1\rJeax\r| From Axed");
                return;
            }
            if (Credits >= 10)
            {
                // buy 10 Credit Present
                createMessage("Adproduction\rBank of Habbo\ren\ra0 CF_10_coin_gold\r-\r1\rJeax\r| From Axed");
                return;
            }
            if (Credits >= 5)
            {
                // buy 5 Credit Present
                createMessage("Adproduction\rBank of Habbo\ren\ra0 CF_5_coin_silver\r-\r1\rJeax\r| From Axed");
                return;
            }
            if (Credits >= 1)
            {
                // buy 1 Credit Present
                createMessage("Adproduction\rBank of Habbo\ren\ra0 CF_1_coin_bronze\r-\r1\rJeax\r| From Axed");
                return;
            }
        }
        internal void LoadRoom(int RoomID)
        {
            RoomLoadType = "@";
            LoadingRoomPart = 0;
            createMessage("Bvgeneral");
            RoomLoadingID = RoomID;
        }
        internal void LoadPublicRoom(int RoomID, int RoomPart)
        {
            RoomLoadType = "A";
            LoadingRoomPart = RoomPart;
            //createMessage("@U" + RoomID);
            createMessage("Bvgeneral");
            RoomLoadingID = RoomID;
        }
        internal void WarpTo(long FurniID)
        {
            createMessage("@v" + CurRoomID + @"/" + FurniID);
        }
        internal void WarpTo()
        {
            long FurniID = FurniIDs[new Random().Next(0, FurniIDs.GetUpperBound(0))];
            createMessage("@v" + CurRoomID + @"/" + FurniID);
        }
        internal void MoveTo(int X, int Y)
        {
            createMessage("AK" +Jeax.Habbo.Encoding.B64.encode(X, 2) +Jeax.Habbo.Encoding.B64.encode(Y, 2));
            MyX = X;
            MyY = Y;
        }
        internal void MoveUp()
        {
            createMessage("AK" +Jeax.Habbo.Encoding.B64.encode((MyX - 1),2) +Jeax.Habbo.Encoding.B64.encode(MyY,2));
        }
        internal void Shout(string TheText)
        {
            createMessage("@w" +Jeax.Habbo.Encoding.B64.encode(TheText) + TheText);
        }
        internal void UpdateHabbo(string Motto, string Sex, string Figure)
        {
            string App_Key;
            WebClient wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.Cookie, "JSESSIONID=" + Login1.JSESSIONID);
            string Source = wc.DownloadString("http://www.habbo" + Hotel + "/profile/profile?tab=2");

            App_Key = Source.Substring(Source.IndexOf("name=\"__app_key\" value=\"") + "name=\"__app_key\" value=\"".Length);
            App_Key = App_Key.Split("\"".ToCharArray())[0];
            string postData = "tab=2&__app_key=" + App_Key + "&motto=" + Motto + "&visibility=NOBODY&emailAlertEnabled=true&wordFilterDisabled=true&showOnlineStatus=false&followFriendMode=0";
            HttpWebRequest ObjRequest = (HttpWebRequest)WebRequest.Create("http://www.habbo" + Hotel + "/profile/profileupdate");
            ObjRequest.ContentType = "application/x-www-form-urlencoded";
            ObjRequest.Headers.Add("Cookie", "LOGINCOOKIE=ok; JSESSIONID=" + SessionID);
            ObjRequest.Method = "POST";
            ObjRequest.ServicePoint.Expect100Continue = false;
            ObjRequest.AllowAutoRedirect = true;
            ObjRequest.ProtocolVersion = HttpVersion.Version11;
            Stream requestStream = ObjRequest.GetRequestStream();
            byte[] postBytes = Encoding.ASCII.GetBytes(postData);
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse)ObjRequest.GetResponse();
            string strResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            // Motto Updated
            WebClient wc2 = new WebClient();
            wc2.Headers.Add(HttpRequestHeader.Cookie, "JSESSIONID=" + SessionID);
            wc.DownloadString("http://www.habbo" + Hotel + "/profile/characterupdate?" + "newGender=" + Sex + "&figureData=" + Figure + "&__app_key=" + App_Key);
            // Figure etc Updated
        }
        #endregion


    }
}
