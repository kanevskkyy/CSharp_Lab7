using System;
using task_1;

class Task
{
    static void Main()
    {
        Console.Write("Enter phone`s numbers : ");
        string[] phonesNumber = Console.ReadLine().Split();

        Console.Write("Enter URL adress : ");
        string[] urlAdress = Console.ReadLine().Split();

        Line();
        Phone phone = new Phone();
        for(int i = 0; i < phonesNumber.Length; i++) 
        {
            phone.MakeCall(phonesNumber[i]);
        }

        Line();
        for (int i = 0; i < urlAdress.Length; i++)
        {
            phone.ConnectToInternet(urlAdress[i]);
        }

        

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}