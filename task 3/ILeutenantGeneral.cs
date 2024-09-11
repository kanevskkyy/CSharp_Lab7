using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal interface ILeutenantGeneral
    {
        List<Private> Soldiers { get; set; }
        int Salary { get; set; }

        void AddSoldier(Private soldier);
    }
}
