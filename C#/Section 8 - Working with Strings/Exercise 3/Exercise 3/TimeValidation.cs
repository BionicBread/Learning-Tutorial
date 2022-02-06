using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class TimeValidation
    {
        public static int[] InputSplit(string input)
        {
            string[] compare = input.Split(':');

            try
            {
                int[] intArray = Array.ConvertAll(compare, int.Parse);
                return intArray;
            }
            catch (SystemException e)
            {
                Console.WriteLine("Invalid: Numbers Only!");
                Environment.Exit(0);
            }

            int[] intComp = Array.ConvertAll(compare, int.Parse);
            return intComp;
        }
        public static void InputCheck(int[] splitArray)
        {
            
            if (splitArray.Length > 2)
            {
                Console.WriteLine("Invalid: too many numbers");
                Environment.Exit(0);
            }
            
            if (splitArray[0] <= 23 && splitArray[1] <=59)
                {
                Console.WriteLine("OK - THAT IS A VALID TIME");
                }
            else if (splitArray[0] >= 23 || splitArray[1] >= 59)
            {
                Console.WriteLine("Invalid");
                Environment.Exit(0);
            }


        }
    }
}
