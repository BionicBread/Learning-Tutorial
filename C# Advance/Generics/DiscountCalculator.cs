namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        // There are different types of constraints 
        // where T : IComparable << constrained to interface
        // where T : Product << constrained to a class
        // where T : struct << constrained to a value type
        // where T : class << constrained to a reference type
        // where T : new() << object with a default constructor

        // example of a constraint to class

        public float CalculateDiscount(TProduct product) // TProduct inherits from the Product class so product will have access to the get set attributes or methods
        {
            return product.Price;
        }
    }
}
