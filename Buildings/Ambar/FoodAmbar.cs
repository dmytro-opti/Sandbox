using Sandbox1.Enums;

namespace Sandbox1.Buildings.Ambar
{
    /*public class FoodAmbar : Ambar
    {
        string FoodAmbarLevel { get; set; }

        public Dictionary<TypesOfFood, int> StoredFood { get; set; }

        public FoodAmbar(string address) : base(address)
        {
            AmbarType = "FoodAmbar";
            AmbsrsCount = 1;

            AmbarLevelValue = 1;
            MaximumItemsValue = 100;
            AmbarLevel = $"Level{AmbarLevelValue}";

            StoredFood = new Dictionary<TypesOfFood, int>();

            foreach (TypesOfFood type in Enum.GetValues(typeof(TypesOfFood)))
            {
                StoredFood.Add(type, 0);
            }
        }

        public void AddFood(TypesOfFood typesOfFood, int addValue)
        {
            if (StoredFood.ContainsKey(typesOfFood))
            {
                int newValue = StoredFood[typesOfFood] + addValue;

                if (newValue <= MaximumItemsValue)
                {
                    StoredFood[typesOfFood] = newValue;
                }
                else
                {
                    StoredFood[typesOfFood] = MaximumItemsValue;
                }
            }
        }

        public void RemoveFood(TypesOfFood typesOfFood, int removeValue)
        {
            if (StoredFood.ContainsKey(typesOfFood))
            {
                int newValue = StoredFood[typesOfFood] - removeValue;

                if (newValue >= 0)
                {
                    StoredFood[typesOfFood] = newValue;
                }
                else
                {
                    Console.WriteLine("Not enough food");
                }
            }
        }

        public void UpgradeFoodAmbar()
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
    }*/
}