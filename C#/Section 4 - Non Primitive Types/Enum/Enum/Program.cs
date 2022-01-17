using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
            //best practise to assign values in enums
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Enum is like an array but for variables rather than an integer
            // For ex: 3 separate methods to ship an item
            //const int RegularAirMail=1;
            //const int RegisteredAirMail=2;
            //const int Express=3;
            // This could get messy so instead it can be put into an Enum
            // Similar to Classes, enum should be declared after the namespace
            //    public enum ShippingMethod
            //{
            //    RegularAirMail=1,
            //    RegisteredAirMail=2,
            //    Express=3, 
            //}
            ////enum is by default an int
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // ((int)method)) the enum method is casted into an int variable
            // Above code return the index id
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // the methodID = 3 is put back into the enum and returns the string for that id
            // Above code returns Express. IF index is out of range of the enum i.e 4 then the int is returned as a result.

            //Case for converting into a string
            Console.WriteLine(method.ToString());
            // .ToString will always convert to a string but even without it console.write will convert to string
            var methodName = "Express"; // Here we want a string that is parsed into the enum rather than an index number
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName); //Enum is a class in system with a method called Parse
            // The Parse method has two inputs, a "Type" and a "String". The typeof is used to define the enum type then methodName is a string. 
            // This is how a string is parsed into a enum

            
        }
    }
}
