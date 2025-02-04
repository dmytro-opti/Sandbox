using Sandbox1.People;

namespace Sandbox1.Buildings
{
    public class Palace : GovermentBuilding
    {
        public King King { get; set; }
        public List<Guard> Guards { get; set; } = new List<Guard>();
        public Dictionary<string, string> Orders { get; set; } = new Dictionary<string, string>();

        public Palace(string address, int buildingPrice) : base(address, buildingPrice)
        {

        }


    }
}
