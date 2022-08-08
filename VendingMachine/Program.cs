using  VendingMachine;
Machine m = new Machine();


m.InsertMoney(true, "");

bool finished = false;


do
{
    
    
    m.ShowAll();
    Console.WriteLine("1 --> Purchase.");
    Console.WriteLine("2 --> EndTransaction.");
    Console.Write("Choose : 1 or 2  \n");


    int selection = int.Parse(Console.ReadLine());



    switch (selection)
    {


        case 1:

            m.Purchase();
            break;
        case 2:

           
            m.EndTransaction();
            finished = true;
            break;
       
        default:
            Console.WriteLine("No valid selection please choose (1-2)");
            break;
    }



} while (!finished);















