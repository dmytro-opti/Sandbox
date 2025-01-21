using Sandbox1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Sandbox1.Buildings;

  

namespace Sandbox1.People
{
    public class Director: Person
    {
        public int Age { get; set; }

        public Director(string name, int age,int monthlysalary)
        {
            Name = name;
            Age = age;
            Role = Role.Director;
            MonthlySalary = monthlysalary;
        }
    }
}
