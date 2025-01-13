namespace Sandbox1.Items
{
    public class Resourses : Item
    {
        public Resourses(string name, string type, string description, double weight)
        {
            Types.Add(type);
            Name = name;
            Description = description;
            Value = weight;
        }

    }
}
