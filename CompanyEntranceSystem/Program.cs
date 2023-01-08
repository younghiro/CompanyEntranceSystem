//function for just message
void notice()
{
    Console.WriteLine("it's not recognized. Please try again");
}

while (true) {
    ///////////////
    //log in
    ///////////////
    Console.WriteLine("Welcome to CZU company");
    //int worker_number = 0;
    int company_passowrd = 0;
    int checkVisitorOrWorker = 0;
    Visitor currentVisitor = null;
    Worker currentWorker = null;

    while (true)
    {
        try
        {
            int worker_number = 0;
            int check_worker_number = 0;
            Console.WriteLine("Please type your company worker number: ");
            worker_number = int.Parse(Console.ReadLine());
            //a object is created by user's input.
            if (worker_number == 000)  //check a worker or a visitor by visitor's work number which is 000
            {
                Console.WriteLine("Please type your password: ");
                while (true)
                {
                    try
                    {
                        company_passowrd = int.Parse(Console.ReadLine());
                        //Check against our db and when we findthe data, we will get the object of the visitor
                        currentVisitor = db.visitors.FirstOrDefault(a => a.PassWord == company_passowrd); //FirstOrDefault is to enumerate ,serach for certain property ,and return the object
                        if (currentVisitor != null) { break; }
                    }
                    catch
                    {
                        notice();
                    }
                }
            }
            else //worker
            {
                while (true)
                {
                    try
                    {
                        //check work number
                        Worker currentWorker_checkPassword = null;
                        currentWorker_checkPassword = db.workers.FirstOrDefault(a => a.CompanyNumber == worker_number); //FirstOrDefault is to enumerate ,serach for certain property ,and return the object
                        if(currentWorker_checkPassword == null)
                        {
                            Console.WriteLine("Sorry we don't find the number");
                            break;
                        }

                        Console.WriteLine("Please type your password: ");
                        company_passowrd = int.Parse(Console.ReadLine());
                        check_worker_number = check_worker_number + 1; //count the numerthe a user missed
                        //if a user miss at three times, take a user back to typeing work number function
                        if (check_worker_number > 2)
                        {
                            Console.WriteLine("You missed to type your password at three times so please start from typing worker number ");
                            break;
                        }

                        //Check against our db and when we findthe data, we will get the object of the worker 
                        if (currentWorker_checkPassword.PassWord == company_passowrd)
                        {
                            currentWorker = db.workers.FirstOrDefault(a => a.PassWord == company_passowrd); //FirstOrDefault is to enumerate ,serach for certain property ,and return the object
                        }

                        if (currentWorker != null)
                        {
                            checkVisitorOrWorker = 1;//here we decide whether we show options for workers or visitors
                            break;
                        }
                        else
                        {
                            notice();
                        }

                    }
                    catch
                    {
                        notice();
                    }
                }
            }

            if (currentVisitor != null || currentWorker != null && worker_number == currentWorker.CompanyNumber) //if we don't get a user from db, we force the user to type user's information again
            {
                break;
            }
            else { notice(); }
        }
        catch
        {
            notice();
        }
    }

    /////////////
    ///options
    ////////////
    int option = 0;

    if (checkVisitorOrWorker == 1)//worker 
    {
        Console.WriteLine(currentWorker.ToString());
        do
        {
            Worker.printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { Worker.attend(currentWorker); }
            else if (option == 2) { Worker.leavingWork(currentWorker); }
            else if (option == 3) { Worker.seeState(currentWorker); }
            else if (option == 4) { break; }
            else { option = 0; }
        } while (option != 4);

        Console.WriteLine("Thank you! ");
        Console.ReadLine();
    }
    else//visitor
    {
        Console.WriteLine(currentVisitor.ToString());
        do
        {
            Visitor.printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { Visitor.attend(currentVisitor); }
            else if (option == 2) { Visitor.leaving(currentVisitor); }
            else if (option == 3) { break; }
            else { option = 0; }
        } while (option != 3);

        Console.WriteLine("Thank you! ");
        Console.ReadLine();
    }
}
