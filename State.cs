
using Sandbox1.Buildings;
using Sandbox1.People;

namespace Sandbox1
{
    public class State
    {
        public string Title { get; set; }
        public List<string> Laws { get; set; }
        public double Money { get; set; }
        public Population Population { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();
        public List<NeighbourState> NeighbourStates { get; set; } = new List<NeighbourState>();
        public State()
        {
            
        }

        public void Build(GovermentBuilding govermentBuilding)
        {
            Buildings.Add(govermentBuilding);
        }

        public void Build(string address, int buildingPrice)
        {
            var building = new GovermentBuilding(address, buildingPrice);
            Buildings.Add(building);
        }
    }
}
