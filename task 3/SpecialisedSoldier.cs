using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class SpecialisedSoldier:Soldier, ISpecialisedSoldier
    {
        public int Salary { get; set; }
        public string Corpus {  get; set; }

        public SpecialisedSoldier(int id, string name, string surname, string corpus) : base(id, name, surname)
        {
            Corpus = corpus;
        }
    }
}
