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

    public class Worker : Human
    {
        public string Department { get; set; }

        void printOptions()
        {
            Console.WriteLine("Please choose from one of following options");
            Console.WriteLine("1. attendance at work");
            Console.WriteLine("2. leaving work");
            Console.WriteLine("3. see coworkers state");
            Console.WriteLine("4. exit");
        }

        void attend() //1 take parameter
        {
            Console.WriteLine("Please push 1 to start your work or 2 to go back");
            int check = int.Parse(Console.ReadLine());
            try
            {
                if (check == 1)
                {
                    //check if the person is working
                    //if( false){
                    //Console.WriteLine("You are already working in this system. Please contact our management department. ");
                    //}else{
                    //switch thier state to true}


                    Console.WriteLine("we put you in our working list"); //Console.WriteLine("we put " +  call user name  " in our working list");
                    printOptions();

                }
                else if (check == 2)
                {
                    printOptions();
                }
            }
            catch
            {
                attend();
            }
        }

        void leavingWork() //2 take parameter
        {
            Console.WriteLine("Please push 1 to start your work or 2 to go back");
            int check = int.Parse(Console.ReadLine());
            try
            {
                if (check == 1)
                {
                    //check if the person aleady left
                    //if( true){
                    //Console.WriteLine("You already left in this system. Please contact our management department. ");
                    //}
                    //else{
                    //switch thier state to false
                    //}


                    Console.WriteLine("Thank you for the working and we get you off from our working list.");
                    //Console.WriteLine("Thank you  for the working and we get " +  call user name  " off from our working list."); 
                    printOptions();

                }
                else if (check == 2)
                {
                    printOptions();
                }
            }
            catch
            {
                leavingWork();
            }
        }

        void seeState() //3 take parameter
        {
            //if the user is a visitor, we don't show them
            //first sort them based on state
            //after that show only their names and explantions and positions
            Console.WriteLine();
        }

        private Worker(string name, int password, string department,int companyNumber, bool state) : base(name, password, companyNumber,state)
        {
            Department = department;
        }
    }

    public class Visitor : Human
    {
        public string Explanation { get; set; }

        void printOptions_visitor()
        {
            Console.WriteLine("Please choose from one of following options");
            Console.WriteLine("1. attendance");
            Console.WriteLine("2. leaving here");
            Console.WriteLine("3. exit");
        }

        void attend_visitor() //1 take parameter  
        {
            Console.WriteLine("Please push 1 to start your work or 2 to go back");
            int check = int.Parse(Console.ReadLine());
            try
            {
                if (check == 1)
                {
                    //check if the person is working
                    //if( false){
                    //Console.WriteLine("You are already working in this system. Please contact our management department. ");
                    //}else{
                    //switch thier state to true}


                    Console.WriteLine("we put you in our working list"); //Console.WriteLine("we put " +  call user name  " in our working list");
                    printOptions_visitor();

                }
                else if (check == 2)
                {
                    printOptions_visitor();
                }
            }
            catch
            {
                attend_visitor();
            }
        }

        private Visitor(string name, int password, string explanation, int companyNumber, bool state) :  base(name, password, companyNumber, state)
        {
            Explanation = explanation;
            password = 000;
        }
    }
    
}

