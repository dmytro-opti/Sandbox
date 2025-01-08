using Sandbox1.People;

namespace Sandbox1.Buildings
{
    public class GovermentBuilding : Building
    {
        public int MonthlyPrice { get; set; }
        public int BuildingPrice { get; set; }
        public int Tax { get; set; }
        public int Budget { get; set; }
        public GovermentBuilding(string address, int buildingPrice) : base(address)
        {

        }

        public void PayMonthlySalary(List<Person> people)
        {
            foreach (Person person in people.OrderBy(x => x.Priority)) 
            {
                if (person != null && Budget >= person.MonthlySalary) 
                {
                    Budget -= person.MonthlySalary;
                    person.Budget += person.MonthlySalary; 
                }
            }
        }
    }
}
