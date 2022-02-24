using System;
using System.Collections.Generic;

namespace Polymorphism
{ 
    //public class Shape
    //{
    //    public virtual void Draw()
    //    {

    //    }
    //}

    //public class Circle : Shape
    //{
    //    public override void Draw()
    //    {
    //        base.Draw();
    //    }
    //}

    //public class Image : Shape
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
            // Method overriding (do not confuse with method overloading)
            // vitural and override keyword 
            // Modifying implementation of an inherited methods
            // 
            // class Shape contains the method Draw
            // Circle and Image inherit from Shape
            // but the implemenation for Draw in Circle and Image are different
            // virtual and override keywords is useful here 

            var shapes = new List<Shape>(); // create a list of Shape objects
            shapes.Add(new Circle());       // create 
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

        }
    }
}
