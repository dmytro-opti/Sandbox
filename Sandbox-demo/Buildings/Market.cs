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
            MarketBudget = 1000;
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


        public void ShowVendors()
        {

            foreach (Vendor vendor in vendors)
            {
                Console.WriteLine($"{vendor.Name}:");

                foreach (var good in vendor.Goods)
                {
                    Console.WriteLine($"{good.Key} - {good.Value}");
                }
            }
        }



        public void CheckVendors()
        {
            var vendorCount = vendors.Count();

            var message = vendorCount > 2 ? "Все топчик!" : "Продавців менше двох.";
            Console.WriteLine(message);
        }

        public void BoughtFromVendor(string Name, Dictionary<ItemType, int> good)
        { 
            if (vendors.Any(vendor => vendor.Name == Name))
            {
                var vendor = vendors.First(vendor => vendor.Name == Name);
                foreach (var item in good)
                {
                    if (vendor.Goods.ContainsKey(item.Key))
                    {
                        if (vendor.Goods[item.Key] >= item.Value)
                        {
                            vendor.Goods[item.Key] -= item.Value;
                            vendor.Budget += item.Value * 1;
                            MarketBudget += item.Value * 0.2;
                        }
                        else
                        {
                            Console.WriteLine("Недостатньо товару.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Товар відсутній.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Продавця не знайдено.");
            }
        }

    }
}
