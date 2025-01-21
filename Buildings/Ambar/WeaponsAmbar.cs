using Sandbox1.Enums;

namespace Sandbox1.Buildings.Ambar
{
    public class WeaponsAmbar : Ambar
    {
        string WeaponsAmbarLevel { get; set; }

        public Dictionary<TypesOfWeapons, int> StoredWeapons { get; set; }

        public WeaponsAmbar(string address) : base(address)
        {
            AmbarType = "WeaponsAmbar";
            AmbsrsCount = 1;

            AmbarLevelValue = 1;
            MaximumItemsValue = 100;
            AmbarLevel = $"Level{AmbarLevelValue}";

            StoredWeapons = new Dictionary<TypesOfWeapons, int>();

            foreach (TypesOfWeapons type in Enum.GetValues(typeof(TypesOfWeapons)))
            {
                StoredWeapons.Add(type, 0);
            }
        }

        public void AddWeapons(TypesOfWeapons typesOfWeapons, int addValue)
        {
            if (StoredWeapons.ContainsKey(typesOfWeapons))
            {
                int newValue = StoredWeapons[typesOfWeapons] + addValue;

                if (newValue <= MaximumItemsValue)
                {
                    StoredWeapons[typesOfWeapons] = newValue;
                }
                else
                {
                    StoredWeapons[typesOfWeapons] = MaximumItemsValue;
                }
            }
        }

        public void RemoveWeapons(TypesOfWeapons typesOfWeapons, int removeValue)
        {
            if (StoredWeapons.ContainsKey(typesOfWeapons))
            {
                int newValue = StoredWeapons[typesOfWeapons] - removeValue;

                if (newValue >= 0)
                {
                    StoredWeapons[typesOfWeapons] = newValue;
                }
                else
                {
                    Console.WriteLine("Not enough Weapons");
                }
            }
        }

        public void UpgradeWeaponsAmbar()
        {
            if (AmbarLevelValue < 5)
            {
                State state = new State();

                int price = (int)Enum.Parse(typeof(AmbarLevelUpPrice), AmbarLevel);
                int increase = (int)Enum.Parse(typeof(AmbarLevelUpIncrease), AmbarLevel);

                if (state.Money >= price)
                {
                    state.Money -= price;
                    AmbarLevelValue++;
                    MaximumItemsValue += increase;
                    AmbarLevel = $"Level{AmbarLevelValue}";
                }
                else
                {
                    Console.WriteLine("Not enough money");
                }
            }
            else
            {
                Console.WriteLine("Max level");
            }
        }
    }
}