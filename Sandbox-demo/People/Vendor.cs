using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox1.People
{
    public class Vendor
    {
        public string Name { get; set; }
        public List<string> Goods { get; set; }

        public Vendor(string name, List<string> goods)
        {
            Name = name;
            Goods = goods;
        }
    }
}
