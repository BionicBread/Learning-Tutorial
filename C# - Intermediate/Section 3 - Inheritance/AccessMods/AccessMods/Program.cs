using System;
using Amazon; 
namespace AccessMods
{
    partial class Program
    {
        static void Main(string[] args)
        {

            // Access modifiers control the visibility of class to make it a black box
            // Public - everyone can access
            // Private - only accessible in the class
            // Protected - only accssible from the class and it's derived classes
            // Internal - Accessible only from the same assembly or class library
            // 

            Customer customer = new Customer();

            customer.CalculateRating(true); // Class methods that contain implementation logic should be not accessible. IF parameter added to class method this call will also break
            customer.CalculateSomething(); // Not accessible because of the private access modifier

            Example client = new Example(); // Example class from a class library is not detected, a reference to the class library needs to be created
                                            // Right click dependenics > add project reference > select class library name
                                            // add the name of the class library in the Using
        }
    }
}
