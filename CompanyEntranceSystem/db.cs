global using CompanyEntranceSystem;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CompanyEntranceSystem
{
    public class db
    {

        public List<Worker> workers = new List<Worker>();　//Worker(string name, int password, string department, int companyNumber, bool state) 
        public List<Visitor> visitors = new List<Visitor>(); //Visitor(string name, int password, string explanation, int companyNumber, bool state) 
                                                      
        public db()
        {
            //List<List<Worker>> dataList = new List<List<Worker>>()
            //workers.Add("Alex", 555, "company president", 001,true);
            workers.Add(new Worker("Alex", 555, "company president", 001, true));
            workers.Add(new Worker("bob", 555, "sw engineer", 002, false));
            workers.Add(new Worker("tomas", 555, "sales", 003, true));
            workers.Add(new Worker("Luis", 555, "sales", 004, true));

            visitors.Add(new Visitor("watoson",001, "He is the son of Alex", 000, true));
            visitors.Add(new Visitor("Lisa", 002,"she is the wife of bob", 000, false));
        }
    }
}

