using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniper
{
    class HInventory
    {
        public List<Item> InventoryLoaded(HMessage packet)
        {
            List<Item> objList = new List<Item>();
            try
            {
                packet.ReadInteger();
                packet.ReadInteger();
                int num1 = packet.ReadInteger();
                for (int index1 = 0; index1 < num1; ++index1)
                {
                    Item obj = new Item();
                    obj.ItemId = packet.ReadInteger();
                    obj.Type = packet.ReadString();
                    packet.ReadInteger();
                    obj.SpriteId = packet.ReadInteger();
                    packet.ReadInteger();
                    int num2 = packet.ReadInteger();
                    switch (num2)
                    {
                        case 0:
                            packet.ReadString();
                            break;
                        case 1:
                            int num3 = packet.ReadInteger();
                            for (int index2 = 0; index2 < num3; ++index2)
                            {
                                packet.ReadString();
                                packet.ReadString();
                            }
                            break;
                        case 2:
                            int num4 = packet.ReadInteger();
                            for (int index2 = 0; index2 < num4; ++index2)
                                packet.ReadString();
                            break;
                        case 3:
                            packet.ReadString();
                            packet.ReadInteger();
                            break;
                        case 5:
                            int num5 = packet.ReadInteger();
                            for (int index2 = 0; index2 < num5; ++index2)
                                packet.ReadInteger();
                            break;
                        case 6:
                            packet.ReadString();
                            packet.ReadInteger();
                            packet.ReadInteger();
                            int num6 = packet.ReadInteger();
                            for (int index2 = 0; index2 < num6; ++index2)
                            {
                                packet.ReadInteger();
                                int num7 = packet.ReadInteger();
                                for (int index3 = 0; index3 < num7; ++index3)
                                    packet.ReadString();
                            }
                            break;
                        case 7:
                            packet.ReadString();
                            packet.ReadInteger();
                            packet.ReadInteger();
                            break;
                    }
                    if (num2 != 6 && (num2 & 65280 & 256) > 0)
                    {
                        packet.ReadInteger();
                        packet.ReadInteger();
                    }
                    packet.ReadBoolean();
                    packet.ReadBoolean();
                    packet.ReadBoolean();
                    packet.ReadBoolean();
                    packet.ReadInteger();
                    packet.ReadBoolean();
                    packet.ReadInteger();
                    if (obj.Type == "S")
                    {
                        packet.ReadString();
                        packet.ReadInteger();
                    }
                    objList.Add(obj);
                }
            }
            catch
            {

            }
            return objList;
        }

        public class Item
        {
            public int ItemId { get; set; }

            public string Type { get; set; }

            public int SpriteId { get; set; }
        }
    }
}
