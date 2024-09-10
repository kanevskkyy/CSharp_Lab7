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
        List<Rebel> rebels = new List<Rebel>();

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

            case 3:
                Console.WriteLine("Enter information about citizen like : {name} {age} {id} {birthDay}");
                Console.WriteLine("Enter information about rebels like : {name} {age} {team}");

                Console.Write("Enter amount of citizen and rebels = ");
                int amountPeople = int.Parse(Console.ReadLine());
                Line();

                for(int i = 0; i < amountPeople; i++)
                {
                    Console.Write($"Enter information about {i + 1} person = ");
                    
                    string[] information = Console.ReadLine().Split();
                    SameName(information, citizens, rebels);
                    
                    if(information.Length == 4)
                    {
                        Citizen tempCitizen = new Citizen(information[0], int.Parse(information[1]), information[2], information[3]);
                        citizens.Add(tempCitizen);
                    }

                    if(information.Length == 3)
                    {
                        Rebel tempRebel = new Rebel(information[0], int.Parse(information[1]), information[2]);
                        rebels.Add(tempRebel);
                    }

                }

                Line();
                Console.WriteLine("Now, just enter name who bought food");
                while (true)
                {
                    Console.Write("Enter = ");
                    string name = Console.ReadLine();
                    if (name.ToLower() == "end") break;

                    bool isCitizen = false;
                    
                    for (int i = 0; i < citizens.Count; i++)
                    {
                        if (citizens[i].Name == name) 
                        {
                            citizens[i].BuyFood(); 
                            isCitizen = true;
                        }
                    }

                    if (!isCitizen)
                    {
                        for (int i = 0; i < rebels.Count; i++) 
                        {
                            if (rebels[i].Name == name)
                            {
                                rebels[i].BuyFood();
                            }
                        }
                    }

                }

                int totalFood = 0;
                
                for(int i = 0; i < citizens.Count; i++)
                {
                    totalFood += citizens[i].Food;
                }

                for (int i = 0; i < rebels.Count; i++)
                {
                    totalFood += rebels[i].Food;
                }
                Line();
                Console.WriteLine($"Total bought food = {totalFood}");

                break;
        }



    }

    public static void SameName(string[] information, List<Citizen> citizens, List<Rebel> rebels)
    {
        for (int j = 0; j < citizens.Count; j++)
        {
            if (citizens[j].Name == information[0])
            {
                Console.WriteLine("Name of citizens cannot dublicate!");
                Environment.Exit(0);
            }
        }

        for (int j = 0; j < rebels.Count; j++)
        {
            if (rebels[j].Name == information[0])
            {
                Console.WriteLine("Name of rebels cannot dublicate!");
                Environment.Exit(0);
            }
        }

        for (int j = 0; j < citizens.Count; j++)
        {
            for (int k = 0; k < rebels.Count; k++)
            {
                if (citizens[j].Name == rebels[k].Name)
                {
                    Console.WriteLine("Name of rebels and citizens cannot be same!");
                    Environment.Exit(0);
                }
            }
        }
    }

    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}