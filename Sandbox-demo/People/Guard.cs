using System.Xml.Linq;
using Sandbox1.Enums;
using Sandbox1.Buildings;


namespace Sandbox1.People
{
    public class Guard : Warrior
    {
        public int Age { get; set; }
        public Guard(string name, int age, int monthlysalary) : base(name, 1, monthlysalary, 100, 50, 100, 30, WeaponType.Sword, "")
        {
            Name = name;
            Age = age;
            Role = Role.Guard;
            MonthlySalary = monthlysalary;
        }
    }
}
