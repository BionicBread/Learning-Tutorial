using System;
namespace Polymorphism
{
    public class Circle : Shape
    {
        public override void Draw()  //override keyword, this means that the draw method is different from objects that call the circle class
        {
            Console.WriteLine("Draw a circle");
            //base.Draw(); // reference to the parent case important when there is impementation
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw() // override used here this means that the draw method is different from objects that call the Rectangle class
        {
            Console.WriteLine("Draw a rectangle");
            //base.Draw();
        }
    }
    public class Shape 
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        
        public virtual void Draw()  // virtual keyword for the draw method
        {

        }
        
    }
}
