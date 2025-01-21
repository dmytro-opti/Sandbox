using Sandbox1.Buildings;
using Sandbox1.People;
using Sandbox1.Enums;


namespace Sandbox1
{
    public class Program
    {
        static void Main()
        {

            //Danil

            FoodAmbar FoodAmbar = new FoodAmbar("Athene");    

            FoodAmbar.AddFood(TypesOfFood.Bread, 5);
            FoodAmbar.AddFood(TypesOfFood.Meat, 7);
            FoodAmbar.AddFood(TypesOfFood.Wine, 15);
            FoodAmbar.AddFood(TypesOfFood.Bread, 2);

            FoodAmbar.RemoveFood(TypesOfFood.Bread, 3);
            FoodAmbar.RemoveFood(TypesOfFood.Meat, 2);
            FoodAmbar.RemoveFood(TypesOfFood.Wine, 5);
            FoodAmbar.RemoveFood(TypesOfFood.Bread, 20);

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




        }
    }
}
