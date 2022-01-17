using System;

namespace enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
        // enums are declared at the class level 
        // enums are lists with assoicated numbers
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express; // the variable method is using the enum list and "Express"
            Console.WriteLine((int)method); // Cast the variable into integar form
                                            // Conversely, we can get the text from a number
            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID); // take the methodID can convert to the enum by casting the number into the enum

            // the .ToString method can also extract the text from an enum

            Console.WriteLine(method.ToString()); // 

            var methodName = "Express"; //Parsing = changing a string to a different type
            // parse the above into enum
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); //parse the string methodName into ShippingMethod.

            Console.WriteLine((int)shippingMethod);


        }
    }
}
