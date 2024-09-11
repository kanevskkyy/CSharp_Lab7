using System;
using task_3;

class Task
{
    static void Main()
    {
        List<Private> privates = new List<Private>();
        List<LeuntenantGeneral> leuntenantGenerals = new List<LeuntenantGeneral>();
        List<Engineer> engineers = new List<Engineer>();
        List<Commando> commandos = new List<Commando>();
        List<Spy> spies = new List<Spy>();


        while (true)
        {
            Console.Write("Enter information = ");
            string[] enteredInformation = Console.ReadLine().Split();
            if (enteredInformation.Length == 1 && enteredInformation[0].ToLower() == "end") break;

            if (enteredInformation.Length == 5 && enteredInformation[0].ToLower() == "private")
            {
                Private tempPrivate = new Private(int.Parse(enteredInformation[1]), enteredInformation[2], enteredInformation[3], int.Parse(enteredInformation[4]));
                privates.Add(tempPrivate);
            }

            if (enteredInformation[0].ToLower() == "leutenantgeneral")
            {
                LeuntenantGeneral tempGeneral = new LeuntenantGeneral(int.Parse(enteredInformation[1]), enteredInformation[2], enteredInformation[3], int.Parse(enteredInformation[4]));
                for (int i = 5; i < enteredInformation.Length; i++)
                {
                    for (int j = 0; j < privates.Count; j++)
                    {
                        if (int.Parse(enteredInformation[i]) == privates[j].Id)
                        {
                            tempGeneral.AddSoldier(privates[j]);
                            break;
                        }
                    }

                }
                leuntenantGenerals.Add(tempGeneral);
            }

            if (enteredInformation[0].ToLower() == "engineer")
            {
                if (enteredInformation[5].ToLower() == "marines" || enteredInformation[5].ToLower() == "airforces")
                {
                    Engineer tempEngineer = new Engineer(int.Parse(enteredInformation[1]), enteredInformation[2], enteredInformation[3], int.Parse(enteredInformation[4]), enteredInformation[5]);
                    for (int i = 6; i < enteredInformation.Length - 1; i += 2)
                    {
                        tempEngineer.NewRepairedThings(enteredInformation[i], int.Parse(enteredInformation[i + 1]));
                    }

                    engineers.Add(tempEngineer);
                }
            }

            if (enteredInformation[0].ToLower() == "commando")
            {
                if (enteredInformation[5].ToLower() == "marines" || enteredInformation[5].ToLower() == "airforces")
                {
                    Commando tempCommando = new Commando(int.Parse(enteredInformation[1]), enteredInformation[2], enteredInformation[3], int.Parse(enteredInformation[4]), enteredInformation[5]);

                    for (int i = 6; i < enteredInformation.Length - 1; i += 2)
                    {
                        tempCommando.addMission(enteredInformation[i], enteredInformation[i + 1]);
                    }
                    commandos.Add(tempCommando);
                }
            }

            if (enteredInformation[0].ToLower() == "spy")
            {
                Spy tempSpy = new Spy(int.Parse(enteredInformation[1]), enteredInformation[2], enteredInformation[3], int.Parse(enteredInformation[4]));
                spies.Add(tempSpy);
            }
        }

        Console.Write("Press enter if you ready to see ... ");
        Console.ReadKey();
        Console.Clear();


        if (privates.Count > 0)
        {
            Console.WriteLine("Privates : ");
            for (int i = 0; i < privates.Count; i++)
            {
                Console.WriteLine(privates[i]);
            }
            Line();
        }
        
        if(leuntenantGenerals.Count > 0)
        {
            Console.WriteLine("LeutenantGenerals : ");
            for (int i = 0; i < leuntenantGenerals.Count; i++)
            {
                Console.WriteLine(leuntenantGenerals[i]);
            }
            Line();
        }

        if(engineers.Count > 0)
        {
            Console.WriteLine("Engineer : ");
            for (int i = 0; i < engineers.Count; i++)
            {
                Console.WriteLine(engineers[i]);
            }
            Line();
        }
        
        if(commandos.Count > 0) 
        {
            Console.WriteLine("Commandos : ");
            for (int i = 0; i < commandos.Count; i++)
            {
                Console.WriteLine(commandos[i]);
            }
            Line();
        }

        if (spies.Count > 0)
        {
            Console.WriteLine("Spy : ");
            for (int i = 0; i < spies.Count; i++)
            {
                Console.WriteLine(spies[i]);
            }
            Line();
        }
        
        Console.WriteLine("\n\n");
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}