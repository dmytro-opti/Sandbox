using Sandbox1.Enums;
using Sandbox1.People;
using System.Security.Cryptography.X509Certificates;
namespace Sandbox1.Buildings
{
    public class Market : GovermentBuilding
    {
        public MarketLevelUpPrice CurrentMarketLevelUpPrice { get; set; }
        public MarketLevelUpCapacity CurrentMarketPlaseCapacity { get; set; }
        public MarketType MarketType { get; set; }

        public List<ItemType> AllowedStuff { get; set; }

        //public int MarketPrice { get; set; }
        public double MarketTax { get; set; }
        public double MarketBudget { get; set; }
        public List<Vendor> vendors { get; set; } = new List<Vendor>();



        public Market(string address, int buildingPrice, MarketType marketType) : base(address, buildingPrice)
        {
            MarketType = marketType;
            CurrentMarketLevelUpPrice = MarketLevelUpPrice.Level1;
            CurrentMarketPlaseCapacity = MarketLevelUpCapacity.Level1;
        }

        public Market(string address, int buildingPrice, MarketType marketType, List<ItemType> allowedStuff) : base(address, buildingPrice)
        {
            MarketType = marketType;
            CurrentMarketLevelUpPrice = MarketLevelUpPrice.Level1;
            CurrentMarketPlaseCapacity = MarketLevelUpCapacity.Level1;
            AllowedStuff = allowedStuff;
        }

        public void NewVendor(string name, List<string> goods)
        {
            Vendor vendor = new Vendor(name, goods);
            vendors.Add(vendor);
        }

        public void ShowVendors(List<Vendor> vendors)
        {
            foreach (Vendor vendor in vendors)
            {
                Console.WriteLine($"Vendor: {vendor.Name}");
                foreach (string good in vendor.Goods)
                {
                    Console.WriteLine($"Good: {good}");
                }
            }
        }

        public void CheckVendors()
        {
            var vendorCount = vendors.Count();

            var message = vendorCount > 2 ? "Все топчик!" : "Продавців менше двох.";
            Console.WriteLine(message);
        }

    }
}
