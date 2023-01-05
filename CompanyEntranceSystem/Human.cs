using System;
namespace CompanyEntranceSystem
{
    public abstract class Human
    {
        public string Name { get; set; }
        public int PassWord { get; set; }
        public int CompanyNumber { get; set; }
        public bool State { get; set; }　//true means the person is already inside

        protected Human(string name, int password, int companyNumber, bool state)
        {
            Name = name;
            PassWord = password;
            CompanyNumber = companyNumber;
            State = state;
        }
    }


    /// should I use generic method or overload to shorten code???

    public class Worker : Human
    {
        public string Department { get; set; }

        public static void printOptions()
        {
            Console.WriteLine("Please choose from one of following options");
            Console.WriteLine("1. attendance at work");
            Console.WriteLine("2. leaving work");
            Console.WriteLine("3. see coworkers state");
            Console.WriteLine("4. exit");
        }

        public static void attend( Worker currentWorker) //1 take parameter
        {
            Console.WriteLine("Please push 1 to start your work or 2 to go back");
            int check = int.Parse(Console.ReadLine());
            try
            {
                if (check == 1)
                {
                    //check if the person is working
                    if ( currentWorker.State == true)
                    {
                        Console.WriteLine("You are already working in this system. Please contact our management department. ");
                    }
                    else
                    {
                        currentWorker.State = true;
                    }

                    Console.WriteLine("we put " +  currentWorker.Name  +" in our working list");
                    printOptions();

                }
                else if (check == 2)
                {
                    printOptions();
                }
            }
            catch
            {
                attend(currentWorker);
            }
        }

        public static void leavingWork(Worker currentWorker) //2 take parameter
        {
            Console.WriteLine("Please push 1 to start your work or 2 to go back");
            int check = int.Parse(Console.ReadLine());
            try
            {
                if (check == 1)
                {
                    if (currentWorker.State == false)
                    {
                        Console.WriteLine("You already left in this system. Please contact our management department. ");
                    }
                    else
                    {
                        currentWorker.State = false;
                    }

                    Console.WriteLine("Thank you for the working and we get you off from our working list.");
                    Console.WriteLine("Thank you  for the working and we get " + currentWorker.Name + " off from our working list."); 
                    printOptions();

                }
                else if (check == 2)
                {
                    printOptions();
                }
            }
            catch
            {
                leavingWork(currentWorker);
            }
        }
        /////////////////
        public static void seeState(Worker currentWorker) //3 take parameter
        {
            db showWorkers = new db();
            Console.WriteLine(" true is working");
            foreach (Worker a in showWorkers.workers)
            {
                Console.WriteLine("{0} ; {1} ; {2}", a.Name, a.Department, a.State);
            }
        }

        public Worker(string name, int password, string department,int companyNumber, bool state) : base(name, password, companyNumber,state)
        {
            Department = department;
        }

        public override string ToString()
        {
            return $"welcome {Name}";
        }
    }

    public class Visitor : Human
    {
        public string Explanation { get; set; }

        public static void printOptions()
        {
            Console.WriteLine("Please choose from one of following options");
            Console.WriteLine("1. attendance");
            Console.WriteLine("2. leaving here");
            Console.WriteLine("3. exit");
        }

        public static void attend(Visitor currentVisitor) //1  
        {
            Console.WriteLine("Please push 1 to enter or 2 to go back");
            int check = int.Parse(Console.ReadLine());
            try
            {
                if (check == 1)
                {
                    if (currentVisitor.State == true)
                    {
                        Console.WriteLine("You are already working in this system. Please contact our management department. ");
                    }
                    else
                    {
                        currentVisitor.State = true;
                    }

                    Console.WriteLine("we put you in our working list");
                    Console.WriteLine("we put " + currentVisitor.Name +" in our working list");
                    printOptions();

                }
                else if (check == 2)
                {
                    printOptions();
                }
            }
            catch
            {
                attend(currentVisitor);
            }
        }

        public static void leaving(Visitor currentVisitor) //2 
        {
            Console.WriteLine("Please push 1 to leave or 2 to go back");
            int check = int.Parse(Console.ReadLine());
            try
            {
                if (check == 1)
                {
                    if (currentVisitor.State == false )
                    {
                        Console.WriteLine("You already left in this system. Please contact our management department. ");
                    }
                    else
                    {
                        currentVisitor.State = false;
                    }

                    Console.WriteLine("Thank you for the working and we get you off from our working list.");
                    Console.WriteLine("Thank you  for the working and we get " + currentVisitor.Name + " off from our working list."); 
                    printOptions();

                }
                else if (check == 2)
                {
                    printOptions();
                }
            }
            catch
            {
                leaving(currentVisitor);
            }
        }

        public Visitor(string name, int password, string explanation, int companyNumber, bool state) :  base(name, password, companyNumber, state)
        {
            Explanation = explanation;
            password = 000;
        }

        public override string ToString()
        {
            return $"welcome {Name}, we accept you with the reason( {Explanation} )";
        }
    }
    
}

