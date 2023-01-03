using System;
using System.Collections.Generic;
using CompanyEntranceSystem;

namespace CompanyEntranceSystem
{
    public class db
    {

        List<Worker> workers = new List<Worker>();　//Worker(string name, int password, int company_number, string department, int companyNumber, bool state) 
        List<Visitor> visitors = new List<Visitor>(); //Visitor(string name, int password, string explanation, int companyNumber, bool state) 
                                                      //Customers.Add(new Customer("John", "Doe", "Prague", 1985));

        //List<List<Worker>> dataList = new List<List<Worker>>()

        workers.Add(new Worker(){ "Alex", 555, "company president", 001,true});
        workers.Add(new List<Worker>( "bob", 555, "sw engineer", 002,false));
        workers.Add(new List<Worker>( "tomas", 555, "sales", 003,true));
        workers.Add(new List<Worker>( "Luis", 555, "sales",004, true));
            
        visitors.Add(new List<Visitor>("watoson","He is the son of Alex",000, true));
        visitors.Add(new List<Visitor>("Lisa","she is the wife of bob",000, false));

    }
}

