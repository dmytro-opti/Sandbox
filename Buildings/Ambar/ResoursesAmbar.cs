using Sandbox1.Enums;

namespace Sandbox1.Buildings.Ambar
{
    public class ResoursesAmbar : Ambar
    {
        string ResoursesAmbarLevel { get; set; }

        public Dictionary<TypesOfResourses, int> StoredResourses { get; set; }

        public ResoursesAmbar(string address) : base(address)
        {
            AmbarType = "ResoursesAmbar";
            AmbsrsCount = 1;

            AmbarLevelValue = 1;
            MaximumItemsValue = 100;
            AmbarLevel = $"Level{AmbarLevelValue}";

            StoredResourses = new Dictionary<TypesOfResourses, int>();

            foreach (TypesOfResourses type in Enum.GetValues(typeof(TypesOfResourses)))
            {
                StoredResourses.Add(type, 0);
            }
        }

        public void AddResourses(TypesOfResourses typesOfResourses, int addValue)
        {
            if (StoredResourses.ContainsKey(typesOfResourses))
            {
                int newValue = StoredResourses[typesOfResourses] + addValue;

                if (newValue <= MaximumItemsValue)
                {
                    StoredResourses[typesOfResourses] = newValue;
                }
                else
                {
                    StoredResourses[typesOfResourses] = MaximumItemsValue;
                }
            }
        }

        public void RemoveResourses(TypesOfResourses typesOfResourses, int removeValue)
        {
            if (StoredResourses.ContainsKey(typesOfResourses))
            {
                int newValue = StoredResourses[typesOfResourses] - removeValue;

                if (newValue >= 0)
                {
                    StoredResourses[typesOfResourses] = newValue;
                }
                else
                {
                    Console.WriteLine("Not enough Resourses");
                }
            }
        }

        public void UpgradeResoursesAmbar()
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