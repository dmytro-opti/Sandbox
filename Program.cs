using Sandbox1.Buildings;
using Sandbox1.People;
using Sandbox1.Enums;
using Sandbox1.Buildings.Ambar;


namespace Sandbox1
{
    public class Program
    {
        static void Main()
        {

            //Danil

            var ambar = new Ambar("Sparta, 1", AmbarType.Weapon, new List<ItemType>() 
            {
                ItemType.Bow, ItemType.Sword, ItemType.Spear
            });

            ambar.AddItem(ItemType.Bow, 10);
            ambar.AddItem(ItemType.Bow, 10);
            ambar.AddItem(ItemType.Bow, 10);
            ambar.AddItem(ItemType.Bow, 10);
            ambar.AddItem(ItemType.Bow, 10);
            ambar.AddItem(ItemType.Iron, 100);
            ambar.RemoveItem(ItemType.Bow, 49);
            ambar.RemoveItem(ItemType.Bow, 10);
            ambar.UpgradeLevel(AmbarLevelUpPrice.Level3);
            ambar.UpgradeLevel(AmbarLevelUpPrice.Level2);
            ambar.UpgradeLevel(AmbarLevelUpPrice.Level3);
            ambar.UpgradeLevel(AmbarLevelUpPrice.Level4);
            ambar.AddItem(ItemType.Sword, 100);
            ambar.UpgradeLevel(AmbarLevelUpPrice.Level5);
            ambar.UpgradeLevel(AmbarLevelUpPrice.Level5);

            var ambars = new List<Ambar>();

            for (int index = 0; index < 100; index++)
            {
                //var ambar = new Ambar($"Sparta, {index + 1}", AmbarType.Weapon);
            }


            /*FoodAmbar FoodAmbar = new FoodAmbar("Athene");

            FoodAmbar.AddFood(TypesOfFood.Bread, 5);
            FoodAmbar.AddFood(TypesOfFood.Meat, 7);
            FoodAmbar.AddFood(TypesOfFood.Wine, 15);
            FoodAmbar.AddFood(TypesOfFood.Bread, 2);

            FoodAmbar.RemoveFood(TypesOfFood.Bread, 3);
            FoodAmbar.RemoveFood(TypesOfFood.Meat, 2);
            FoodAmbar.RemoveFood(TypesOfFood.Wine, 5);
            FoodAmbar.RemoveFood(TypesOfFood.Bread, 20);

            FoodAmbar.UpgradeFoodAmbar();
            FoodAmbar.UpgradeFoodAmbar();
            FoodAmbar.UpgradeFoodAmbar();
            FoodAmbar.UpgradeFoodAmbar();


            ResoursesAmbar ResoursesAmbar = new ResoursesAmbar("Athene");

            ResoursesAmbar.AddResourses(TypesOfResourses.Wood, 5);
            ResoursesAmbar.AddResourses(TypesOfResourses.Stone, 7);
            ResoursesAmbar.AddResourses(TypesOfResourses.Iron, 15);

            ResoursesAmbar.RemoveResourses(TypesOfResourses.Wood, 3);
            ResoursesAmbar.RemoveResourses(TypesOfResourses.Stone, 2);
            ResoursesAmbar.RemoveResourses(TypesOfResourses.Iron, 5);
            ResoursesAmbar.RemoveResourses(TypesOfResourses.Wood, 20);

            ResoursesAmbar.UpgradeResoursesAmbar();
            ResoursesAmbar.UpgradeResoursesAmbar();
            ResoursesAmbar.UpgradeResoursesAmbar();
            ResoursesAmbar.UpgradeResoursesAmbar();
            ResoursesAmbar.UpgradeResoursesAmbar();
            ResoursesAmbar.UpgradeResoursesAmbar();

            WeaponsAmbar WeaponsAmbar = new WeaponsAmbar("Athene");

            WeaponsAmbar.AddWeapons(TypesOfWeapons.Sword, 5);

            WeaponsAmbar.UpgradeWeaponsAmbar();
            WeaponsAmbar.UpgradeWeaponsAmbar();
            
            //==================================================================================================

            School school = new School("Athene", 1000, new List<Philosopher>());


            school.HirePhilosopher(new Philosopher()

            {
                Subjects = new List<string>() { "Math", "Logic" },
                Budget = 0,
                MonthlySalary = 10,
                Name = "Piphagor",
                Priority = 0,
                Id = Guid.NewGuid()
            });

            school.Subjects = new List<string>() { "Music", "Logic" };

            Console.WriteLine(school.IsSchoolActive());

            school.HirePhilosopher(new Philosopher()
            {
                Subjects = new List<string>() { "Music" },
                Budget = 10,
                MonthlySalary = 5,
                Name = "Sofi",
                Priority = 0,
                Id = Guid.NewGuid()
            });

            Console.WriteLine(school.IsSchoolActive());


            if (school.IsSchoolActive())

            {
                school.Learning();
                school.Graduating(school.People);
                school.PayMonthlySalary(school.Philosophers);
            }


            school = new School("Megara", 800, new List<Philosopher>(), new List<Person>());



*/
        }
    }
}
