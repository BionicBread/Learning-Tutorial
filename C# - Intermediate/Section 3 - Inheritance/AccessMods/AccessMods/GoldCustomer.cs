namespace AccessMods
{
    partial class Program
    {
        public class GoldCustomer : Customer   // Inherit Customer class
        {
            public void OfferVoucher()
            {
                this.CalculateStuff(); // protected methods can be accessed from child class. this is a dependancy to another class. if parent method is changed child method breaks
            }
        }
    }
}
