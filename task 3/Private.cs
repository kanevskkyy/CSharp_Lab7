using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Private:Soldier, IPrivate
    {
        public int Salary { get; set; }

        public Private(int id, string name, string surname, int salary) : base(id, name, surname)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name : {this.Name} {this.Surname} Id : {this.Id} Salary : {this.Salary:F2}";
        }
    }
}
