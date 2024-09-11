using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Commando:SpecialisedSoldier,ICommando
    {
        public List<string> MissionName { get; set; } = new List<string>();
        public List<string> MissionStatus { get; set; } = new List<string>();

        public Commando(int id, string name, string surname, string corpus) : base(id, name, surname, corpus) { }
    }
}