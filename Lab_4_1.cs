using System;

namespace App11{
    
    class Employee{
        
        protected int EID,Sal;
        protected string EName, Addr, C, Dept;
        
        public Employee(){
            EID = 0;
        EName = "";
        Sal = 0;
        Addr = "";
        C = "";
        Dept = "";
        }
        
        public int Id{
            
            get{return EID;}
            
            set{EID = value;}
            
        }
        
        public virtual int GetSalary(){
            
            return Sal;
            
        }
        
        public int Salary{
            
            get{return Sal;}
            
            set{Sal = value;}
            
        }
        
        public string Name{
            
            get{return EName;}
            
            set{EName = value;}
            
        }
        
        public string Address{
            
            get{return Addr;}
            
            set{Addr = value;}
            
        }
        
        public string City{
            
            get{return C;}
            
            set{C = value;}
            
        }
        
        public string Department{
            
            get{return Dept;}
            
            set{Dept = value;}
            
        }
        
        public override string ToString(){
            return EID + " " + EName + " " + Addr + " " + C + " "+ Dept;
            
        }
        
    }
    
    class ContractEmployee : Employee{
        
        private int perks;
        
        public int Perks{
            
            set{perks = value;}
            
            get{return perks;}
            
        }
        
        public override int GetSalary(){
            
            return (Sal + perks);
            
        }
        
    }
    
    class PermanentEmployee : Employee{
        
        private int PF;
        
        public int ProvidentFund{
            
            set{PF = value;}
            
            get{return PF;}
            
        }
        
        public override int GetSalary(){
            
            return (Sal - PF);
            
        }
        
    }
    
    class HelloWorld {
        
      static void Main() {
          
          int opt;
          opt=2;
          
        //   ContractEmployee ce = new ContractEmployee();
        //   ce.Perks = 233;
        //   ce.Name = "fsdf";
        //   ce.Salary = 4565000;
        //   Console.WriteLine(ce.GetSalary());
        
        Console.WriteLine("Select the type  of Employee:\n1:ContractEmployee\n2:PermanentEmployee");
        
        switch(opt){
            case 1 : ContractEmployee ce = new ContractEmployee();
                     ce.Id = 123;
                     ce.Name = "dfjhkla";
                     ce.Salary = 100000;
                     ce.Address = "gafdg";
                     ce.Perks = 344;
                     ce.Department = "dfsa";
                     ce.City = "egrsg";
                     Console.WriteLine(ce.GetSalary());
                     Console.WriteLine(ce);
                     break;
            case 2 : PermanentEmployee pe = new PermanentEmployee();
                     pe.Id = 123;
                     pe.ProvidentFund = 1;
                     pe.Name = "dfjhkla";
                     pe.Salary = 100000;
                     pe.City = "egrsg";
                     pe.Address = "gafdg";
                     pe.Department = "dfsa";
                     Console.WriteLine(pe.GetSalary());
                     Console.WriteLine(pe);
                     break;
            default:
                    Console.WriteLine("Enter valid input");
                    break;
        }
        
          
      }
      
    }
    
}
