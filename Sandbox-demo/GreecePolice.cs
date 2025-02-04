
using Sandbox1.Buildings;
using Sandbox1.Enums;
using Sandbox1.Items;
using Sandbox1.People;

namespace Sandbox1
{
    public class GreecePolice
    {
        public List<Building> Buildings { get; set; } = new List<Building>();
        public List<Person> People { get; set; } = new List<Person>();
        public List<DailyCityNews> DailyNews { get; set; } = new List<DailyCityNews>();

        public GreecePolice()
        {

        }

        public (bool ReadyForWar, int Warriors, int Sets) IsArmyReadyForWar()
        {
            var budgetNews = Buildings.Where(building => building is GovermentBuilding).Cast<GovermentBuilding>().Sum(x => x.Budget);

            var barracks = Buildings.Where(building => building is Barrack).Cast<Barrack>();

            var allItems = barracks.SelectMany(x => x.Items);

            var allWeapons = allItems.Where(item => item is Weapon).Cast<Weapon>();

            var allArmor = allItems.Where(item => item is Armor).Cast<Armor>();

            var shields = allArmor.Count(x => x.Type == ArmorType.Sheild);

            var helmets = allArmor.Count(x => x.Type == ArmorType.Helmet);

            var legs = allArmor.Count(x => x.Type == ArmorType.Legs);

            var body = allArmor.Count(x => x.Type == ArmorType.Body);

            var hands = allArmor.Count(x => x.Type == ArmorType.Hands);

            allArmor.Select(x => x.Type);

            var minSet = SelectMin(shields, helmets, legs, body, hands);
            
            var warriorsInBarracks = barracks.SelectMany(x => x.Warriors);

            var warriorsInPolice = People.Where(person => person is Warrior).Cast<Warrior>();

            var army = warriorsInBarracks.Union(warriorsInPolice);

            return (army.Count() < SelectMin(minSet, allWeapons.Count()), army.Count(), minSet);

            var ambars = Buildings.Where(building => building is Ambar1).Cast<Ambar1>();

            Dictionary<ItemType, int> resources = new Dictionary<ItemType, int>();

            foreach (var ambar in ambars) 
            {
                foreach (var item in ambar.StoredItems)
                {
                    if (resources.ContainsKey(item.Key))
                    {
                        resources[item.Key] += item.Value;
                    }
                    else
                    {
                        resources.Add(item.Key, item.Value);
                    }
                }
            }
        }

        public int SelectMin(params int[] values) 
        {
            return values.Min();
        }
    }
}
