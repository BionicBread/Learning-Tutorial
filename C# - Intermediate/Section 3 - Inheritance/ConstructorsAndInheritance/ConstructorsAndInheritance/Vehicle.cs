using System;

namespace ConstructorsAndInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle() //default constructor
        //{
        //    Console.WriteLine("Vehicle is being created");
        //}
        public Vehicle(string registrationNumber)  //overload that takes a string parameter
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("this is the overload that takes a string parameter");
        }

    }
}
