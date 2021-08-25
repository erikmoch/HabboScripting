using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KClient
{
    public static class Headers
    {
        public static MainFrm Main;

        public static ushort RoomUserDance { get; set; }
        public static ushort RoomUserShout { get; set; }
        public static ushort RoomUserWalk { get; set; }
        public static ushort RoomUserSit { get; set; }
        public static ushort RoomUserGiveRespect { get; set; }
        public static ushort RequestRoomLoad { get; set; }
        public static ushort UserSaveLook { get; set; }
        public static ushort ScratchPet { get; set; }

        public static ushort SSOTicket { get; set; }
        public static ushort MachineID { get; set; }
        public static ushort Ping { get; set; }
        public static ushort Pong { get; set; }
        public static ushort OutGenerateSecretKey { get; set; }
        public static ushort InGenerateSecretKey { get; set; }
        public static ushort InitCrypto { get; set; }
        public static ushort ReleaseVersion { get; set; }
        public static ushort VerifyPrimes { get; set; }
        public static ushort ClientVariables { get; set; }
        public static ushort RequestUserData { get; set; }

        public static Variables Variables { get; set; }

        public static async void Load()
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\HeadersUpdater\\headers.ini"))
                await GetCleanFile();

            var ini = new IniFile(Environment.CurrentDirectory + "\\HeadersUpdater\\headers.ini");

            RoomUserDance = ushort.Parse(ini.IniReadValue("Outgoing", "RoomUserDance"));
            RoomUserShout = ushort.Parse(ini.IniReadValue("Outgoing", "RoomUserShout"));
            RoomUserWalk = ushort.Parse(ini.IniReadValue("Outgoing", "RoomUserWalk"));
            RoomUserSit = ushort.Parse(ini.IniReadValue("Outgoing", "RoomUserSit"));
            RoomUserGiveRespect = ushort.Parse(ini.IniReadValue("Outgoing", "RoomUserGiveRespect"));
            RequestRoomLoad = ushort.Parse(ini.IniReadValue("Outgoing", "RequestRoomLoad"));
            UserSaveLook = ushort.Parse(ini.IniReadValue("Outgoing", "UserSaveLook"));
            ScratchPet = ushort.Parse(ini.IniReadValue("Outgoing", "ScratchPet"));

            SSOTicket = ushort.Parse(ini.IniReadValue("Outgoing", "SSOTicket"));
            MachineID = ushort.Parse(ini.IniReadValue("Outgoing", "MachineID"));
            Pong = ushort.Parse(ini.IniReadValue("Outgoing", "Pong"));
            OutGenerateSecretKey = ushort.Parse(ini.IniReadValue("Outgoing", "GenerateSecretKey"));
            InitCrypto = ushort.Parse(ini.IniReadValue("Outgoing", "InitCrypto"));
            ReleaseVersion = ushort.Parse(ini.IniReadValue("Outgoing", "ReleaseVersion"));
            ClientVariables = ushort.Parse(ini.IniReadValue("Outgoing", "ClientVariables"));
            RequestUserData = ushort.Parse(ini.IniReadValue("Outgoing", "RequestUserData"));

            InGenerateSecretKey = ushort.Parse(ini.IniReadValue("Incoming", "GenerateSecretKey"));
            Ping = ushort.Parse(ini.IniReadValue("Incoming", "Ping"));
            VerifyPrimes = ushort.Parse(ini.IniReadValue("Incoming", "VerifyPrimes"));

            Variables = new Variables
            {
                Production = ini.IniReadValue("Variables", "Production"),
                ClientVariables_1 = ini.IniReadValue("Variables", "ClientVariables_1"),
                ClientVariables_2 = ini.IniReadValue("Variables", "ClientVariables_2")
            };
        }

        private static Task GetCleanFile()
        {
           using (var fs = File.Create(Environment.CurrentDirectory + "\\HeadersUpdater\\headers.ini")) { }
           var ini = new IniFile(Environment.CurrentDirectory + "\\HeadersUpdater\\headers.ini");

           ini.IniWriteValue("Outgoing", "RoomUserDance", "0");
           ini.IniWriteValue("Outgoing", "RoomUserShout", "0");

            ini.IniWriteValue("Outgoing", "RoomUserWalk", "0");
            ini.IniWriteValue("Outgoing", "RoomUserSit", "0");
            ini.IniWriteValue("Outgoing", "RoomUserGiveRespect", "0");
            ini.IniWriteValue("Outgoing", "RequestRoomLoad", "0");
            ini.IniWriteValue("Outgoing", "UserSaveLook", "0");
            ini.IniWriteValue("Outgoing", "ScratchPet", "0");

            ini.IniWriteValue("Outgoing", "SSOTicket", "0");
            ini.IniWriteValue("Outgoing", "MachineID", "0");
            ini.IniWriteValue("Outgoing", "GenerateSecretKey", "0");
            ini.IniWriteValue("Outgoing", "ReleaseVersion", "0");
            ini.IniWriteValue("Outgoing", "InitCrypto", "0");
            ini.IniWriteValue("Outgoing", "ClientVariables", "0");
            ini.IniWriteValue("Outgoing", "RequestUserData", "0");
            ini.IniWriteValue("Outgoing", "Pong", "0");

            ini.IniWriteValue("Incoming", "Ping", "0");
            ini.IniWriteValue("Incoming", "VerifyPrimes", "0");
            ini.IniWriteValue("Incoming", "GenerateSecretKey", "0");

            ini.IniWriteValue("Variables", "Production", "string");
            ini.IniWriteValue("Variables", "ClientVariables_1", "string");
            ini.IniWriteValue("Variables", "ClientVariables_2", "string");

            return Task.CompletedTask;
        }
    }

    public class Variables
    {
        public string Production { get; set; }
        public string ClientVariables_1 { get; set; }
        public string ClientVariables_2 { get; set; }
    }
}
