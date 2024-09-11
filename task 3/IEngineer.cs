using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal interface IEngineer
    {
        List<string> RepairedThings { get; set; }
        List<int> TimeToRepair { get; set; }

        void NewRepairedThings(string Things, int Time);
    }
}