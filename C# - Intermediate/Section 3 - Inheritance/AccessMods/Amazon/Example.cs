using System;

namespace Amazon
{
    partial class Example
    {

        public class CustomerMoney
        {
            public int BankAccAmount { get; set; }
            public int BankAccID { get; set; }
            public int BankInterest { get; set; }

            public void CreditRating()
            {
                CreditCalculator calculator = new CreditCalculator();  //NOT good practice to instansiate a new object inside a method
                int Rating = calculator.Calculate(this);               // creates coupling
                Console.WriteLine("CREDIT");
            }
        }
    }
}
