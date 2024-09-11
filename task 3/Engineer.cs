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

        public Engineer(int id, string name, string surname, int salary, string corpus) : base(id, name, surname, corpus) 
        {
            Salary = salary;
            Corpus = corpus;
        }

        public void NewRepairedThings(string Things, int Time)
        {
            this.RepairedThings.Add(Things);
            this.TimeToRepair.Add(Time);
        }

        public override string ToString()
        {
            string sentence = $"Name : {this.Name} {this.Surname} Id : {this.Id} Salary: {Salary:F2}\nCorps : {Corpus}\nRepairs : \n";

            for(int i = 0; i < RepairedThings.Count; i++)
            {
                sentence += $"\tPart Name : {RepairedThings[i]}; Worked : {TimeToRepair[i]}\n";
            }

            return sentence;
        }

    }
}
