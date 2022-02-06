using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public static class ASCIIMod
    {
        public static byte[] ChangeToASCII(string input, List<int> lengthList)
        {
           

            
            byte[] asciiConvert = Encoding.ASCII.GetBytes(input.ToLower().Trim());
            int AccumLength = 0;
            for  (int n = 0; n <= lengthList.Count; n++)
            {
               
                if (n >= 1 && n != lengthList.Count)
                {
                    //asciiConvert[lengthList[n - 1]] = ((byte)((byte)asciiConvert[lengthList[n - 1]] + 32));
                    
                    
                    asciiConvert[AccumLength] -= 32;
                    AccumLength += lengthList.ElementAt(n);
                }
                else if (n == lengthList.Count)
                {
                    //asciiConvert[lengthList[n - 1]] = ((byte)((byte)asciiConvert[lengthList[n - 1]] + 32));


                    asciiConvert[AccumLength - 1] -= 0;
                    AccumLength += lengthList.ElementAt(n-1);
                }
                else if (n == 0)
                {
                    //asciiConvert[lengthList[n]] = ((byte)((byte)asciiConvert[lengthList[n]] + 32));
                    AccumLength += lengthList.ElementAt(n);
                    asciiConvert[n] -= 32;
                }
            }

            return asciiConvert;
        }
        public static string ChangeToString(byte[] input)
        {
            string stringConvert = Encoding.UTF8.GetString(input);
            //string stringConvert1 = String.Join(stringConvert, ' ');
            

            return stringConvert;
        }

        public static List<int> FindLength(string input)
        {

            List<int> lengthOfEachWord = new List<int>();
            string[] arrayInputs = input.Split(' ');
            //int[] arrayOfWords = Array.ConvertAll(arrayInputs, arrayInputs => int.Parse(arrayInputs));

            for (int i = 0; i <= arrayInputs.Length - 1; i++)
            {
                lengthOfEachWord.Add(arrayInputs[i].Length);
                
            }

            return lengthOfEachWord;
        }
    }
}
