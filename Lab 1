using System;

namespace AppConsole1{
    
    class Employee{
        
        private int EID,Sal;
        private string EName, Addr, C, Dept;
        
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
            //return EID + " " + EName + " " + Sal + " " + Addr + " " + C + " "+ Dept;
            return EName + " " + Sal;
        }
        
    }

    class HelloWorld {
        
        public static void Main(string[] args) {
          
            // Emp emp = new Emp();
            // emp.Id = 123;
            // emp.Name = "Kk";
            // emp.Salary = 123345;
            // emp.Department = "iot";
            // emp.City = "VSKP";
            // emp.Address = "39-2-2";
            // Console.WriteLine(emp);
            Employee[] emp_list = new Employee[10];
            
            for(int i=0;i<emp_list.Length;i++){
                // emp_list[i].Id = Int32.Parse(Console.Readline());
                // emp_list[i].Salary = Int32.Parse(Console.Readline());
                // emp_list[i].Name = Console.Readline();
                // emp_list[i].Department = Console.Readline();
                // emp_list[i].City = Console.Readline();
                // emp_list[i].Address = Console.Readline();
                Employee emp = new Employee();
                emp.Id = i+1;
                emp.Salary = (i+1)*10000;
                emp.Name = "aas";
                emp.Department = "dept";
                emp.City = "VSKP";
                emp.Address = "39-1-23/2";
                emp_list[i] = emp;
            }
            for(int i = 0 ;i<emp_list.Length;i++){
                Console.WriteLine(emp_list[i]);
            }
            
        }
      
    }
}
