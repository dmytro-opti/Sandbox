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

        public void Train()
        {
            Strength += 5;
            Agility += 5;
        }

        public void UpgradeLevel()
        {
            Level += 1;
            Strength += 10;
            Agility += 10;
        }

        public void ChangeEquipment(string newWeapon, string newArmor)
        {
            try
            {
                Weapon = (WeaponType)Enum.Parse(typeof(WeaponType), newWeapon, true);
                Armor = newArmor;
                Console.WriteLine($"{Name} змінив спорядження. Нова зброя: {Weapon}, нова броня: {Armor}");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Невідома зброя: {newWeapon}. Зміна не відбулася.");
            }
        }

        public int CalculateDamage()
        {
            return Weapon switch
            {
                WeaponType.Sword => 15 + (Agility + Level + Strength) / 3,
                WeaponType.Spear => 20 + (Agility + Level) / 2,
                WeaponType.Bow => 10 + Agility / 2,
                WeaponType.Axe => 25 + Strength + Level,
                _ => 5
            };
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
