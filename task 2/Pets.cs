using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Pets : IBirthday
    {
        public string Name { get; set; }
        
        public string Day {  get; set; }
        public string Month { get; set; }
        public string Year { get; set; }

        public Pets(string name, string date)
        {
            Name = name;
            string[] time = date.Split('/');

            Day = time[0];
            Month = time[1];
            Year = time[2];
        }
    }
}
