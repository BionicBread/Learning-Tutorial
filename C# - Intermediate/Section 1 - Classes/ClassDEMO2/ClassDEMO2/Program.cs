using System;

namespace ClassDEMO2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse("abc"); // Will cause Format exception
                
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed"); // Equilivant to the below example with TryParse
            }
            
            bool result = int.TryParse("123", out int number); // if parse is successful the "out" keyword will output the result as an int
            if (result)                                         // TryParse catchs the exception if int.Parse is used instead then a try/catch will need to be written. See above
            {
                Console.WriteLine(result + " " + number);
            }
            else
                Console.WriteLine("Conversion failed");

        }

        static void UseParams()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 7));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3 })); // creating an array also works with the params keyword
        }
           
            
            static void UsePoints()
            {
                try
                {
                    var point = new Point(10, 20); // instansiated the constructor Point and assigned x = 10 and y = 20 
                                                   //point.Move(new Point(40, 60)); // called the Move method that uses point type and changed the x and y values
                    point.Move(null);               // passing a null object will crash the app
                    Console.WriteLine("Point is at: {0}, {1}", point.X, point.Y); // format string to show X and Y values

                    point.Move(100, 200);         // using 2nd overload, input parameter is 2 integers
                    Console.WriteLine("Point is at: {0}, {1}", point.X, point.Y);
                }
                catch (ArgumentNullException)
                {
                    //Do Something
                    Console.WriteLine("Something happened and C# doesn't like it!");

                }
            }
        
    }
}
