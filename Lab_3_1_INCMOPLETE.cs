using System;
using System.IO;

class HelloWorld {
    class Participant{
        private int EmpId,FoundationMarks, WebBasicMarks, DotNetMarks, Total_Marks, 
ObtainedMarks;
        private double Percentage;
        private string Name, Company_Name;
        Total_Marks = 300;
        static Participant(){
            Company_Name = "Corp University";
        }
        Participant(){}
        Participant(int EmpId, int FoundationMarks,int WebBasicMarks, int DotNetMarks, int Total_Marks, int ObtainedMarks){
            this.EmpId = EmpId;
            this.FoundationMarks = FoundationMarks;
            this.WebBasicMarks = WebBasicMarks;
            this.DotNetMarks = DotNetMarks;
            this.ObtainedMarks = ObtainedMarks;
        }
        public void TotalMarks(){
            
        }
        
        public void CalcPerc(){
            
        }
        public double GetPerc(){
            return Percentage;
        }
    }
  static void Main() {
    
  }
}
