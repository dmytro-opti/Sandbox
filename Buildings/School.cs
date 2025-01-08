
using Sandbox1.People;

namespace Sandbox1.Buildings
{
    public class School : GovermentBuilding
    {
        public List<Philosopher> Philosophers { get; set; } = new List<Philosopher>();
        public List<Person> People { get; set; } = new List<Person>();
        public string Status { get; set; }
        public List<string> Subjects { get; set; } = new List<string>();

        public School(string address, int buildingPrice, List<Philosopher> philosophers) : base(address, buildingPrice)
        {
            Philosophers = philosophers;
            Subjects = philosophers.SelectMany(x => x.Subjects).Distinct().ToList();
            People = new List<Person>();
        }
        
        public School(string address, int buildingPrice, List<Philosopher> philosophers, List<Person> people) : base(address, buildingPrice)
        {
            Philosophers = philosophers;
            People = people;
        }

        public void Learning()
        {

        }

        public bool IsSchoolActive()
        {
            foreach (var subject in Subjects)
            {
                var philosoph = Philosophers.FirstOrDefault(x => x.Subjects.Contains(subject));
                if (philosoph == null)
                {
                    return false;
                } 
            }
            return true;
        }

        public void Graduating(List<Person> people)
        {
            foreach (Person person in people) 
            {
                People.Remove(person);
            }
        }

        public void Grant(Person person, int price)
        {
            if (person != null && Budget >= price && price > 0) 
            {
                Budget -= price;
                person.Budget += price;
            }
        }

        public void HirePhilosopher(Philosopher philosopher)
        {
            Philosophers.Add(philosopher);
        }

        public void FireOutPhilosopher(Philosopher philosopher)
        {
            Philosophers.Remove(philosopher);
        }
    }
}
