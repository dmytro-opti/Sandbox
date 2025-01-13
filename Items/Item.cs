using System;
namespace Sandbox1.Items
{
	public class Item
	{
		public string Name { get; set; }
		public List<string> Types { get; set; }
		public double  Value { get; set; }
		public string Description { get; set; }

		public Item()
		{
			Types = new List<string>();
		}
	}
}