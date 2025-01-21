using Sandbox1.Enums;

namespace Sandbox1.Buildings.Ambar
{
    public class Ambar : Building
    {
        public AmbarLevelUpPrice CurrentUpdatePrice { get; set; }
        public AmbarType AmbarType { get; set; }

        public List<ItemType> AllowedItemTypes { get; set; } = new List<ItemType>();

        public Dictionary<ItemType, int> StoredItems { get; set; } = new Dictionary<ItemType, int>();
        public Dictionary<ItemType, AmbarLevelUpCapacity> CapacityPerItem { get; set; } = new Dictionary<ItemType, AmbarLevelUpCapacity>();

        public Ambar(string address, AmbarType ambarType) : base(address)
        {
            AmbarType = ambarType;
            CurrentUpdatePrice = AmbarLevelUpPrice.Level1;
        }

        public Ambar(string address, AmbarType ambarType, List<ItemType> allowedItemTypes) : base(address)
        {
            AmbarType = ambarType;
            CurrentUpdatePrice = AmbarLevelUpPrice.Level1;
            AllowedItemTypes = allowedItemTypes;
        }

        public void AddItem(ItemType itemType, int itemCount)
        {
            if (AllowedItemTypes.Contains(itemType)) 
            {
                if (!StoredItems.ContainsKey(itemType))
                {
                    StoredItems.Add(itemType, 0);
                }

                if (!CapacityPerItem.ContainsKey(itemType))
                {
                    Enum.TryParse(CurrentUpdatePrice.ToString(), out AmbarLevelUpCapacity levelCapacity);
                    CapacityPerItem.Add(itemType, levelCapacity);
                }

                if ((int)CapacityPerItem[itemType] >= StoredItems[itemType] + itemCount)
                {
                    StoredItems[itemType] += itemCount;
                }
                else
                {
                    Console.WriteLine($"You cannot put {itemType} with count {itemCount}. Please, upgrade your ambar.");
                }
            }
            else
            {
                Console.WriteLine($"We cannot add {itemType} to ambar.");
            }
        }

        public void RemoveItem(ItemType itemType, int itemCount)
        {
            if (StoredItems.ContainsKey(itemType))
            {
                StoredItems[itemType] = StoredItems[itemType] - itemCount > 0 
                    ? StoredItems[itemType] - itemCount 
                    : 0;    
            }
            else
            {
                Console.WriteLine($"Cannot find in ambar {itemType}.");
            }
        }

        public void UpgradeLevel(AmbarLevelUpPrice ambarLevelPrice)
        {
            int.TryParse(CurrentUpdatePrice.ToString().Replace("Level", ""), out int currentLevel);
            int.TryParse(ambarLevelPrice.ToString().Replace("Level", ""), out int newLevel);
            if (currentLevel == newLevel - 1) 
            {
                CurrentUpdatePrice = ambarLevelPrice;
                foreach (var key in CapacityPerItem.Keys) 
                {
                    Enum.TryParse(CurrentUpdatePrice.ToString(), out AmbarLevelUpCapacity levelCapacity);
                    CapacityPerItem[key] = levelCapacity;
                }
            }
            else
            {
                Console.WriteLine($"You cannot upgrade ambar more than on one level per time");
            }
        }
    }
}