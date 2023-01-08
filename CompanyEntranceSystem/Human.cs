using System;
namespace CompanyEntranceSystem
{
    public abstract class Human
    {
        public string Name { get; set; }
        public int PassWord { get; set; }
        public int CompanyNumber { get; set; }
        public bool State { get; set; }　//true means the person is already inside

        //constructor
        protected Human(string name, int password, int companyNumber, bool state)
        {
            Name = name;
            PassWord = password;
            CompanyNumber = companyNumber;
            State = state;
        }
    }

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

        /// <summary>
        /// This method records whether a worker has entered.
        /// </summary>
        /// <param name="currentWorker">this parameter is produced by password</param>
        public static void attend( Worker currentWorker) 
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
                        Console.ReadLine();
                    }
                    else
                    {
                        currentWorker.State = true;
                        Console.ReadLine();
                        Console.WriteLine("we put " +  currentWorker.Name  +" in our working list");
                        Console.ReadLine();
                    }
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

        /// <summary>
        /// This method records whether a worker has left.
        /// </summary>
        /// <param name="currentWorker">this parameter is produced by password</param>
        public static void leavingWork(Worker currentWorker) 
        {
            Console.WriteLine("Please push 1 to finish today's work or 2 to go back");
            int check = int.Parse(Console.ReadLine());
            try
            {
                if (check == 1)
                {
                    if (currentWorker.State == false)
                    {
                        Console.WriteLine("You already left in this system. Please contact our management department. ");
                        Console.ReadLine();
                    }
                    else
                    {
                        currentWorker.State = false;
                        Console.WriteLine("Thank you  for the working and we get " + currentWorker.Name + " off from our working list.");
                        Console.ReadLine();
                    }
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

        /// <summary>
        /// This method show the record to only workers.
        /// </summary>
        /// <param name="currentWorker">this parameter is produced by password</param>
        public static void seeState(Worker currentWorker) 
        {
            Console.WriteLine("-----------");
            foreach (Worker a in db.workers)
            {
                if (a.State== true)
                {
                    Console.WriteLine("{0} ({1}) is working now", a.Name, a.Department);
                }else if(a.State == false){
                    Console.WriteLine("{0} ({1}) is not working now", a.Name, a.Department);
                }
            }
            Console.WriteLine("-----------");
        }

        //constructor
        public Worker(string name, int password, string department,int companyNumber, bool state) : base(name, password, companyNumber,state)
        {
            Department = department;
        }

        // overriding the ToString() method to show welcome message to a worker
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

        /// <summary>
        /// This method records whether a visitor has entered.
        /// </summary>
        /// <param name="currentWorker">this parameter is produced by password</param>
        public static void attend(Visitor currentVisitor)
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
                        Console.ReadLine();
                    }
                    else
                    {
                        currentVisitor.State = true;
                        Console.WriteLine("we put " + currentVisitor.Name + " in our working list");
                    }
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

        /// <summary>
        /// This method records whether a visitor has left.
        /// </summary>
        /// <param name="currentWorker">this parameter is produced by password</param>
        public static void leaving(Visitor currentVisitor)
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
                        Console.ReadLine();
                    }
                    else
                    {
                        currentVisitor.State = false;
                        Console.WriteLine("Thank you  for the working and we get " + currentVisitor.Name + " off from our working list.");
                    }
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

        //constructor
        public Visitor(string name, int password, string explanation, int companyNumber, bool state) :  base(name, password, companyNumber, state)
        {
            Explanation = explanation;
            password = 000;
        }

        // overriding the ToString() method to show welcome message to a visitor
        public override string ToString()
        {
            return $"welcome {Name}, we accept you with the reason( {Explanation} )";
        }
    }
    
}

