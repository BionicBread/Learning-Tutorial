using System;
namespace ClassDEMO2
{
    partial class Program
    {
        public class Point
        {
            public int X;
            public int Y;
            public Point(int x, int y)   // created using the ctor code snippet Point is a new type that can be used in the Point Class see main program
            {
                this.X = x;             // Poiint type is defined as two integers, x and y
                this.Y = y;
            }
            public void Move(int x, int y) // Move class with x, y input parameters
            {
                this.X = x;                 // "this." keyword is equilivant to X = x
                this.Y = y;                 // the instance member X is assign with x
            }
            public void Move(Point newLocation) // the new Point type is used, remember it contains two integers
            {
                if (newLocation == null)
                {
                    throw new ArgumentNullException("newLocation");
                }
                Move(newLocation.X, newLocation.Y);
            }
         
        }
    }
}
