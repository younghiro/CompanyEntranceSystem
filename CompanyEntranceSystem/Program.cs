void printOptions()
{
    Console.WriteLine("Please choose from one of following options");
    Console.WriteLine("1. attendance at work");
    Console.WriteLine("2. leaving work");
    Console.WriteLine("3. see coworkers state");
    Console.WriteLine("4. exit");
}

void printOptions_visitor()
{
    Console.WriteLine("Please choose from one of following options");
    Console.WriteLine("1. attendance");
    Console.WriteLine("2. leaving here");
    Console.WriteLine("3. exit");
}

void notice()
{
    Console.WriteLine("it's not recognized. Please try again");
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
        else if(check == 2)
        {
            printOptions();
        }
    }
    catch{
        attend();
    }
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

void leavingWork_visitor() //2 take parameter
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
            printOptions_visitor();

        }
        else if (check == 2)
        {
            printOptions_visitor();
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
};

///////////////
//log in
///////////////
Console.WriteLine("Welcome to CZU company");
//check ur worker or visitor
//ここでクラスのインスタンスを作る cardholder currentUser;
Console.WriteLine("Please type your company worker number: ");
int worker_number = 0;
while (true)
{
    try
    {
        worker_number = int.Parse(Console.ReadLine());
        //a object is created by return value.
        if( worker_number == 000 )
        {
            //Check against our db
            //current = currentUser.FirstOrDefault( a => a.companyNumber ==worker_number) //FirstOrDefault is to enumerate ,serach for certain property ,and return the object
        }
        else
        {
            //Check against our db
            //current = currentUser.FirstOrDefault( a => a.companyNumber ==worker_number) //FirstOrDefault is to enumerate ,serach for certain property ,and return the object
        }
        if (currentUser != null ) // || visitor 
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
//もし000  この後の処理は続けて書く？


Console.WriteLine("Please type your password: ");
int company_passowrd = 0;



while (true) 
{
    try
    {
        company_passowrd = int.Parse(Console.ReadLine());
        //Check against our db
        //current = currentUser.FirstOrDefault( a => a.password ==company_passowrd) //FirstOrDefault is to enumerate ,serach for certain property ,and return the object
        if (currentUser != null) { break; }//ここでworkerかvisitorでオブジェクト
        else { notice(); }
    }
    catch
    {
        notice();
    }
}





//Console.WriteLine("Welcome " + //ここに名前をクラスからとる　　+" ;) ");
int option = 0;

if ()
{
    do
    {
        printOptions();
        try
        {
            option = int.Parse(Console.ReadLine());
        }
        catch { }
        if (option == 1) { attend(); } //ここに変数を渡す
        else if (option == 2) { }
        else if (option == 3) { }
        else if (option == 4) { break; }
        else { option = 0; }
    } while (option != 4);

    Console.WriteLine("Thank you! ");

}
else
{
    do
    {
        printOptions_visitor();
        try
        {
            option = int.Parse(Console.ReadLine());
        }
        catch { }
        if (option == 1) { attend(); } //ここに変数を渡す
        else if (option == 2) { }
        else if (option == 3) { break; }
        else { option = 0; }
    } while (option != 3);

    Console.WriteLine("Thank you! ");
}

