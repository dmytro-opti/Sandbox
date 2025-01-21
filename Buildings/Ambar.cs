namespace Sandbox1.Buildings
{
    public class Ambar : Building
    {
        public int AmbarLevelValue { get; set; }
        public int MaximumItemsValue { get; set; }
        public string AmbarLevel { get; set; }
        public string AmbarType { get; set; }  
        public int AmbsrsCount { get; set; }

        public Ambar(string address) : base(address)
        {

        }
    }
}