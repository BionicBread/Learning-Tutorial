using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your job is to write a program for a speed camera.
            // For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            // Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
            // If the user enters a value less than the speed limit, program should display Ok on the console.
            // If the value is above the speed limit, the program should calculate the number of demerit points.
            // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            // If the number of demerit points is above 12, the program should display License Suspended.

            //double licensePoint = 0;
            Console.WriteLine("Enter Speed Limit Value");
            string speedLimit = Console.ReadLine();
            Console.WriteLine("Enter Speed of Car");
            string carSpeed = Console.ReadLine();
            double speedLimitConv = double.Parse(speedLimit); // Parse string into double
            double carSpeedConv = double.Parse(carSpeed);


            var road = new Policeman();
            double results = road.Check(carSpeedConv, speedLimitConv);

            if (results >= 12)
            {
                Console.WriteLine("License Suspended");
            }
            else if (results == 0)
            {
                Console.WriteLine("SPEED OK");
            }
            else if (results < 0)
            {
                Console.WriteLine("SPEED OK");
            }
            else
            {
                Console.WriteLine("Points deduced is " + results);
            }

        }
    }
}
