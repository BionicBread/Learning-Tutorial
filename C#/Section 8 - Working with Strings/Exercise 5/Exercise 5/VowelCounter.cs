using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    public static class VowelCounter
    {
        public static int CounterOfVowels(string input)
        {
            int numberOfVowels = 0;
            List<char> charMod = new List<char>();
            foreach (char c in input)
            {

                charMod.Add(c);
            }

            foreach (char s in charMod)
            {
                if (s == ('a') || s == ('e') || s == ('o') || s == ('u') || s == ('i'))
                {
                    numberOfVowels++;
                }

            }
            return numberOfVowels;
        }
    }
}
