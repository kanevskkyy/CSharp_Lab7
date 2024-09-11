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
        public Commando(int id, string name, string surname, int salary, string corpus) : base(id, name, surname, corpus) 
        {
            Salary = salary;
        }

        public void addMission(string missionName, string missionStatus)
        {
            if (missionStatus.ToLower() == "finished" || missionStatus.ToLower() == "inprogress")
            {
                MissionName.Add(missionName);
                MissionStatus.Add(missionStatus);
            }
            else Console.WriteLine("Invalid missionStatus !!!");
        }

        public override string ToString()
        {
            string sentence = $"Name : {this.Name} {this.Surname} Id : {this.Id} Salary: {Salary:F2}\nCorps : {Corpus}\nMissions : \n";
            
            for(int i = 0; i < MissionName.Count; i++)
            {
                sentence += $"\tCodeName : {MissionName[i]}, status : {MissionStatus[i]}\n";
            }

            return sentence;
        }
    }
}