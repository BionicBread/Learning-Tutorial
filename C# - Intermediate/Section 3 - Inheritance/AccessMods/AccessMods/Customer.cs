using System;

namespace AccessMods
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            int rating = CalculateRating(credit: true);
            if (rating == 0)
                Console.WriteLine("NO");
            else
                Console.WriteLine("OK");
        }

        public int CalculateRating(bool credit) // Implementation logic should not be visible or accessible outside of the class.
        {                                       // IF THIS LOGIC IS CHANGED I.E ADD A PARAMETER bool credit 
            return 0;                           // IF it is public, there could be many calls in the main code that will break
        }                                       // IF it is private, only the method call from within this class will break. Fixing is easier.

        private int CalculateSomething()
        {
            return 0;
        }

        protected int CalculateStuff(int someVal) // protected method, adding int parameter will break the method calls in child 
        {
            return 0;
        }
    }                                       
}
