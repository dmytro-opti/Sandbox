using System.Xml.Linq;
using Sandbox1.Enums;
using Sandbox1.Buildings;


namespace Sandbox1.People
{
    public class Guard : Person
    {
        public int Age { get; set; }
        public Guard(string name, int age, int monthlysalary)
        {
            Name = name;
            Age = age;
            Role = Role.Guard;
            MonthlySalary = monthlysalary;
        }
    }
}
