using System;
using Sandbox1.Enums;

namespace Sandbox1.People
{
    public class Warrior : Person
    {
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Level { get; set; }
        public WeaponType Weapon { get; set; }
        public string Armor { get; set; }
        public int Health { get; set; }
        public WarriorRank Rank { get; set; }
        public WarriorRank CurrentRank => DetermineRank();

        public Warrior(string name, int priority, int monthlySalary, int budget, int strength, int agility, int level, WeaponType weapon, string armor, int health = 100)
            : base()
        {
            Id = Guid.NewGuid();
            Name = name;
            Priority = priority;
            MonthlySalary = monthlySalary;
            Budget = budget;
            Strength = strength;
            Level = level;
            Weapon = weapon;
            Armor = armor;
            Health = health;
            Agility = agility;
        }

        public void UpdateLevelAndStats()
        {
            int calculatedLevel = (Strength + Agility) / 50; 
            if (calculatedLevel > Level)
            {
                Level = calculatedLevel;
                Console.WriteLine($"{Name} досягнув нового рівня! Новий рівень: {Level}");
            }

            Strength += Level * 2; 
            Agility += Level * 2;  
            Console.WriteLine($"{Name} отримав бонусні стати: +{Level * 2} Strength і +{Level * 2} Agility!");
        }

        public void ChangeEquipment(string newWeapon, string newArmor)
        {
            if (Enum.TryParse(newWeapon, true, out WeaponType parsedWeapon))
            {
                Weapon = parsedWeapon;
                Armor = newArmor;
                Console.WriteLine($"{Name} змінив спорядження. Нова зброя: {Weapon}, нова броня: {Armor}");
            }
            else
            {
                Console.WriteLine($"Невідома зброя: {newWeapon}. Зміна не відбулася.");
            }
        }


        public void ReduceHealth(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} помер у битві!");
                Health = 0;
            }
            else
            {
                Console.WriteLine($"{Name} отримав {damage} ушкоджень. Залишилось {Health} здоров'я.");
            }
        }

        public void DealDamage(Warrior target)
        {
            int calculatedDamage = (Strength + Agility + Level) / 3;

            calculatedDamage += Weapon switch
            {
                WeaponType.Sword => 10,
                WeaponType.Spear => 12,
                WeaponType.Bow => 8,
                WeaponType.Axe => 15,
                _ => 5
            };

            Console.WriteLine($"{Name} завдав {calculatedDamage} ушкоджень {target.Name}.");
            target.ReduceHealth(calculatedDamage);
        }

        private WarriorRank DetermineRank()
        {
            return Level switch
            {
                <= 20 => WarriorRank.Trainee,
                > 20 and <= 30 => WarriorRank.Mentor,
                _ => WarriorRank.Legend
            };
        }
    }
}
