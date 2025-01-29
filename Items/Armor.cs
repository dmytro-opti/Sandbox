using Sandbox1.Enums;

namespace Sandbox1.Items
{
    public class Armor : Item
    {
        public ArmorType Type { get; set; }

        public Armor(string name, string description, ArmorType type, int value)
        {
            Name = name;
            Description = description;
            Type = type;
            Value = value;
        }
    }
}
