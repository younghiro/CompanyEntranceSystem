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

        private Worker(string name, int password, string department,int companyNumber, bool state) : base(name, password, companyNumber,state)
        {
            Department = department;
        }
    }

    public class Visitor : Human
    {
        public string Explanation { get; set; }

        private Visitor(string name, int password, string explanation, int companyNumber, bool state) :  base(name, password, companyNumber, state)
        {
            Explanation = explanation;
            password = 000;
        }
    }
    
}

