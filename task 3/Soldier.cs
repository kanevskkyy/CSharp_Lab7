using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Soldier:ISoldier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Soldier(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
}
