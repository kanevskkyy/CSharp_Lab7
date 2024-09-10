using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Rebel:IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }
        public int Food { get; set; }

        public Rebel(string name, int age, string team)
        {
            Name = name;
            Age = age;
            Team = team;
            Food = 0;
        }

        public void BuyFood()
        {
            this.Food += 5; 
        }
    }
}
