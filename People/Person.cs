using Sandbox1.Enums;

namespace Sandbox1.People
{
    public class Person
    {
        public Guid Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public int MonthlySalary { get; set; }
        public int Budget { get; set; }
        public Role Role { get; internal set; }
        public string Address { get; set; }  

        public Person()
        {

        }
    }
}
