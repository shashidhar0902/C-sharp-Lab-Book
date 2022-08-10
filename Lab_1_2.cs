using System;

namespace MyApp2{
    
    class ArithmeticOperations{
        
        public void Add(int a, int b){
            
            Console.WriteLine(a+b);
            
        }
        
        public void Sub(int a, int b){
            
            Console.WriteLine(a-b);
            
        }
        
        public void Mul(int a, int b){
            
            Console.WriteLine(a*b);
            
        }
        
        public void Div(int a, int b){
            
            Console.WriteLine(a/b);
            
        }
        
        public void Mod(int a, int b){
            
            Console.WriteLine(a%b);
            
        }
        
        public void Add(double a, double b){
            
            Console.WriteLine(a+b);
            
        }
        
        public void Sub(double a, double b){
            
            Console.WriteLine(a-b);
            
        }
        
        public void Mul(double a, double b){
            
            Console.WriteLine(a*b);
            
        }
        
        public void Div(double a, double b){
            
            Console.WriteLine(a/b);
            
        }
        
        public void Mod(double a, double b){
            
            Console.WriteLine(a%b);
            
        }
        
    }
    
    class HelloWorld {
        
      static void Main() {
          
        ArithmeticOperations ao = new ArithmeticOperations();
        
        ao.Add(1,2);
        
        ao.Add(1.2,3);
        
        ao.Add(1.2,3.4);
        
      }
      
    }
}

