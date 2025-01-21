using Sandbox1.Enums;


namespace Sandbox1.Buildings
{
    public class FoodAmbar : Building
    {
        public int LevelFoodAmbar { get; set; }
        public int MaximumFoodValue { get; set; }
        public double Budget { get; set; }
        string AmbarLevel { get; set; }

        public Dictionary<TypesOfFood, int> StoredFood { get; set; }

        public FoodAmbar(string address) : base(address)
        {
            LevelFoodAmbar = 1;
            MaximumFoodValue = 100;
            Budget = 1000;
            AmbarLevel = $"Level{LevelFoodAmbar}";

            StoredFood = new Dictionary<TypesOfFood, int>();

            StoredFood.Add(TypesOfFood.Meat, 0);
            StoredFood.Add(TypesOfFood.Wine, 0);
            StoredFood.Add(TypesOfFood.Bread, 0);


        }

        public void AddFood(TypesOfFood typesOfFood, int addValue)
        {
            if (StoredFood.ContainsKey(typesOfFood))
            {

                int newValue = StoredFood[typesOfFood] + addValue;

                if (newValue <= MaximumFoodValue)
                {
                    StoredFood[typesOfFood] = newValue;
                }
                else
                {
                    StoredFood[typesOfFood] = MaximumFoodValue;
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
            if (LevelFoodAmbar < 5)
            {
                int price = (int)Enum.Parse(typeof(FoodAmbarLevelUpPrice), AmbarLevel);
                int increase = (int)Enum.Parse(typeof(FoodAmbarLevelUpIncrease), AmbarLevel);

                //int price = (int)(FoodAmbarLevelUpPrice)(LevelFoodAmbar);
                //int increase = (int)(FoodAmbarLevelUpIncrease)(LevelFoodAmbar);

                if (Budget >= price)
                {
                    Budget -= price;
                    LevelFoodAmbar++;
                    AmbarLevel = $"Level{LevelFoodAmbar}";
                    MaximumFoodValue += increase;
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