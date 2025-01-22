using System;
using Sandbox1.Buildings;
using Sandbox1.Enums;
using Sandbox1.People;

namespace Sandbox1
{
    public class Program
    {
        static void Main()
        {

            Barrack barrack = new Barrack("Main Barracks", 500);

            Warrior warrior1 = new Warrior("Achilles", 1, 100, 200, 30, 25, 15, WeaponType.Sword, "Bronze Armor");
            Warrior warrior2 = new Warrior("Hercules", 1, 120, 250, 40, 30, 18, WeaponType.Axe, "Golden Armor");

            barrack.AddWarrior(warrior1);
            barrack.AddWarrior(warrior2);

            Recruiter recruiter = new Recruiter("Aristotle", 1, 200, 500, 10);

            barrack.AddRecruiter(recruiter);

            barrack.HireRecruiter(recruiter, warrior1);

            barrack.UpdateWarriorRanks();

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
