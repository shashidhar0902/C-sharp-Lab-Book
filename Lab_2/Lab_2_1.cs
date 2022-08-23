using System;

namespace App { 
    public struct stru
    {
        public int Number { get; set; }

        public int Square()
        {
            return Number * Number;
        }

        public int Cube()
        {
            return Number * Number * Number;
        }
    }

    class main {
        public static void Main(){

            stru num = new stru();

            num.Number = 23;

            
            Console.WriteLine("Number: " + num.Number + "\nNumber Square:" + num.Square() + "\nNumber Cube:"+num.Cube());
            Console.ReadLine();

        }

    }
    
}
