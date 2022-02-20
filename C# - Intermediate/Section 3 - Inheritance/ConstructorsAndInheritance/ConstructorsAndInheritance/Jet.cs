namespace ConstructorsAndInheritance
{
    public class Jet : Plane
    {
        //public Car (string registrationNumber) /////// you cannot call a private member of a parent class for use in a child constructor
        //{
        //    _registationNumber = registationNumber;  //// the parent class could be defined as a protected class and this would work
        //}                                             /// However Vehicle class private members being accessed outside of the class means encapuslation is broken

        /// INSTEAD ///
        /// use the base keyword
        /// similar to : this (include the default ctor in any overloaded versions) 
        public Jet (string registrationNumber) // the received parameter 
            : base(registrationNumber)          // passed through to the base constructor
        {
            // some logic only for Car class
        }
    }
}
