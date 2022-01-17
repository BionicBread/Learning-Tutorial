namespace Exercise_7
{
    public class SimpleMaths
    {
        public static int ApplyFrac(int inputNum)
        {
            int outputNum = 0;
            int b = inputNum;
            int[] array = new int[inputNum]; 

            for (var i=inputNum; i > 0; i--)
            {
                array[i] = i; // populate the array with input number until 0
                
            }

           
            return outputNum;

        }
    }
}
