using Sandbox1.FoodProducts;
using System.Security.Cryptography.X509Certificates;


namespace Sandbox1.Buildings
{
    public class FoodAmbar : Building
    {
        public int LevelFoodAmbar { get; set; }
        public int MaximumFoodValue { get; set; }

        public List<Food> StoredFood { get; set; }

        public FoodAmbar(string address) : base(address)
        {
            LevelFoodAmbar = 1;
            MaximumFoodValue = 100;
            StoredFood = new List<Food>();

            Meat meat = new Meat();
            StoredFood.Add(meat);

            Wine wine = new Wine();
            StoredFood.Add(wine);

            Bread bread = new Bread();
            StoredFood.Add(bread);


        }

        public void AddFood(Food food, Meat meat, Wine wine, Bread bread, int addValue)
        {
            if (food.Name == "Meat")
            {
                if (meat.Value + addValue < MaximumFoodValue)
                {
                    meat.Value += addValue;
                }
                else
                {
                    meat.Value = MaximumFoodValue;
                }

                if (food.Name == "Wine")
                {
                    if (wine.Value + addValue < MaximumFoodValue)
                    {
                        wine.Value += addValue;
                    }
                    else
                    {
                        wine.Value = MaximumFoodValue;
                    }
                }

                if (food.Name == "Bread")
                {
                    if (bread.Value + addValue < MaximumFoodValue)
                    {
                        bread.Value += addValue;
                    }
                    else
                    {
                        bread.Value = MaximumFoodValue;
                    }
                }


            }
        }
    }
}

