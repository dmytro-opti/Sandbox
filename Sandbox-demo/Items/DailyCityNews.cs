using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox1.Items
{
    public class DailyCityNews
    {
        public DateTime Date {  get; set; }
        public string Title { get; set; }
        public Dictionary<string, string> Orders { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> News { get; set; } = new Dictionary<string, string>();

    }
}
