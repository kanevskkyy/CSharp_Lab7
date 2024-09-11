using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class LeuntenantGeneral:Soldier, ILeutenantGeneral
    {
        public List<Private> Soldiers { get; set; } = new List<Private>();
        public int Salary { get; set; }

        public LeuntenantGeneral(int id, string name, string surname, int salary) : base(id, name, surname)
        {
            Salary = salary;
        }

        public void AddSoldier(Private soldier)
        {
            this.Soldiers.Add(soldier);
        }

        public override string ToString()
        {
            string sentense = $"Name : {this.Name} {this.Surname} Id : {this.Id} Salary : {this.Salary:F2}\nPrivates :\n";

            for(int i = 0; i < Soldiers.Count; i++)
            {
                sentense += $"\t {Soldiers[i]}\n";
            }

            return sentense;
        }
    }
}