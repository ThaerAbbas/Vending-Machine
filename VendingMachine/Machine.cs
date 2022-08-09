using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    
   
    public class Machine : IVending
    {
       
            
        

        public List<Product> products = new List<Product>();

        public  int[] kr = new int[] { 1000, 500, 100, 50, 20, 10, 5,  1 };


        public  int kronorpool { get; set; }
       
        int peng = 0;

        public Machine()
        {

            Start();
            CreateListOfProducts();
              
        }
        public void Start()
        {
            
            Console.WriteLine( " welcome to the best vending machine ");
        }

        private void CreateListOfProducts()
        {


            Snack snack = new Snack("Hotdog",40, "Red juicy hotdogs");
            products.Add(snack);
            snack = new Snack("Cookies",18, "high fat low protien");
            products.Add(snack);
          

            Drink drink = new Drink("cola",22, "Zero sugar");
            products.Add(drink);
            drink = new Drink("Kings County Distillery Straight Bourbon Whiskey",1000, "Strong 45% alc");
            products.Add(drink);
            drink = new Drink("Casamigos Blanco.Tequila",420, "papaya, guava, and vanilla");
            products.Add(drink);


            Candy candy = new Candy("Chocolate-Bar",40, "high proten low fat ");
            products.Add(candy);
            candy = new Candy("Bag of Chips",18, "salt");
            products.Add(candy);

        }



        public int[] EndTransaction()
        {
            int[] x =new int[kr.Length];
            Console.WriteLine("You get back:");
            for (int i = 0; i < kr.Length; i++)
            {
                int val = kr[i];    
                int antal = kronorpool / val;
                kronorpool -= antal * val;
                if (antal > 0)
                {
                    x[i] = antal;
                   
                    Console.WriteLine($"{val} x {antal}kr");
                }
            }

            return x;


        }

        public void EndTransactionTest(Product product)
        {
            kronorpool = product.Price;


        }

      
        public void InsertMoney(bool sert, string val )
        {
            Console.WriteLine("please insert money  1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr and 1000kr");

            while (true)
            {
                bool test = true;
                string inputcoin;
                Console.Write("Insert money: ");
                if (sert)
                     inputcoin = Console.ReadLine();
                else
                     inputcoin = val;
                try
                {
                    test = int.TryParse(inputcoin, out peng);
                }
                catch
                {
                    Console.Write("Catch error ");
                }

                bool acceptable = false;
                for (int i = 0; i < kr.Length; i++)
                {
                    if (peng == kr[i]) acceptable = true;
                    if (acceptable) break;
                }

                if (test && acceptable) break; 
                else Console.WriteLine("Error");
            }
            kronorpool = kronorpool + peng;

           

        }





        public void Purchase()
        {
            Console.WriteLine("select your products by the num of id ");
            int val = int.Parse(Console.ReadLine());

            
            foreach (Product product in products)
            {

                if (product.Id == val)
                {

                    if (product.Price <= kronorpool)
                    {
                        ExecutePurchase(product);
                        Console.WriteLine($"now is {kronorpool} kr");
                        product.Examine(product);
                        product.Use(product);
                        break;
                    }
                     else  
                    {
                        Console.WriteLine($"To low to purchase");

                    }

                    break;
                }
               
            }
           
        }

        public void ExecutePurchase(Product p)
        {
          
            kronorpool -= p.Price;
        }
        

       

        public void ShowAll()
        {

            foreach (Product product in products)
            {
                 Console.WriteLine($"id:{product.Id} Product {product.Name} Cost = {product.Price}");
            }

        }
 
        
    }
}
