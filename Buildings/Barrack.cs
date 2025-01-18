using Sandbox1.Enums;
using System.Collections.Generic;
using System.Linq;
using Sandbox1.People;

namespace Sandbox1.Buildings
{
    public class Barrack : GovermentBuilding
    {
        public List<Warrior> Warriors { get; set; } = new List<Warrior>();

        public int MaxWarriorCapacity { get; set; } = 50;

        public Barrack(string address, int buildingPrice) : base(address, buildingPrice) { }

        public void AddWarrior(Warrior warrior)
        {
            if (Warriors.Count < MaxWarriorCapacity)
            {
                Warriors.Add(warrior);
            }
        }

        public void RemoveWarrior(Warrior warrior)
        {
            Warriors.Remove(warrior);
        }

        public void UpdateWarriorRanks()
        {
            foreach (var warrior in Warriors.ToList())
            {
                if (warrior.Level >= 30)
                {
                    warrior.Rank = WarriorRank.Legend; 
                }
                else if (warrior.Level >= 20)
                {
                    warrior.Rank = WarriorRank.Mentor; 
                }
                else
                {
                    warrior.Rank = WarriorRank.Trainee; 
                }
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
                trainee.Train();
            }
        }

        public void UpgradeMentors()
        {
            var mentors = Warriors.Where(w => w.Rank == WarriorRank.Mentor).ToList();

            foreach (var mentor in mentors)
            {
                mentor.UpgradeLevel();
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
