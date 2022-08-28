using System;

namespace App{
    public class Customer{
        
        public int CustomerId {get;set;}
        public string CustomerName {get;set;}
        public string Address {get;set;}
        public string City {get;set;}
        public string Phone {get;set;}
        public double CreditLimit {get;set;}
        
        public Customer(){}
        
        public Customer(int CustomerId,string CustomerName,string Address,string City,string Phone,double CreditLimit){
            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
            this.Address = Address;
            this.City = City;
            this.Phone = Phone;
            
            try{
                if(CreditLimit > 50000){
                    throw new InvalidCreditLimit("Credit Exceeded");
                }
            }
            catch(InvalidCreditLimit i){
                Console.WriteLine(i.Message);
            }
            finally{
                this.CreditLimit = 0;
            }
            this.CreditLimit = CreditLimit;
            
        }
        
    }
    
    public class InvalidCreditLimit : Exception{
        
        public InvalidCreditLimit(string message): base(message){}
        
    }
    
    class main{
        
        public static void Main(string[] args){
            
            Customer c = new Customer(12,"C1","39-1-23","Visag","9848",5000000);
            Console.WriteLine(c.Address);
            
        }
    }
}
