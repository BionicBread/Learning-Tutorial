using System;

namespace ConstructorsAndInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) //takes an parameter that is used in the base class constructor
            : base(registrationNumber) // parameter used in the 1st overload
        {
            Console.WriteLine("Car is being created: {0}", registrationNumber);
        }
    }
}
