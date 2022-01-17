using System;

namespace Exercise_4
{
    public class Policeman
    {
        public double Check(double carSpeed, double speedLimit)
        {
            double licensePoints;
            double speedingValue = (carSpeed - speedLimit) / 5;
            double demerit = Math.Floor(speedingValue);
            licensePoints = (demerit * 1);
            //Console.WriteLine("Points deducted " + licensePoints);
            return licensePoints;

        }
    }
}
