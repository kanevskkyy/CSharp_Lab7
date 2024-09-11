using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Spy:Soldier, ISpy
    {
        public int CodeNumber { get; set; }

        public Spy(int id, string name, string surname, int codeNumber) : base(id, name, surname)
        {
            CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return $"Name : {this.Name} {this.Surname} Id : {this.Id}\nCode number : {this.CodeNumber}";
        }
    }
}
