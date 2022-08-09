using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Candy : Product
    {

        public Candy (string name, int price, string description) : base(name, price, description) { }

    public override void Examine(Product p)
    {

            Console.WriteLine("price: " + $"{p.Price}");
            Console.WriteLine($"{p.Description}");
           
        }
    public override void Use(Product p)
    {
            Console.WriteLine($"{p.Name}" + ":" + "very tasty!");
            Console.WriteLine();
        }
    }
}
