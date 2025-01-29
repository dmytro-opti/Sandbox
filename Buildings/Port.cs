using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Sandbox1.Enums;
using Sandbox1.People;

namespace Sandbox1.Buildings
{
    public class Port : GovermentBuilding
    {
        public string Name { get; set; }
        public List<Trader> Traders { get; set; }
        public List<Pirate> Pirates { get; set; }
        public Harbormaster Harbormaster { get; set; }
        public List<Sailor> Sailors { get; set; }
        public List<Ship> WarShips { get; set; }
        public List<Dock> Docks { get; set; }

        public Port(string address, int buildingPrice, int dockCount) : base(address, buildingPrice)
        {
            Traders = new List<Trader>();
            Pirates = new List<Pirate>();
            Sailors = new List<Sailor>();
            WarShips = new List<Ship>();
            Docks = new List<Dock>();

            for (int i = 1; i <= dockCount; i++)
                Docks.Add(new Dock(i));
        }

        // Гаваньмейстер (керівник порту)
        public void AssignHarbormaster(Harbormaster harbormaster)
        {
            Harbormaster = harbormaster;
            Console.WriteLine($"{harbormaster.Name} was assigned as the port manager.");
        }

        public void ManagePort()
        {
            Console.WriteLine($"{Harbormaster.Name} manages the port.");
        }

        // Купці
        public void AddTrader(Trader trader)
        {
            Traders.Add(trader);
            Console.WriteLine($"{trader.Name} has arrived at the port to trade.");
        }

        public void Trade(Trader trader)
        {
            Console.WriteLine($"{trader.Name} trades in goods in the port.");
        }

        // Моряки
        public void AddSailor(Sailor sailor)
        {
            Sailors.Add(sailor);
            Console.WriteLine($"{sailor.Name} joined sailing.");
        }

        public void Sail(Sailor sailor)
        {
            Console.WriteLine($"{sailor.Name} sets sail.");
        }

        // Пірати
        public void AddPirate(Pirate pirate)
        {
            Pirates.Add(pirate);
            Console.WriteLine($"⚠️ Pirate {pirate.Name} spotted close to the port!");
        }
        
        public void AttackPort(Port targetPort)
        {
            Console.WriteLine($"⚔️ Pirates attack the port {targetPort.Name}!");
            targetPort.DefendAgainstPirates();
        }

        
        public void DefendAgainstPirates()
        {
            if (WarShips.Count > 0)
                Console.WriteLine($"🛡️ The {Name} Navy has defeated the pirate attack!");
            else
                Console.WriteLine($"❌ Port {Name} failed to protect itself from pirates!");
        }
    }

    public class Ship
    {
        public string Name { get; set; }
        public string Type { get; set; } // "Trade", "War"
        public Ship(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }

    public class Dock
    {
        public int DockNumber { get; set; }
        public Ship? OccupiedBy { get; set; }
        public Dock(int number) => DockNumber = number;
    }
}
