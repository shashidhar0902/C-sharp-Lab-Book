using System;

namespace BankApp{
    
    public enum BankAccountTypeEnum{  
            Current=1,
            Saving=2
    }
    
    interface IBankAccount{
        
         double GetBalance();
         void Deposit(double amount);
         bool Withdraw(double amount);
         bool Transfer(IBankAccount toAccount, double amount);
         BankAccountTypeEnum AccountType { get; set; }

    }
    
    abstract class BankAccount : IBankAccount{
        
        public BankAccountTypeEnum AccountType {get; set;}
        
        protected double Balance = 0.0;
        
        public double GetBalance(){
            return this.Balance;
        }
        
        public void Deposit(double amount){
            this.Balance += amount;
        }
        
        public abstract bool Withdraw(double amount);
        public abstract bool Transfer(IBankAccount toAccount, double amount);
        
        
    }
    
    class ICICI : BankAccount{
        
        
        public override bool Withdraw(double amount){
            if(this.Balance - amount>=0){
                this.Balance -=amount;
                return true;
            }
            else{
                return false;
            }
        }
        
        public override bool Transfer(IBankAccount toAccount, double amount){
            if(this.Balance - amount>=1000){
                this.Balance -=amount;
                Console.WriteLine("Transfering Money : " + amount);
                toAccount.Deposit(amount);
                return true;
            }
            else{
                return false;
            }
        }
    }
    
    class HSBC : BankAccount{
        public override bool Withdraw(double amount){
            if(this.Balance - amount>=0){
                this.Balance -=amount;
                
                return true;
            }
            else{
                return false;
            }
        }
        
        public override bool Transfer(IBankAccount toAccount, double amount){
            if(this.Balance - amount>=1000){
                this.Balance -=amount;
                Console.WriteLine("Transfering Money : " + amount);
                toAccount.Deposit(amount);
                return true;
            }
            else{
                return false;
            }
        }
    }
    
    class main{
        
        public static void Main(){
            
            BankAccount acc1 = new ICICI();
            BankAccount acc2 = new HSBC();
            
            acc1.Deposit(100000);
            acc2.Deposit(200000);
            
            acc1.Transfer(acc2,10000);
            acc2.Transfer(acc1,20000);
            
            Console.WriteLine(acc1.GetBalance());
            Console.WriteLine(acc2.GetBalance());
            
        }
    }
}
