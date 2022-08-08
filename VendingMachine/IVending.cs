using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    
    
    interface IVending
    {
    


        public void Purchase();
        public void ShowAll();
        public void InsertMoney(bool test,string val);
        public int[] EndTransaction();

       

    }
}
