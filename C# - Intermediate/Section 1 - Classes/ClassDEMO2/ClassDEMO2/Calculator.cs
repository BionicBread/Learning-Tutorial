namespace ClassDEMO2
{
    partial class Program
    {
        public class Calculator
        {
            public int Add(params int[] numbers) // NOTE there is a better way to write this using the LINQ namespace
            {
                var sum = 0;
                foreach (int n in numbers)
                {
                    sum += n;
                }

                return sum;
            }
        }
    }
}
