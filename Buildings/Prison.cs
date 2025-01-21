using Sandbox1.Enums;
using Sandbox1.People;
using System;
using System.Numerics;

namespace Sandbox1.Buildings
{
    public class Prison : GovermentBuilding
    {
        public List<Prisoner> Prisoners { get; set; } = new List<Prisoner>();
        public List<Guard> Guards { get; set; }= new List<Guard>();
        public PrisonType Type { get; set; }
        public Person Director { get; set; }
        public bool Safety { get; set; }
        


        public Prison(string address, int buildingPrice, List<Guard> guards, Person director, PrisonType type) : base(address, buildingPrice)
        {
            Guards = guards;
            Director = director;
            Prisoners = new List<Prisoner>();
            Type = type;         
        }

        public void AddPrisoner(Prisoner prisoner)
        {
            Prisoners.Add(prisoner);
        }

        public void DistributePrisoners(List<Prisoner> prisoners, List<Prison> prisons)
        {
            foreach (var prisoner in prisoners)
            {
                    if (prisoner.Danger == 1 && prisoner.Age < 18)
                    {
                        prisons.FirstOrDefault(p => p.Type == PrisonType.Juvenal)?.AddPrisoner(prisoner);
                        Console.WriteLine($"{prisoner.Name} was sent to Juvenal Prison");
                    }
                    else if (prisoner.Danger == 2 && prisoner.Age >= 18)
                    {
                        prisons.FirstOrDefault(p => p.Type == PrisonType.RehabilitationCenter)?.AddPrisoner(prisoner);
                        Console.WriteLine($"{prisoner.Name} was sent to Rehabilitation Center");
                    }
                    else if (prisoner.Danger >= 3 && prisoner.Age >= 18)
                    {
                        prisons.FirstOrDefault(p => p.Type == PrisonType.Dangerous)?.AddPrisoner(prisoner);
                        Console.WriteLine($"{prisoner.Name} was sent to High Security Prison");
                    }
                    else
                    {
                        Console.WriteLine($"No suitable prison found for {prisoner.Name}.");
                    }
                }
            }

        public void ListPrisoners()
        {
            Console.WriteLine("List of Prisoners:");
            foreach (var prisoner in Prisoners)
            {
                Console.WriteLine($"Name: {prisoner.Name}, Age: {prisoner.Age}, Crime: {prisoner.Crime}, Release Date: {prisoner.ReleaseDate:yyyy-MM-dd}, Danger: {prisoner.Danger}");
            }
        }
 
        public bool ReleasePrisoner(Prisoner prisoner, Person person)
        {
            switch (person.Role)
            {
                case Role.Director:
                    if (Prisoners.Contains(prisoner))
                    {
                        if (prisoner.ReleaseDate <= DateTime.Now)
                        {
                            Prisoners.Remove(prisoner);
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("The prisoner cannot be released before their release date.");
                            return false;
                        }
                    }
                    break;

                case Role.Guard:
                case Role.Prisoner:
                default:
                    Console.WriteLine("Unauthorized person cannot release prisoners.");
                    break;
            }
            return false;
        }

        public void AddGuard(Guard guard)
        {
            Guards.Add(guard);
        }

        public bool RemoveGuard(Guard guard)
        { 
            if (Guards.Contains(guard))
            {
                Guards.Remove(guard);
                return true;
            }
            return false;
        }

      
        public bool IsSafe()
        {
                           
         return Budget >= Guards.Sum(x=> x.MonthlySalary)+ Director.MonthlySalary && Guards.Count / Prisoners.Count >= (int)Type;
                
        }
 
        public void CheckSafetyAndEscape()
        {
            if (!IsSafe())
            {
                Console.WriteLine("Prison is not safe! Prisoners are escaping...");

                // Відсоток втечі
                double escapeRate = 0.2;

                // Кількість в'язнів, які втекли
                int escapingPrisoners = (int)(Prisoners.Count * escapeRate);

                // Видаляємо втеклих в'язнів із списку
                Prisoners = Prisoners.Take(Prisoners.Count - escapingPrisoners).ToList();

                var needToHire = (int)Type * Prisoners.Count - Guards.Count;

                for (int i = 0; i < needToHire; i++) 
                { 
                    AddGuard(new Guard($"Vasylyan {i}", 100, 1000));
                }

                Console.WriteLine($"{escapingPrisoners} prisoners have escaped! Remaining prisoners: {Prisoners.Count}");
            }
            else
            {
                Console.WriteLine("Prison is safe. No one is escaping.");
            }
        }
    }
}