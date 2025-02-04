using Sandbox1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox1.People
{
    public class Vendor : Person
    {
        //public string Name { get; set; }
        public Dictionary<ItemType, int> Goods { get; set; }

        public Vendor(string name, Dictionary<ItemType, int> goods)
        {
            Name = name;
            Goods = goods;
            Budget = 0;
        }
    }
}
