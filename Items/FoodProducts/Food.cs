namespace Sandbox1.Buildings.Ambar.Items.FoodProducts
{
    public class Food
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }

        public Food(string name, string description, string type, int value)
        {
            Name = name;
            Description = description;
            Type = type;
            Value = value;
        }
    }
}
