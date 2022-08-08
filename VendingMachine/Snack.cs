using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
     class Snack : Product
    {
        public Snack (string name, int price) : base(name, price)
        {
        }

        public override void Examine(Product p)
        {
            


            Console.WriteLine($"{p.Price}");
        }
        public override void Use(Product p)
        {
            Console.WriteLine($"{p.Name}");
        }


    }
}
