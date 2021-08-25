using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Axed
{
    class ConnectionHandler
    {
        internal bool DisableTeleporting = false;
        Socket sckClient;
        Socket sckServer;
        Jeax.Habbo.Encryption.Hack.RC4 RC4 = new Jeax.Habbo.Encryption.Hack.RC4(true);
        Jeax.Habbo.Encryption.Hack.RC4 RC42 = new Jeax.Habbo.Encryption.Hack.RC4(true);
        bool EncOn;
        string Buffer = "";
        private int MyX;
        private int MyY;
        internal int MyRoomID;
        internal int _RoomID;
        internal bool WelcomeUsers;
        internal bool AutoKickUsers;
        private AsyncCallback pfnWorkerCallBack;
        private AsyncCallback pfnWorkerCallBack2;
        internal byte[] dataBuffer = new byte[1000];
        internal byte[] dataBuffer2 = new byte[1000];
        private string ClientPacketBuffer = "";
        string Hostname;
        internal string SessionID;
        string SSOTicket;
        internal string[] SandRPacket = new string[400];
        int Port;
        string Hotel;
        private string MyUsername;
        FrmMain Main;
        #region Boring Shiznit

        public ConnectionHandler(string Hostname, int Port, FrmMain Main, string SessionID, string Hotel, string SSOTicket)
        {
            this.SSOTicket = SSOTicket;
            this.Hostname = Hostname;
            this.Port = Port;
            this.Main = Main;
            this.Hotel = Hotel;
            this.SessionID = SessionID;
            #region Setup Sockets
            // SckClient Setup Listening
            sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint LocalCrap = new IPEndPoint(IPAddress.Any, Port);
            sckClient.Bind(LocalCrap);
            sckClient.Listen(1);
            AsyncCallback BP = new AsyncCallback(ConnectionRequest);
            sckClient.BeginAccept(BP, null);
            sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            #endregion
        }
        internal void DropConnection()
        {
            sckClient.Close();
            sckServer.Close();
        }
        private void ConnectionRequest(IAsyncResult syncc)
        {
            try
            {
                sckClient = sckClient.EndAccept(syncc);
                IPEndPoint ServerAddress = new IPEndPoint(IPAddress.Parse(Dns.GetHostEntry(Hostname).AddressList[0].ToString()), Port);
                sckServer.BeginConnect(ServerAddress, new AsyncCallback(Connected), null);
            }
            catch
            {

            }
        }
        private void Connected(IAsyncResult syncc)
        {
            sckServer.EndConnect(syncc);
            WaitForData();
            WaitForData2();
        }
        private void WaitForData2()
        {
            if (pfnWorkerCallBack2 == null)
            {
                if (sckClient.Connected == true)
                {
                    pfnWorkerCallBack2 = new AsyncCallback(DataRecieved2);
                }
            }
            if (sckClient.Connected == true)
            {
                sckClient.BeginReceive(dataBuffer2, 0, dataBuffer2.Length, SocketFlags.None, pfnWorkerCallBack2, null);
            }        
        }
        internal void SendToClient(string TheData)
        {
            try
            {
                    byte[] byData = System.Text.Encoding.Default.GetBytes(TheData + Convert.ToChar(1));
                    sckClient.Send(byData);
            }
            catch
            {

            }
        }
        internal void SendToServer(string TheData)
        {
            try
            {
                if (sckServer.Connected == true)
                {
                    if (EncOn == true)
                        TheData = RC42.encipher(TheData);
                   
                    byte[] byData = System.Text.Encoding.Default.GetBytes(TheData);
                    sckServer.Send(byData);
                }
            }
            catch
            {

            }
        }
        internal void SendToServerAddHeaders(string TheData)
        {
            try
            {
                if (sckServer.Connected == true)
                {
                    if (!Main.LoginScreen.chkNoEnc.Checked)
                        TheData = "@" + Jeax.Habbo.Encoding.B64.encode(TheData) + TheData;
                    if (EncOn == true)
                    {
                        TheData = RC42.encipher(TheData);
                        RC42.rePremix();
                    }
                    byte[] byData = System.Text.Encoding.Default.GetBytes(TheData);
                    sckServer.Send(byData);
                }
            }
            catch
            {

            }
        }
        private void DataRecieved(IAsyncResult syncc)
        {
            try
            {
                int iRx = 0;
                iRx = sckServer.EndReceive(syncc);
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
                DropConnection();
            }
        }
        private void DataRecieved2(IAsyncResult syncc)
        {
            int iRx = 0;
            try
            {
                iRx = sckClient.EndReceive(syncc);

                if (iRx == 0)
                {
                }

                char[] chars = new char[iRx];
                System.Text.Decoder d = System.Text.Encoding.Default.GetDecoder();
                int charLen = d.GetChars(dataBuffer2, 0, iRx, chars, 0);
                System.String szData = new System.String(chars);
                if (szData.Length == 0)
                {
                    DropConnection();
                    return;
                }
                string Enciphered = szData;
                if (EncOn == true)
                    DecipherPacket(szData);
                else
                    RunServerPackets(szData);
                WaitForData2();
            }
            catch
            {
                DropConnection();
            }
        }
        private void DecipherPacket(string szData)
        {
            string Tmp = "";
            string TmpEncoded = Buffer + szData;
            Buffer = TmpEncoded;
            while (Buffer != "")
            {
                Tmp = "";
                int PacketLength = -1;
                while (Tmp.Length < PacketLength + 3 || PacketLength == -1)
                {
                    Tmp += RC4.deciphper(TmpEncoded.Substring(0, 2));
                    if (TmpEncoded.Length >= 2)
                        TmpEncoded = TmpEncoded.Substring(2);
                    else
                    {
                        Buffer = TmpEncoded;
                        return; // Wtf how is that possible
                    }
                    if (Tmp.Length == 3)
                        PacketLength = Jeax.Habbo.Encoding.B64.decode(Tmp.Substring(1, 2));
                }
                Buffer = TmpEncoded;
                RC4.rePremix();
                RunServerPackets(Tmp);
            }
        }
        private void WaitForData()
        {
            if (pfnWorkerCallBack == null)
            {
                if (sckServer.Connected == true)
                {
                    pfnWorkerCallBack = new AsyncCallback(DataRecieved);
                }
            }
            if (sckServer.Connected == true)
            {
                sckServer.BeginReceive(dataBuffer, 0, dataBuffer.Length, SocketFlags.None, pfnWorkerCallBack, null);
            }
        }
        #endregion
        #region ClientPackets
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
        private void ExtractUsers(string UserPacket)
        {
            string ThePacket = UserPacket;
            string TmpPart;
            string TmpName;
            string TmpHabboID = "";
            int TmpRoomID = 0;
            string Splitter = Convert.ToChar(13) + "i:";
            while (ThePacket != "")
            {
                string tmpType;
                if (ThePacket.IndexOf("\r") != -1)
                    TmpPart = ThePacket.Substring(0, ThePacket.IndexOf("\r"));
                else
                    TmpPart = ThePacket;
                tmpType = TmpPart.Substring(0, 2);
                switch (tmpType)
                {
                    case "i:":
                        TmpRoomID = int.Parse(TmpPart.Substring(2));
                        break;
                    case "n:":
                        TmpName = TmpPart.Substring(2);
                        if (TmpName.ToLower() == MyUsername.ToLower())
                            MyRoomID = TmpRoomID;
                        Main.frmScripts.NewNode(TmpName, TmpRoomID);
                        Main.frmScripts.AddToNode(TmpHabboID, TmpRoomID, 5);
                        if (AutoKickUsers == true)
                            SendToServerAddHeaders("A_" + TmpName);
                        else
                        {
                            if (WelcomeUsers == true)
                                if (TmpName.ToLower() != MyUsername.ToLower())
                                    Shout("Hai " + TmpName + " welcome to the room!");
                        }
                        break;
                    case "c:": // Motto
                        string TmpMotto = TmpPart.Substring(2);
                        Main.frmScripts.AddToNode(TmpMotto, TmpRoomID,2);
                        break;
                    case "f:": // Figure
                        string TmpFigure = TmpPart.Substring(2);
                        Main.frmScripts.AddToNode(TmpFigure, TmpRoomID, 3);
                        break;
                    case "s:": // Sex
                        string TmpSex = TmpPart.Substring(2);
                        Main.frmScripts.AddToNode(TmpSex, TmpRoomID, 4);
                        break;
                    case "a:": // Habbo ID
                        TmpHabboID = TmpPart.Substring(2);
                        break;
                    case "b:": // Badge
                        string TmpBadge = TmpPart.Substring(2);
                        Main.frmScripts.AddToNode(TmpBadge, TmpRoomID, 6);
                        break;
                    case "t:": // Privs
                        string TmpGroupPrivs = TmpPart.Substring(2);
                        if (TmpGroupPrivs == "1")
                            TmpGroupPrivs = "Owner";
                        if (TmpGroupPrivs == "2")
                            TmpGroupPrivs = "Administrator";
                        if (TmpGroupPrivs == "3")
                            TmpGroupPrivs = "Member";

                        Main.frmScripts.AddToNode(TmpGroupPrivs, TmpRoomID, 8);
                        break;
                    case "g:": // Group ID
                        string tmpGroupID = TmpPart.Substring(2);
                        Main.frmScripts.AddToNode(tmpGroupID, TmpRoomID, 7);
                        break;
                }
                try
                {
                    ThePacket = ThePacket.Substring(TmpPart.Length + 1);
                }
                catch { ThePacket = ""; }
            }
        }
        private void RunClientPacket(string Packet)
        {
            string NewPacket = Packet;
            switch (NewPacket.Substring(0, 2))
            {
                case "@A":
                    string TmpKey = NewPacket.Substring(2);
                    if (!Main.LoginScreen.chkNoEnc.Checked)
                        EncOn = true;
                    //NewPacket = "@AY8004e7d26e92f447b8d9bf4ec7826bad3ad4cd2db604a69eb9f4a63f76c24e0";
                    break;
                case "@B": // Fuse Rights
                    string TmpPacket = NewPacket.Substring(2);
                    TmpPacket += "fuse_see_flat_ids";
                    TmpPacket += "fuse_habbo_chooser";
                    TmpPacket += "fuse_furni_chooser";
                    TmpPacket += "fuse_ignore_room_owner";
                    TmpPacket += "fuse_performance_panel";
                    NewPacket = NewPacket.Substring(0, 2) + TmpPacket;
                    break;
                case "@E": // User Details @E18890280JeaxTestAcc1500719001255042851130005mHHI
                    string TmpDetails = NewPacket.Substring(2);
                    string TmpOneDetail;
                    for (int x = 0; x < 6; x++)
                    {
                        TmpOneDetail = TmpDetails.Substring(0, TmpDetails.IndexOf(""));
                        TmpDetails = TmpDetails.Substring(TmpDetails.IndexOf("") + 1);
                        switch (x)
                        {
                            case 0: // ID
                                break;
                            case 1: // Name
                                MyUsername = TmpOneDetail;
                                break;
                            case 2: // Figure
                                break;
                        }
                    }
                    break;
                case @"@\": // New Users
                    ExtractUsers(NewPacket.Substring(2));
                    break;
                case "@]": // User Left
                    int TmpUserLeftID = int.Parse(NewPacket.Substring(2));
                    Main.frmScripts.RemoveNode(TmpUserLeftID);
                    break;
                case "@R": // Hotel View (Left Room)
                    Main.frmScripts.RemoveAllUsers();
                    Main.frmScripts.RemoveAllItems();
                    break;
                case "AX": // Update Item AX479924102
                    int TmpItemUpdateID = int.Parse(NewPacket.Substring(2, NewPacket.IndexOf("") - 2));
                    string Status = NewPacket.Substring(NewPacket.IndexOf("") + 1);
                    Status = Status.Substring(0, Status.IndexOf(""));
                    Main.frmScripts.AddToFurniNode2(Status, TmpItemUpdateID, 9);
                    break;
                case "Cd": // Update Badge Cd[ID][Badge]
                    int TmpRoomID2 = Jeax.Habbo.Encoding.VL64.decode(NewPacket.Substring(2));
                    string Badge = NewPacket.Substring(2 + Jeax.Habbo.Encoding.VL64.encode(TmpRoomID2).Length);
                    Badge = Badge.Substring(0, Badge.Length - 1);
                    Main.frmScripts.AddToNode(Badge, TmpRoomID2, 6);
                    break;
                case "AT": // Poster Picked Up
                    Main.frmScripts.RemovePoster(int.Parse(NewPacket.Substring(2)));
                    break;
                case "A^": // Item Picked Up A^3597097
                    Main.frmScripts.RemoveItem(int.Parse(NewPacket.Substring(2)));
                    break;
                case "A]": // Item Put Down A]3597097sofa_polyfon_girlSARAJIH0.0#ffffff,#ffffff,#ffffff,#ffffff,#EE7EA4,#EE7EA4,#EE7EA4,#EE7EA4H
                case "A_": // Move Furniture A_3597097sofa_polyfon_girlQBJJIPA0.0#ffffff,#ffffff,#ffffff,#ffffff,#EE7EA4,#EE7EA4,#EE7EA4,#EE7EA4H
                    string AllFurniture = NewPacket.Substring(2);
                    int TmpItemID = 0;
                    for (int x = 0; x < 6; x++)
                    {
                        switch (x)
                        {
                            case 0: // ID
                                TmpItemID = int.Parse(AllFurniture.Substring(0, AllFurniture.IndexOf("")));
                                Main.frmScripts.NewFurniture(TmpItemID.ToString(), TmpItemID);
                                break;
                            case 1: // Sprite
                                string TmpItemSprite = AllFurniture.Substring(0, AllFurniture.IndexOf(""));
                                Main.frmScripts.AddToFurniNode(TmpItemSprite, TmpItemID, 1);
                                break;
                            case 2: // Location PAIIIH0.0
                                string TmpLocation = AllFurniture.Substring(0, AllFurniture.IndexOf(""));
                                int TmpFurniX = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpFurniX).Length);
                                int TmpFurniY = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpFurniY).Length);
                                int TmpWidth = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpWidth).Length);
                                int TmpLength = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpLength).Length);
                                int TmpRotation = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpRotation).Length);
                                string TmpElevation = TmpLocation;
                                Main.frmScripts.AddToFurniNode(TmpFurniX.ToString(), TmpItemID, 2);
                                Main.frmScripts.AddToFurniNode(TmpFurniY.ToString(), TmpItemID, 3);
                                Main.frmScripts.AddToFurniNode(TmpWidth.ToString(), TmpItemID, 4);
                                Main.frmScripts.AddToFurniNode(TmpLength.ToString(), TmpItemID, 5);
                                Main.frmScripts.AddToFurniNode(TmpRotation.ToString(), TmpItemID, 6);
                                Main.frmScripts.AddToFurniNode(TmpElevation.ToString(), TmpItemID, 7);
                                break;
                            case 3: // Colour
                                string TmpColour = AllFurniture.Substring(0, AllFurniture.IndexOf(""));
                                Main.frmScripts.AddToFurniNode(TmpColour, TmpItemID, 8);
                                break;
                            case 5: // Variable
                                TmpColour = AllFurniture.Substring(0, AllFurniture.IndexOf(""));
                                Main.frmScripts.AddToFurniNode(TmpColour, TmpItemID, 9);
                                break;
                        }
                        AllFurniture = AllFurniture.Substring(AllFurniture.IndexOf("") + 1);
                    }
                    
                    break;
                case "AS": // Put down Poster
                case "@m": // Posterz
                    string WholePosters;
                    string SinglePosterBit = "";
                    int TmpWallItemID = 0;
                    WholePosters = NewPacket.Substring(2);
                    while (WholePosters != "")
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            if (x == 3)
                            {
                                if (WholePosters.IndexOf("	") != -1)
                                    SinglePosterBit = WholePosters.Substring(0, WholePosters.IndexOf("	"));
                                else
                                {
                                    if (SinglePosterBit.IndexOf("\r") != -1)
                                        SinglePosterBit = WholePosters.Substring(0, WholePosters.IndexOf("\r"));
                                    else
                                        SinglePosterBit = WholePosters;
                                }
                            }
                            else
                            {
                                SinglePosterBit = WholePosters.Substring(0, WholePosters.IndexOf("	"));
                            }
                            if (WholePosters.IndexOf("	") != -1)
                                WholePosters = WholePosters.Substring(WholePosters.IndexOf("	") + 1);
                            else
                                WholePosters = "";
                            switch (x)
                            {
                                case 0: // Poster ID
                                    TmpWallItemID = int.Parse(SinglePosterBit);
                                    break;
                                case 1: // Sprite
                                    Main.frmScripts.NewWallItem(SinglePosterBit, TmpWallItemID);
                                    break;
                                case 3: // Location
                                    string TmpW = SinglePosterBit.Substring(3,SinglePosterBit.IndexOf(" ") - 3) ;
                                    string TmpL = SinglePosterBit.Substring(SinglePosterBit.IndexOf(" ") + 1).Substring(2);
                                    TmpL = TmpL.Substring(0, TmpL.Length - 2);
                                    string TmpR = SinglePosterBit.Substring(SinglePosterBit.Length - 1,1);
                                    Main.frmScripts.AddToWallItemNode(TmpW, TmpWallItemID, 2);
                                    Main.frmScripts.AddToWallItemNode(TmpL, TmpWallItemID, 3);
                                    Main.frmScripts.AddToWallItemNode(TmpR, TmpWallItemID, 4);
                                    break;

                            }
                        }
                        if (WholePosters.IndexOf(Convert.ToChar(13)) != -1)
                        {
                            SinglePosterBit = WholePosters.Substring(0, WholePosters.IndexOf(Convert.ToChar(13))); // Type
                            WholePosters = WholePosters.Substring(WholePosters.IndexOf(Convert.ToChar(13)) + 1);
                        }
                        else
                        {
                            SinglePosterBit = WholePosters; // Type
                            WholePosters = "";
                        }
                        Main.frmScripts.AddToWallItemNode(SinglePosterBit, TmpWallItemID, 5);
                    }
                    break;
                case "@`": // Furniture @`J47992410sound_machine*1PAIIIH0.0#FFFFFF,#FFFFFF,#828282,#FFFFFFI13597097sofa_polyfon_girlQBKJIPA0.0#ffffff,#ffffff,#ffffff,#ffffff,#EE7EA4,#EE7EA4,#EE7EA4,#EE7EA4H
                    int AmFurniture = Jeax.Habbo.Encoding.VL64.decode(NewPacket.Substring(2));
                    AllFurniture = NewPacket.Substring(2 + Jeax.Habbo.Encoding.VL64.encode(AmFurniture).Length);
                    TmpItemID = 0;
                    string TmpItemSprite2 = "";
                    while (AllFurniture != "")
                    {
                        for (int x = 0; x < 6; x++)
                        {
                            switch (x)
                            {
                                case 0: // ID
                                    TmpItemID = int.Parse(AllFurniture.Substring(0, AllFurniture.IndexOf("")));
                                    Main.frmScripts.NewFurniture(TmpItemID.ToString(), TmpItemID);
                                    break;
                                case 1: // Sprite
                                    TmpItemSprite2 = AllFurniture.Substring(0, AllFurniture.IndexOf(""));
                                    Main.frmScripts.AddToFurniNode(TmpItemSprite2, TmpItemID, 1);
                                    break;
                                case 2: // Location PAIIIH0.0
                                    string TmpLocation = AllFurniture.Substring(0, AllFurniture.IndexOf(""));
                                    int TmpFurniX = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                    TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpFurniX).Length);
                                    int TmpFurniY = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                    TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpFurniY).Length);
                                    int TmpWidth = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                    TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpWidth).Length);
                                    int TmpLength = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                    TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpLength).Length);
                                    int TmpRotation = Jeax.Habbo.Encoding.VL64.decode(TmpLocation);
                                    TmpLocation = TmpLocation.Substring(Jeax.Habbo.Encoding.VL64.encode(TmpRotation).Length);
                                    string TmpElevation = TmpLocation;
                                    Main.frmScripts.AddToFurniNode(TmpFurniX.ToString(), TmpItemID, 2);
                                    Main.frmScripts.AddToFurniNode(TmpFurniY.ToString(), TmpItemID, 3);
                                    Main.frmScripts.AddToFurniNode(TmpWidth.ToString(), TmpItemID, 4);
                                    Main.frmScripts.AddToFurniNode(TmpLength.ToString(), TmpItemID, 5);
                                    Main.frmScripts.AddToFurniNode(TmpRotation.ToString(), TmpItemID, 6);
                                    Main.frmScripts.AddToFurniNode(TmpElevation.ToString(), TmpItemID, 7);
                                    break;
                               case 3: // Colour
                                   string TmpColour = AllFurniture.Substring(0, AllFurniture.IndexOf(""));
                                   Main.frmScripts.AddToFurniNode(TmpColour, TmpItemID, 8);
                                    break;
                                case 5: // Variable
                                    TmpColour = AllFurniture.Substring(0, AllFurniture.IndexOf(""));
                                    Main.frmScripts.AddToFurniNode(TmpColour, TmpItemID, 9);
                                    break;
                            }
                            AllFurniture = AllFurniture.Substring(AllFurniture.IndexOf("") + 1);
                        }
                    }
                    break;
                case "DJ": // Poof DJI1500118001230252810129510mlulz
                    int TmpRoomID = Jeax.Habbo.Encoding.VL64.decode(NewPacket.Substring(2));
                    string TmpFigure;
                    string TmpSex;
                    string TmpMotto;
                    TmpSex = NewPacket.Split("".ToCharArray())[1];
                    TmpMotto = NewPacket.Split("".ToCharArray())[2];
                    TmpFigure = NewPacket.Substring(2 + Jeax.Habbo.Encoding.VL64.encode(TmpRoomID).Length).Split("".ToCharArray())[0];
                    Main.frmScripts.AddToNode(TmpFigure, TmpRoomID, 3);
                    Main.frmScripts.AddToNode(TmpMotto, TmpRoomID, 2);
                    Main.frmScripts.AddToNode(TmpSex, TmpRoomID, 4);
                    break;
                case "@b": /* Move @b0 4,10,0.0,2,2/Dance 1
                           1 5,10,0.0,2,2/Wave */
                    NewPacket = NewPacket.Replace("joingame", "wave");
                    if (!Main.frmScripts.chkNoUserUpdate.Checked)
                        break;
                    int TmpID;
                    int TmpX;
                    int TmpY;
                    string AllUsers = NewPacket.Substring(2);
                    while (AllUsers != "" && AllUsers != "\r")
                    {
                        string TmpUserPacket = "";
                        if (AllUsers.IndexOf(Convert.ToChar(13)) != -1)
                            TmpUserPacket = AllUsers.Substring(0, AllUsers.IndexOf(Convert.ToChar(13)));
                        else
                            TmpUserPacket = AllUsers;
                        TmpID = int.Parse(TmpUserPacket.Substring(0, TmpUserPacket.IndexOf(" ")));
                        string Tmp = TmpUserPacket.Substring(0).Substring(TmpUserPacket.IndexOf(" "));
                        TmpX = int.Parse(Tmp.Substring(0, Tmp.IndexOf(",")));
                        Tmp = Tmp.Substring(Tmp.IndexOf(",") + 1);
                        TmpY = int.Parse(Tmp.Substring(0, Tmp.IndexOf(",")));
                        if (MyRoomID == TmpID)
                        {
                            MyX = TmpX;
                            MyY = TmpY;
                        }
                        if (TmpUserPacket.IndexOf("flatctrl") != -1)
                            Main.frmScripts.AddToNode("True", TmpID, 9);
                        if (TmpUserPacket.IndexOf("flatctrl") == -1)
                            Main.frmScripts.AddToNode("False", TmpID, 9);
                        if (AllUsers.IndexOf(Convert.ToChar(13)) != -1)
                            AllUsers = AllUsers.Substring(AllUsers.IndexOf(Convert.ToChar(13)) + 1);
                        else
                            AllUsers = "";
                    }
                    break;
            }
        ReGetID:
            int Fails = 0;
            int RndID = new Random().Next(0, 400);
            if (SandRPacket[RndID] != null)
            {
                Fails++;
                if (Fails > 100)
                    goto ReGetID;
            }
            Main.SandR.ReplaceThis(NewPacket, "Client",RndID);
            NewPacket = SandRPacket[RndID];
            SandRPacket[RndID] = null;
            Main.PacketScreen.AddToClientLog(NewPacket);
            SendToClient(NewPacket);
        }
        #endregion
        #region ServerPackets
        private void RunServerPackets(string ThePacket)
        {
            string AllPacket = ThePacket;
            string TmpPacket = "";
            if (Main.LoginScreen.chkNoEnc.Checked)
            {
                ProccessServerPacket(ThePacket);
                return;
            }
            while (AllPacket != "")
            {
                int PacketLength = Jeax.Habbo.Encoding.B64.decode(AllPacket.Substring(1, 2)) + 3;
                TmpPacket = AllPacket.Substring(0, PacketLength);
                AllPacket = AllPacket.Substring(PacketLength);
                ProccessServerPacket(TmpPacket);
                
            }
        }
        internal void UpdateHabbo(string Motto, string Sex, string Figure)
        {
            string App_Key;
            WebClient wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.Cookie, "JSESSIONID=" + SessionID);
            string Source = wc.DownloadString("http://www.habbo" + Hotel + "/profile/profile?tab=2");

            App_Key = Source.Substring(Source.IndexOf("name=\"__app_key\" value=\"") + "name=\"__app_key\" value=\"".Length);
            App_Key = App_Key.Split("\"".ToCharArray())[0];
            string postData = "tab=2&__app_key=" + App_Key + "&motto=" + Motto + "&visibility=EVERYONE&emailAlertEnabled=false&wordFilterDisabled=true&friendRequestsAllowed=true&save=Save+changes";
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
        internal void MoveDown()
        {
            SendToServerAddHeaders("AK" +Jeax.Habbo.Encoding.B64.encode(Space(MyX + 1)) +Jeax.Habbo.Encoding.B64.encode(Space(MyY)));
        }
        internal void Shout(string TheText)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("@w" + Jeax.Habbo.Encoding.B64.encode(TheText) + TheText);
        }
        internal void MoveUp()
        {
            SendToServerAddHeaders("AK" +Jeax.Habbo.Encoding.B64.encode(Space(MyX - 1)) +Jeax.Habbo.Encoding.B64.encode(Space(MyY)));
        }
        internal void MoveLeft()
        {
            SendToServerAddHeaders("AK" +Jeax.Habbo.Encoding.B64.encode(Space(MyX)) +Jeax.Habbo.Encoding.B64.encode(Space(MyY + 1)));
        }
        internal void MoveRight()
        {
            SendToServerAddHeaders("AK" +Jeax.Habbo.Encoding.B64.encode(Space(MyX)) +Jeax.Habbo.Encoding.B64.encode(Space(MyY - 1)));
        }
        internal void LookDown()
        {
            SendToServerAddHeaders("AO" + ((int)MyX + 1)+ " " + MyY.ToString());
        }
        internal void LookUp()
        {
            SendToServerAddHeaders("AO" + ((int)MyX - 1) + " " + MyY.ToString());
        }
        internal void LookLeft()
        {
            SendToServerAddHeaders("AO" + MyX.ToString() + " " + (MyY + 1));
        }
        internal void LookRight()
        {
            SendToServerAddHeaders("AO" + MyX + " " + (MyY - 1));
        }
        private string Space(int Length)
        {
            string TmpOutput = "";
            for (int x = 0; x < Length; x++)
            {
                TmpOutput += " ";
            }
            return TmpOutput;
        }
        private void ProccessServerPacket(string ThePacket)
        {
            string NewPacket = ThePacket;
            int Fails = 0;
            if (!Main.LoginScreen.chkNoEnc.Checked)
                NewPacket = NewPacket.Substring(3);
        ReGetID:
            int RndID = new Random().Next(0, 400);
            if (SandRPacket[RndID] != null)
            {
                Fails++;
                if (Fails > 100)
                    goto ReGetID;
            }
            Main.SandR.ReplaceThis(NewPacket, "Server", RndID);
            if (SandRPacket[RndID] != null)
                NewPacket = SandRPacket[RndID];
            SandRPacket[RndID] = null;
            try
            {
                //if (NewPacket.Substring(3, 2) == "_R")
                    //NewPacket = "@@]_R@Y431208932uid:36:431208932";
                if (Main.LoginScreen.chkNoEnc.Checked)
                    goto NoEnc;
                switch (NewPacket.Substring(0, 2))
                {
                    case "@B": // Enter Room
                        Main.frmScripts.RemoveAllUsers();
                        Main.frmScripts.RemoveAllItems();
                        
                        // Set Room ID Etc.
                        if (Main.frmBots.chkSetToRoomID.Checked == true)
                        {
                            string Public = ThePacket.Substring(2, 1);
                            if (Public == "A")
                                Main.frmBots.chkPublicRoom.Checked = true;
                            else
                                Main.frmBots.chkPublicRoom.Checked = false;

                            _RoomID = Jeax.Habbo.Encoding.VL64.decode(NewPacket.Substring(3));
                            Main.frmBots.txtRoomID.Value = _RoomID;
                            int RoomPart = Jeax.Habbo.Encoding.VL64.decode(NewPacket.Substring(NewPacket.Length - 1));
                            Main.frmBots.txtRoomPart.Value = RoomPart;
                        }
                        break;
                    // @U18649550
                    case "AR": // Enter Teleporter
                        if (DisableTeleporting == true)
                            goto SkipSending;
                        break;
                    case "CL": // Ticket
                        //NewPacket = "CL" +Jeax.Habbo.Encoding.B64.encode(SSOTicket) + SSOTicket;
                        break;
                    case "@F": // Shockwave ID
                        if (Main.frmScripts.chkRandomShockwaveID.Checked == true)
                        {
                            string FakeID = new Random().Next(900000000,910000000).ToString() + "2007";
                           SendToServerAddHeaders("@F" +Jeax.Habbo.Encoding.B64.encode(FakeID) + FakeID);
                            goto SkipSending;
                        }
                        break;
                }
                NoEnc:
                SendToServerAddHeaders(NewPacket);
                SkipSending:
                Main.PacketScreen.AddToServerLog(NewPacket);
            }
            catch { }
        }
        #endregion
    }
}
