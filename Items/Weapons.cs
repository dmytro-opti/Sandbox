
namespace Sandbox1.Items
{
    public class Weapons : Item
    {
        public double Damage {  get; set; }

        public Weapons(string name, string type, string description, double weight, double damage)
        {
            Types.Add(type);
            Name = name;
            Description = description;
            Value = weight;
            Damage = damage;
        }

    }
}