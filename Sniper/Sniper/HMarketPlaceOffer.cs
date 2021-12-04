using Sulakore.Protocol;
using System.Collections.Generic;

namespace Sulakore.Habbo
{
    public class HMarketplaceOffer : HData
    {
        public int SaleId { get; set; }
        public int State { get; set; }
        public int ItemType { get; set; }
        public int TypeId { get; set; }
        public int SalePrice { get; set; }
        public int Status { get; private set; }
        public int AveragePrice { get; set; }
        public int TotalOffers { get; set; }
        public object[] StuffData { get; set; }
        public int LtdNum { get; set; }
        public int LtdTotal { get; set; }

        public static HMarketplaceOffer[] Parse(HMessage packet)
        {
            var results = new List<HMarketplaceOffer>();

            var count = packet.ReadInteger();
            for (int i = 0; i < count; i++)
            {
                var result = new HMarketplaceOffer();
                result.SaleId = packet.ReadInteger();
                result.State = packet.ReadInteger();
                var saleType = packet.ReadInteger();
                // ItemType of 0 is floor
                // item type of 1 is wall
                if (saleType == 3)
                {
                    result.ItemType = 0;
                    result.TypeId = packet.ReadInteger();
                    result.LtdNum = packet.ReadInteger();
                    result.LtdTotal = packet.ReadInteger();
                    result.SalePrice = packet.ReadInteger();
                    result.Status = packet.ReadInteger();
                }
                else if (saleType == 2)
                {
                    result.ItemType = 1;
                    result.TypeId = packet.ReadInteger();
                    result.StuffData = new[] { packet.ReadString() };
                    result.SalePrice = packet.ReadInteger();
                    result.Status = packet.ReadInteger();
                }
                else
                {
                    result.ItemType = 0;
                    result.TypeId = packet.ReadInteger();
                    result.StuffData = result.ReadData(packet, packet.ReadInteger());
                    result.SalePrice = packet.ReadInteger();
                    result.Status = packet.ReadInteger();
                }
                result.AveragePrice = packet.ReadInteger();
                result.TotalOffers = packet.ReadInteger();
                results.Add(result);
            }

            return results.ToArray();
        }
    }
}