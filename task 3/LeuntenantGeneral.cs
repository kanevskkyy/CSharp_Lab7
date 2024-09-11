using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class LeuntenantGeneral:Soldier, ILeutenantGeneral
    {
        public List<int> Leutenats = new List<int>();
        public int Salary { get; set; }

        public LeuntenantGeneral(int id, string name, string surname, int salary) : base(id, name, surname)
        {
            Salary = salary;
        }
    }
}
