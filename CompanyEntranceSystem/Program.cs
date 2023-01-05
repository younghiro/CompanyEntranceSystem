void notice()
{
    Console.WriteLine("it's not recognized. Please try again");
}

///////////////
//log in
///////////////
Console.WriteLine("Welcome to CZU company");
Console.WriteLine("Please type your company worker number: ");
int worker_number = 0;
int company_passowrd = 0;
int checkVisitorOrWorker = 0;
db visitor = new db();
db worker = new db();
Visitor currentVisitor = null;
Worker currentWorker = null;
while (true)
{
    try
    {
        worker_number = int.Parse(Console.ReadLine());
        //a object is created by return value.
        if( worker_number == 000)  //check ur worker or visitor and here is for visitor
        {
            Console.WriteLine("Please type your password: ");
            while (true)
            {
                try
                {
                    company_passowrd = int.Parse(Console.ReadLine());
                    //Check against our db
                    currentVisitor = visitor.visitors.FirstOrDefault(a => a.PassWord == company_passowrd); //FirstOrDefault is to enumerate ,serach for certain property ,and return the object
                    //Console.WriteLine(currentVisitor.ToString());//////test
                    if (currentVisitor != null) { break; }
                }
                catch
                {
                    notice();
                }
            }
        }
        else
        {
            Console.WriteLine("Please type your password: ");
            while (true)
            {
                try
                {
                    company_passowrd = int.Parse(Console.ReadLine());
                    //Check against our db
                    currentWorker = worker.workers.FirstOrDefault(a => a.PassWord == company_passowrd); //FirstOrDefault is to enumerate ,serach for certain property ,and return the object
                    if (currentWorker != null)
                    {
                        checkVisitorOrWorker = 1;
                        break;
                    }
                    else { notice(); }
                }
                catch
                {
                    notice();
                }
            }
        }

        if (currentVisitor != null || currentWorker != null)
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

Console.WriteLine(currentVisitor.ToString());

int option = 0;

if (checkVisitorOrWorker == 1)//worker 
{
    do
    {
        Worker.printOptions();
        try
        {
            option = int.Parse(Console.ReadLine());
        }
        catch { }
        if (option == 1) { Worker.attend(currentWorker); } //ここに変数を渡す
        else if (option == 2) { Worker.leavingWork(currentWorker); }
        else if (option == 3) { Worker.seeState(currentWorker); }
        else if (option == 4) { break; }
        else { option = 0; }
    } while (option != 4);

    Console.WriteLine("Thank you! ");

}
else//visitor
{
    do
    {
        Visitor.printOptions();
        try
        {
            option = int.Parse(Console.ReadLine());
        }
        catch { }
        if (option == 1) { Visitor.attend(currentVisitor); } //ここに変数を渡す
        else if (option == 2) { Visitor.leaving(currentVisitor); }
        else if (option == 3) { break; }
        else { option = 0; }
    } while (option != 3);

    Console.WriteLine("Thank you! ");
}

