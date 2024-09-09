using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Phone: IPhoneIntertnet, IPhoneCall
    {

        public void ConnectToInternet(string URL)
        {
            bool isNumber = false;
            for (int i = 0; i < URL.Length; i++) 
            {
                if (char.IsDigit(URL[i])) isNumber = true;
            }
            if (isNumber) Console.WriteLine("Invalid URL!");
            else Console.WriteLine($"Browsing: {URL}!");

        }

        public void MakeCall(string number)
        {
            bool notNumber = false;
            for(int i = 0; i < number.Length; i++)
            {
                if(!char.IsDigit(number[i])) notNumber = true;
            }

            if (!notNumber) Console.WriteLine($"Calling ... {number}");
            else Console.WriteLine("Invalid number!");
        }
    }
}
