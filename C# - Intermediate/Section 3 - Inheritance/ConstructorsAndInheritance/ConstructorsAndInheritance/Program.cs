namespace ConstructorsAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Base class constructors are always executed first when instansiated 
            // Base class constructors are not inherited and needs to be redefined
            /////EXAMPLE: Plane and Jet
            /// EXAMPLE 2: Vehicle and Car

            //Car myCar = new Car();  // result: both default constructors are executed when creating a Car object. Note that Car inherits from Vehicle 
            // if the base default constructor is not available then there will be a problem

            Car myCar = new Car("YOLO MADLAD");  // object will an arguement  

        }
    }
}
