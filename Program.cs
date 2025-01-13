using Sandbox1.Buildings;
using Sandbox1.Items;
using Sandbox1.People;

namespace Sandbox1
{
    public class Program
    {
        static void Main()
        {
            //Danil:

           

            Food food = new Food("a", "b", "c", 0);
            Item item = new Item();


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
