using Sandbox1.Buildings;
using Sandbox1.Enums;
using Sandbox1.People;

namespace Sandbox1
{
    public class Program
    {
        static void Main()
        {
            School school = new School("Athene", 1000, new List<Philosopher>());

            Console.WriteLine(school.People.Count);

            school = new School("Megara", 800, new List<Philosopher>(), new List<Person>());




            Prisoner prisoner1 = new Prisoner("John Doe", new DateTime(2027, 10, 28), 16, "Theft", 1);
            Prisoner prisoner2 = new Prisoner("Jane Doe", new DateTime(2029, 5, 12), 25, "Fraud", 2);
            Prisoner prisoner3 = new Prisoner("Mike Smith", new DateTime(2045, 12, 1), 30, "Murder", 3);

            Guard guard1 = new Guard("Officer Smith", 40, 2000);
            Guard guard2 = new Guard("Officer Johnson", 35, 1800);
            Guard guard3 = new Guard("Officer Brown", 45, 2200);

            Director director1 = new Director("Director White", 50, 5000);
            Director director2 = new Director("Director Green", 45, 4800);
            Director director3 = new Director("Director Black", 55, 5200);

            // Створюємо в'язниці з різними типами
            Prison juvenilePrison = new Prison("Juvenile Prison St.", 2000000, new List<Guard> { guard1, guard2 }, director1, PrisonType.Juvenal);
            Prison rehabilitationPrison = new Prison("Rehabilitation Center St.", 3000000, new List<Guard> { guard2, guard3 }, director2, PrisonType.RehabilitationCenter);
            Prison dangerousPrison = new Prison("Dangerous Prison St.", 5000000, new List<Guard> { guard1, guard3 }, director3, PrisonType.Dangerous);

            // Додаємо в'язнів до відповідних в'язниць
            juvenilePrison.AddPrisoner(prisoner1);
            rehabilitationPrison.AddPrisoner(prisoner2);
            dangerousPrison.AddPrisoner(prisoner3);

            // Вивести інформацію про директорів та список в'язнів для кожної в'язниці
            Console.WriteLine("Juvenile Prison Director: " + juvenilePrison.Director.Name);
            juvenilePrison.ListPrisoners();

            Console.WriteLine("\nRehabilitation Center Director: " + rehabilitationPrison.Director.Name);
            rehabilitationPrison.ListPrisoners();

            Console.WriteLine("\nDangerous Prison Director: " + dangerousPrison.Director.Name);
            dangerousPrison.ListPrisoners();
        }
    }
}
