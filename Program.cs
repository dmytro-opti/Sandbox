using Sandbox1.Buildings;
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

        }
    }
}
