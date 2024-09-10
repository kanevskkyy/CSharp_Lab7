using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Robot:IIdentifiable
    {
        public string Id { get; set; }
        public string Model { get; set; }

        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }

        public bool IsViolator(string fakeNumber)
        {
            return Id.EndsWith(fakeNumber);
        }
    }
}
