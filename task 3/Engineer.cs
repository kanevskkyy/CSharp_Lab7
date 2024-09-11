using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Engineer: SpecialisedSoldier, IEngineer
    {
        public List<string> RepairedThings { get; set; } = new List<string>();
        public List<int> TimeToRepair { get; set; } = new List<int>();

        public Engineer(int id, string name, string surname, string corpus) : base(id, name, surname, corpus) {}

        public void NewRepairedThings(string Things, int Time)
        {
            this.RepairedThings.Add(Things);
            this.TimeToRepair.Add(Time);
        }
    }
}
