using System;
using System.ComponentModel.DataAnnotations;

namespace Sandbox1.Items
{
    public class Food : Item
    {
        public Food(string name, string type, string description, double weight)
        {
            Types.Add(type);
            Name = name;
            Description = description;
            Value = weight;
        }

    }     
}

