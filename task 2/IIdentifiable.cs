using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal interface IIdentifiable
    {
        int Id { get; set; }
        bool IsViolator();
    }
}
