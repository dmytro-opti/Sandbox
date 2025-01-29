using Sandbox1.Enums;

namespace Sandbox1.Items
{
    public class Weapon : Item
    {
        public WeaponType Type { get; set; }

        public Weapon(string name, string description, WeaponType type, int value)
        {
            Name = name;
            Description = description;
            Type = type;
            Value = value;
        }
    }
}
