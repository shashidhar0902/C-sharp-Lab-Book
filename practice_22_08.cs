using System;
using System.Threading;
 
namespace MyConsoleApp
{
    internal class Demo123
    {
        static void Main()
        {
            Thread t1 = new Thread(DisplayNumbers);
            Thread t2 = new Thread(ReverseNumbers);
            //t1.IsBackground = true;
            //t2.IsBackground = true;
            t1.Start();
            t2.Start();
            Console.WriteLine("End of the Main Thread");
        }
        static void DisplayNumbers()
        {
            int num = 0;
            while (num<10)
            {
                num++;
                Console.WriteLine(num);
            }
        }
        static void ReverseNumbers()
        {
            int num = 101;
            while (num>90)
            {
                num--;
                Console.WriteLine(num);
            }
        }
    }
}
