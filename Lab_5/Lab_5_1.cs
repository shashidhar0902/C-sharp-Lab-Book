using System;

namespace BankApp{
    interface IBankAccount{
        
         double GetBalance();
         void Deposit(double amount);
         bool Withdraw(double amount);
         bool Transfer(IBankAccount toAccount, double amount);
         BankAccountTypeEnum AccountType { get; set; }

    }
    
    public enum  BankAccountTypeEnum
    {  
        Current=1,
        Saving=2
    }
    
    abstract class BankAccount : IBankAccount{
        protected double Balance;
    }
    
    class main{
        
        public static void Main(){
            
        }
    }
}
