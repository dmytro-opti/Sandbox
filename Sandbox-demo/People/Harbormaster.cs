using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Sandbox1.Enums;
using Sandbox1.Buildings;

namespace Sandbox1.People
{
    public class Harbormaster: Person
    {
        public Harbormaster(string name, int monthlysalary)
        {
            Name = name;
            MonthlySalary = monthlysalary;
        }

    }
     
   
}
