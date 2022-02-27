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

            List<Shape> shapes = new List<Shape>(); // create a list of Shape objects
            shapes.Add(new Circle());       // Add created object: circle into the list. This is possible because the class class inherits from the shape class
            shapes.Add(new Rectangle());    // Each class has the override method which means the Draw method contains different logic 
            // IF triangle was added here then the triangle class will inherit shape and override the draw method to use separate implementation

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);  // The Canvas class contains a method which is a for loop.
                                        // The Shape objects in the list shapes loop a method call: the Draw() method
            // Because 

        }
    }
}
