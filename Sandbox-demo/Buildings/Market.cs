using Sandbox1.Buildings.Ambar.Items.FoodProducts;
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
            if (marketType == MarketType.Food)
            {
                AllowedStuff = new List<ItemType> { ItemType.Bread, ItemType.Meat, ItemType.Wine };
            }
            else if (marketType == MarketType.Resources)
            {
                AllowedStuff = new List<ItemType> { ItemType.Wood, ItemType.Stone, ItemType.Iron };
            }
            else if (marketType == MarketType.Weapon)
            {
                AllowedStuff = new List<ItemType> { ItemType.Sword, ItemType.Shield, ItemType.Bow };
            }
        }

        public void NewVendor(string name, Dictionary<ItemType, int> Goods)
        {
            bool isAllowed = Goods.Keys.All(good => AllowedStuff.Contains(good));

            if (isAllowed)
            {
                Vendor vendor = new Vendor(name, Goods); 
                vendors.Add(vendor);
                CurrentMarketPlaseCapacity--;
            }
            else
            {
                Console.WriteLine("Ваші товари заборонені на ринку.");
            }
        }


        //public void ShowVendors(List<Vendor> vendors)
        //{
        //    foreach (Vendor vendor in vendors)
        //    {
        //        Console.WriteLine($"Vendor: {vendor.Name}");
        //        foreach (string good in vendor.Goods)
        //        {
        //            Console.WriteLine($"Good: {good}");
        //        }
        //    }
        //}

        public void CheckVendors()
        {
            var vendorCount = vendors.Count();

            var message = vendorCount > 2 ? "Все топчик!" : "Продавців менше двох.";
            Console.WriteLine(message);
        }

    }
}
