using VendingMachine;

namespace Test
    
{
    public class UnitTest1
    {
        [Fact]
        public void InsertMoneyTest()
        {
            Machine machine = new Machine();
            int value = 100;
            machine.InsertMoney(false,value.ToString());
            Assert.Equal(machine.kronorpool,value);
        }
        [Fact]
        public void ExecutePurchaseTest()
        {
            Machine machine = new Machine();
            int value = 100;
            machine.InsertMoney(false, value.ToString());
            machine.ExecutePurchase(new Drink ("cola", 20, ""));
            Assert.Equal(80, machine.kronorpool);
        }

        [Fact]
        public void EndTransactionTest()
        {
            Machine machine = new Machine();
            machine.kronorpool = 100; 
            machine.EndTransaction();
            int sut = machine.kronorpool;
            Assert.Equal(0, sut );
        }
        [Fact]
        public void EndTransactionTest2()
        {
            Machine machine = new Machine();
          
            int[] x = new int[8];
            int[] xs = new int[] {0,0,0,0,1,1,1,2};
            machine.kronorpool = 37;
            x=machine.EndTransaction();

            Assert.Equal(x, xs);
        }

        [Fact]
        public void DoesMachineCointianProduct()
        {
            Machine sut = new Machine();
            Assert.True(sut.products.Count > 0);

        }
           
        
    }
}