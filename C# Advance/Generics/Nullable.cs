namespace Generics
{
    // There are different types of constraints 
    // where T : IComparable << constrained to interface
    // where T : Product << constrained to a class
    // where T : struct << constrained to a value type
    // where T : class << constrained to a reference type
    // where T : new() << object with a default constructor

    // example of a constraint to value type
    public class Nullable<T> where T : struct
    {
        // Value types cannot be null i.e an int must be 0, 0.1 etc
        // This class can be used to give value types the ability to be nullable

        private object _value;
        public Nullable()
        {

        }
        public Nullable(T value) // constructor that initialises the private object to value
        {
            _value = value;
        }

        public bool HasValue // property, object has value return true otherwise false
        {
            get { return _value != null; } // if _value has value then return true
        }

        public T GetValueOrDefault() //generic method 
        {
            if (HasValue) 
                return (T)_value; // cast _value 
            return default(T); //default keyword returns the default state for a given type
        }
    }
}
