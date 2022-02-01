using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class SequenceLogic
    {
        public static void ConsecutiveCheck(string input)
        {
            string[] stringArray = input.Split("-");
            //Console.WriteLine(stringArray.Length); // check length of string array
            double[] numberArray = new double[stringArray.Length];
            int i = 0;
            int conCheck = 0;

            foreach (string s in stringArray)
            {
                numberArray[i] = Convert.ToInt32(s); // Parse into int array
                i++;
            }

            foreach (int k in numberArray)
            {
                conCheck += k; // sums up the numbers in the array
            }
            double sumOfArray = (numberArray.Length / 2 * ((2 * numberArray[0]) + ((numberArray.Length) - 1) * 1)); // arithmetric series in the postive
            double sumOfNegArray = (numberArray.Length / 2 * ((2 * numberArray[0]) + ((numberArray.Length) - 1) * (-1))); //arithmetric series in the negative
            Console.WriteLine(conCheck);
            Console.WriteLine("Pos series: " + sumOfArray);
            Console.WriteLine("Neg series: " + sumOfNegArray);

            if (conCheck == sumOfArray) // if consecutive in the positive
            {
                Console.WriteLine("Consecutive");
            }
            else if (conCheck == (sumOfNegArray)) // if consecutive in the negative
            {
                Console.WriteLine("Consecutive");
            }
            else if (conCheck != sumOfArray) // not consecutive 
            {
                Console.WriteLine("Not Consecutive");
            }

        }
    }
}
