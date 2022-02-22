using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object of text
            //Text text = new Text();

            ////Upcasting - no conversion is required
            //Shape shape = text;

            //// shape and text are both pointing to the same object
            //// a change in the shape parameter makes a change in the text parameter 
            //// i.e
            //text.Width = 100;
            //shape.Width = 200;

            //// result of text.Width is 200 because shape is pointing the the text object

            //Console.WriteLine(text.Width);

            // why is this IMPORTANT? 
            // POLYMORPHISM
            ////////////////////// UPCASTING //////////////////////
            // StreamReader class is a .NET framework class that reads the data in a stream object
            // View > Object Viewer to see more
            // search for FileStream
            // this class allows handling of files i.e read and write to a file
            // Try memory stream

            //StreamReader reader = new StreamReader(new FileStream()); // In the constructor of StreamReader() we can use any object derived from the Stream Class as a parameter i.e FileStream or memoryStream

            //ArrayList list = new ArrayList();
            //list.Add(1); // the parameter for .Add is Object which is the parent class of all classes in the .NET
            //list.Add("someTEXT"); // because of this elements in an arrayList can be upcasted to Object type meaning different types can be added to the list
            //list.Add(new Text()); //including object types

            //List<int> anotherList = new List<int>(); // Generic lists offer type safety but declaring a type
            //List<Shape> anotherList1 = new List<Shape>(); // even a list of object types

            /////////// DOWNCASTNG ///////////////////////
            ///

            Shape shape = new Text();

            // Invalid cast exception could be thrown if an object cannot be casted
            // Use the "as" keyword to check for this
            // i.e 
            // Car car = (Car) obj;
            //Car car = object as Car; // if object cannot be cast, car = null
            //if (car != null)          // checks if car was casted.
            //{
            //}
            //

            // "is" keyword can be used to check the type of an object
            // if (obj is Car)
            // {
            // } 

        }
    }
}
