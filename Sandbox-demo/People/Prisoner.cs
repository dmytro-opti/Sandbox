using Sandbox1.Enums;
using Sandbox1.Buildings;
using System;

namespace Sandbox1.People
{
        public class Prisoner : Person
    {
        public DateTime ReleaseDate { get; set; }
        public int Age { get; set; }    
        public string Crime { get; set; }
        public int Danger {  get; set; }

        public Prisoner(string name, DateTime releaseDate, int age, string crime, int danger)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Age = age;
            Crime = crime;
            Role = Role.Prisoner;
            Danger = danger;
        }
    }
}
