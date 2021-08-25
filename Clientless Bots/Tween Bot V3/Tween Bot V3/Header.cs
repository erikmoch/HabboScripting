using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tween_Bot_V3
{
    class Header
    {
        private static FileIniDataParser parser = new FileIniDataParser();

        private static IniData data = parser.ReadFile("Headers.ini");

        public ushort ClientVariables0;
        public ushort FriendRequest;
        public ushort GenerateSecretKeyOut;
        public ushort InitCrypto;
        public ushort LeaveRoom;
        public ushort MachineID;
        public ushort Pong;
        public ushort RequestGuildJoin;
        public ushort RequestRoomLoad;
        public ushort RequestUserData;
        public ushort RoomUserAction;
        public ushort RoomUserDance;
        public ushort RoomUserGiveRespect;
        public ushort RoomUserLookAtPoint;
        public ushort RoomUserShout;
        public ushort RoomUserSign;
        public ushort RoomUserSit;
        public ushort RoomUserWalk;
        public ushort RoomUserWhisper;
        public ushort RoomVote;
        public ushort SaveMotto;
        public ushort ScratchPet;
        public ushort SSOTicket;
        public ushort UserSaveLook;

        public ushort GenerateSecretKeyIn;
        public ushort Ping;
        public ushort SecureLoginOK;
        public ushort VerifyPrimes;

        public string ClientVariables1;
        public string ClientVariables2;
        public string ReleaseVersion;

        public Header()
        {
            ClientVariables0 = ushort.Parse(data["Out"]["ClientVariables"]);
            FriendRequest = ushort.Parse(data["Out"]["FriendRequest"]);
            GenerateSecretKeyOut = ushort.Parse(data["Out"]["GenerateSecretKey"]);
            InitCrypto = ushort.Parse(data["Out"]["InitCrypto"]);
            LeaveRoom = ushort.Parse(data["Out"]["LeaveRoom"]);
            MachineID = ushort.Parse(data["Out"]["MachineID"]);
            Pong = ushort.Parse(data["Out"]["Pong"]);
            RequestGuildJoin = ushort.Parse(data["Out"]["RequestGuildJoin"]);
            RequestRoomLoad = ushort.Parse(data["Out"]["RequestRoomLoad"]);
            RequestUserData = ushort.Parse(data["Out"]["RequestUserData"]);
            RoomUserAction = ushort.Parse(data["Out"]["RoomUserAction"]);
            RoomUserDance = ushort.Parse(data["Out"]["RoomUserDance"]);
            RoomUserGiveRespect = ushort.Parse(data["Out"]["RoomUserGiveRespect"]);
            RoomUserLookAtPoint = ushort.Parse(data["Out"]["RoomUserLookAtPoint"]);
            RoomUserShout = ushort.Parse(data["Out"]["RoomUserShout"]);
            RoomUserSign = ushort.Parse(data["Out"]["RoomUserSign"]);
            RoomUserSit = ushort.Parse(data["Out"]["RoomUserSit"]);
            RoomUserWalk = ushort.Parse(data["Out"]["RoomUserWalk"]);
            RoomUserWhisper = ushort.Parse(data["Out"]["RoomUserWhisper"]);
            RoomVote = ushort.Parse(data["Out"]["RoomVote"]);
            SaveMotto = ushort.Parse(data["Out"]["SaveMotto"]);
            ScratchPet = ushort.Parse(data["Out"]["ScratchPet"]);
            SSOTicket = ushort.Parse(data["Out"]["SSOTicket"]);
            UserSaveLook = ushort.Parse(data["Out"]["UserSaveLook"]);

            GenerateSecretKeyIn = ushort.Parse(data["In"]["GenerateSecretKey"]);
            Ping = ushort.Parse(data["In"]["Ping"]);
            SecureLoginOK = ushort.Parse(data["In"]["SecureLoginOK"]);
            VerifyPrimes = ushort.Parse(data["In"]["VerifyPrimes"]);

            ClientVariables1 = data["Str"]["ClientVariables1"];
            ClientVariables2 = data["Str"]["ClientVariables2"];
            ReleaseVersion = data["Str"]["ReleaseVersion"];
        }
    }
}
