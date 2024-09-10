using System;
using task_2;

class Task
{
    static void Main()
    {
        Console.Write("Enter number what part of task you want to do(1 - uprising, 2 - birth, 3 - hunger) = ");
        int choice = int.Parse(Console.ReadLine());
        Console.Clear();
        List<Citizen> citizens = new List<Citizen>();
        List<Robot> robots = new List<Robot>();
        List<Pets> pets = new List<Pets>();


        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter information about citizen {name} {age} {id} or about robot {model} {id}");
                Line();


                while(true)
                {
                    Console.Write("Enter information = ");
                    string[] enteredInformation = Console.ReadLine().Split();
                    if (enteredInformation.Length == 1 && enteredInformation[0].ToLower() == "end") break;

                    else
                    {
                        if (enteredInformation.Length == 3)
                        {
                            Citizen tempCitizen = new Citizen(enteredInformation[0], int.Parse(enteredInformation[1]), enteredInformation[2]);
                            citizens.Add(tempCitizen);
                        }
                        else if (enteredInformation.Length == 2)
                        {
                            Robot tempRobot = new Robot(enteredInformation[0], enteredInformation[1]);
                            robots.Add(tempRobot);
                        }
                    }

                }

                Console.Write("Enter which end of codes belongs to offenders = ");
                string fakeNumber = Console.ReadLine();

                Console.WriteLine("Offenders : \n\tCitizens : ");
                for(int i = 0; i < citizens.Count; i++)
                {
                    if (citizens[i].IsViolator(fakeNumber)) Console.WriteLine("\t  " + citizens[i].Id);
                }
                Console.WriteLine("\tRobots : ");
                for (int i = 0; i < robots.Count; i++)
                {
                    if (robots[i].IsViolator(fakeNumber)) Console.WriteLine("\t  " + robots[i].Id);
                }
                Line();

                break;


            case 2:
                Console.WriteLine("Enter information about citizen like : Citizen {name} {age} {id} {birthDay}");
                Console.WriteLine("Enter information about robot like : Robot {model} {birthDay}");
                Console.WriteLine("Enter information about pet like : Pet {name} {birthDay}");
                
                Line();
                
                while(true)
                {
                    Console.Write("Enter information = ");
                    string[] enteredInformation = Console.ReadLine().Split();
                    if (enteredInformation.Length == 1 && enteredInformation[0].ToLower() == "end") break;
                    
                    else if (enteredInformation[0].ToLower() == "citizen")
                    {
                        Citizen tempCitizen = new Citizen(enteredInformation[1], int.Parse(enteredInformation[2]), enteredInformation[3], enteredInformation[4]);
                        citizens.Add(tempCitizen);
                    }

                    else if (enteredInformation[0].ToLower() == "pet")
                    {
                        Pets tempPet = new Pets(enteredInformation[1], enteredInformation[2]);
                        pets.Add(tempPet);
                    }

                    else if (enteredInformation[0].ToLower() == "robot")
                    {
                        Robot tempRobot = new Robot(enteredInformation[1], enteredInformation[2]);
                        robots.Add(tempRobot);
                    }
                }

                Line();
                Console.Write("Enter year of birthday = ");
                string year = Console.ReadLine();

                Console.WriteLine("Citizens : ");
                for(int i = 0; i < citizens.Count; i++) 
                {
                    if (citizens[i].Year == year) Console.WriteLine($"\t{citizens[i].Day}/{citizens[i].Month}/{citizens[i].Year}");
                }

                Console.WriteLine("Pets : ");
                for (int i = 0; i < pets.Count; i++)
                {
                    if (pets[i].Year == year) Console.WriteLine($"\t{pets[i].Day}/{pets[i].Month}/{pets[i].Year}");
                }


                break;
        }



    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}