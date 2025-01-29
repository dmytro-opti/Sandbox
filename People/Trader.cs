using System.Xml.Linq;

namespace Sandbox1.People
{
    public class Trader : Person
    {
        public Trader(string name, int monthlysalary)
            {
                Name = name;
                MonthlySalary = monthlysalary;
            }
    }

}

