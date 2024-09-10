using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Citizen:IIdentifiable, IBirthday
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }

        public Citizen(string name, int age, string id)
        {
            Id = id;
            Age = age;
            Name = name;
        }

        public Citizen(string name, int age, string id, string date)
        {
            Name = name;
            Age = age;
            Id = id;

            string[] time = date.Split('/');
            
            Day = time[0];
            Month = time[1];
            Year = time[2];
        }

        public bool IsViolator(string fakeNumber)
        {
            return Id.EndsWith(fakeNumber);
        }

    }
}
