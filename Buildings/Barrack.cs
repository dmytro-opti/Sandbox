using Sandbox1.Enums;
using Sandbox1.People;

namespace Sandbox1.Buildings
{
    public class Barrack : GovermentBuilding
    {
        public List<Warrior> Warriors { get; set; } = new List<Warrior>();
        public List<Recruiter> Recruiters { get; set; } = new List<Recruiter>();
        public int MaxWarriorCapacity { get; set; } = 50;

        public Barrack(string address, int buildingPrice) : base(address, buildingPrice) { }

        public void AddWarrior(Warrior warrior)
        {
            if (Warriors.Count < MaxWarriorCapacity)
            {
                Warriors.Add(warrior);
            }
            else
            {
                Console.WriteLine("Казарма заповнена, не можна додати воїна.");
            }
        }

        public void RemoveWarrior(Warrior warrior)
        {
            Warriors.Remove(warrior);
        }

        public void AddRecruiter(Recruiter recruiter)
        {
            Recruiters.Add(recruiter);
        }

        public void HireRecruiter(Recruiter recruiter, Warrior warrior)
        {
            if (recruiter != null && warrior != null)
            {
                int recruitmentCost = recruiter.MonthlySalary * recruiter.SalaryMultiplier;
                Console.WriteLine($"Найм рекрутера {recruiter.Name} для {warrior.Name} коштує: {recruitmentCost}");
                recruiter.Recruit(warrior);
            }
        }

        public void UpdateWarriorRanks()
        {
            foreach (var warrior in Warriors.ToList())
            {
                warrior.Rank = warrior.Level switch
                {
                    >= 30 => WarriorRank.Legend,
                    >= 20 => WarriorRank.Mentor,
                    _ => WarriorRank.Trainee
                };
            }
        }

        public void TrainWarriors()
        {
            var trainees = Warriors.Where(w => w.Rank == WarriorRank.Trainee).ToList();

            if (trainees.Count == 0)
            {
                Console.WriteLine("Немає новобранців для тренування.");
                return;
            }

            foreach (var trainee in trainees)
            {
                trainee.Strength += 5;
                trainee.Agility += 5;

                trainee.UpdateLevelAndStats();
            }
        }

        public void UpgradeMentors()
        {
            var mentors = Warriors.Where(w => w.Rank == WarriorRank.Mentor).ToList();

            if (mentors.Count == 0)
            {
                Console.WriteLine("Немає наставників для покращення.");
                return;
            }

            foreach (var mentor in mentors)
            {
                mentor.Strength += 10;
                mentor.Agility += 10;

                mentor.UpdateLevelAndStats();
            }
        }

        public void CheckHealthAndDeaths()
        {
            Random rand = new Random();

            foreach (var warrior in Warriors.ToList())
            {
                int randomChance = rand.Next(1, 100);
                if (randomChance <= (warrior.Rank == WarriorRank.Legend ? 1 : warrior.Rank == WarriorRank.Mentor ? 3 : 5))
                {
                    warrior.ReduceHealth(rand.Next(10, 30));
                }
            }
        }

        public void ChangeWarriorEquipment(Warrior warrior, string newWeapon, string newArmor)
        {
            if (Warriors.Contains(warrior))
            {
                warrior.ChangeEquipment(newWeapon, newArmor);
            }
        }

        public List<Warrior> GetTrainees()
        {
            return Warriors.Where(w => w.Rank == WarriorRank.Trainee).ToList();
        }

        public List<Warrior> GetMentors()
        {
            return Warriors.Where(w => w.Rank == WarriorRank.Mentor).ToList();
        }

        public List<Warrior> GetLegends()
        {
            return Warriors.Where(w => w.Rank == WarriorRank.Legend).ToList();
        }
    }
}
