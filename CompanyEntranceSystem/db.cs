global using CompanyEntranceSystem;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CompanyEntranceSystem
{
    public static class db
    {

        public static List<Worker> workers = new List<Worker>();　//Worker(string name, int password, string department, int companyNumber, bool state) 
        public static List<Visitor> visitors = new List<Visitor>(); //Visitor(string name, int password, string explanation, int companyNumber, bool state) 
                                                      
        static db()
        {
            //List<List<Worker>> dataList = new List<List<Worker>>()
            //workers.Add("Alex", 555, "company president", 001,true);
            workers.Add(new Worker("Alex", 111, "company president", 001, true));
            workers.Add(new Worker("bob", 222, "sw engineer", 002, false));
            workers.Add(new Worker("tomas", 333, "sales", 003, true));
            workers.Add(new Worker("Luis", 444, "sales", 004, true));

            visitors.Add(new Visitor("watoson",001, "He is the son of Alex", 000, true));
            visitors.Add(new Visitor("Lisa", 002,"she is the wife of bob", 000, false));
        }
    }
}

