void notice()
{
    Console.WriteLine("it's not recognized. Please try again");
}

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

if ()//worker
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
else//visitor
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

