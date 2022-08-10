using System;

    public class Shape{
        
        public virtual void WhoamI(){
            
            Console.WriteLine("I m Shape");
            
        }
        
    }
    
 class Triangle :  Shape
 {
     public override void WhoamI()
     {
     Console.WriteLine("I m Triangle");
    }
}

class Circle :  Shape
 {
     public override void WhoamI()
     {
     Console.WriteLine("I m Circle");
    }
}

class HelloWorld {
  static void Main() {
    Shape s;
    s = new Triangle();
    s.WhoamI();
    s = new Circle();
    s.WhoamI();
  }
}
