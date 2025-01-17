using Sandbox1.Enums;
using Sandbox1.People;
using System;

namespace Sandbox1.Buildings
{
    internal class Prison : GovermentBuilding
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
            Type = type;         
        }

        public void AddPrisoner(Prisoner prisoner)
        {
            Prisoners.Add(prisoner);
        }
        public bool ReleasePrisoner(Prisoner prisoner, Person person)
        {
            switch (person.Role)
            {
                case Role.Director:
                    if (Prisoners.Contains(prisoner))
                    {
                        Prisoners.Remove(prisoner);
                        return true;
                    }
                    break;

                case Role.Guard: 
                    Console.WriteLine("Only the director can release prisoners.");
                    break;

                case Role.Prisoner:
                    Console.WriteLine("Only the director can release prisoners.");
                    break;

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
        { if (Guards.Contains(guard))
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
    }
}
