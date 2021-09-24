using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree_Project
{
    
    interface IManageAccount
    {
        void deposit();//by default public and abstract
        void withdraw();
        void balance();
    }
    interface IBankAccount
    {
         void deposit();
        void withdraw();
        void balance();
        
    }

    class SavingAccount : IBankAccount,IManageAccount
    {
        public void balance()
        {
            Console.WriteLine("Balance in saving account.");
        }

        public void closeAccount()
        {
            Console.WriteLine("closing saving account.");

        }

        public void deposit()
        {
            Console.WriteLine("Deposit in saving account.");

        }

        public void openAccount()
        {
            Console.WriteLine("open saving account.");

        }

        public void withdraw()
        {
            Console.WriteLine("Withdraw from saving account.");

        }
    }

    class InterfaceExample
    {
        static void Main(string[] srgs)
        {

            SavingAccount sc = new SavingAccount();
            sc.deposit();
            sc.withdraw();
            sc.balance();
            sc.openAccount();
            sc.closeAccount();
        }
    }
}
