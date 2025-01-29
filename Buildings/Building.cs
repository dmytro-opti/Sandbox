using Sandbox1.Enums;

namespace Sandbox1.Buildings
{
    public class Building
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BuildingType Type { get; set; }
        public Building(string address)
        {
            
            Address = address;
        }
    }
}
