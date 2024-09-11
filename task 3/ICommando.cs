using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal interface ICommando
    {
        List<string> MissionName { get; set; }
        List<string> MissionStatus { get; set; }
    }
}
