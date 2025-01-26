namespace Sandbox1.Buildings.Ambar.Items.Weapons
{
    public class Weapons
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }

        public Weapons(string name, string description, string type, int value)
        {
            Name = name;
            Description = description;
            Type = type;
            Value = value;
        }
    }
}
