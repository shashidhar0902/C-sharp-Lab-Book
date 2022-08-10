using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter some number from 1,2,3,4,5:");
    int opt;
    opt = 2;
    switch(opt){
        case 1:    Console.WriteLine("1");break;
        case 2:    Console.WriteLine("2");break;
        case 3:    Console.WriteLine("3");break;
        case 4:    Console.WriteLine("4");break;
        case 5:    Console.WriteLine("5");break;
        default:Console.WriteLine("Error");break;
    }
  }
}
