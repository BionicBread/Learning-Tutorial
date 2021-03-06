using System;

namespace Sandbox1
{
    class BaseRole
    {
        // private fields means it cannot be accessed outside of the class
        private int _hitpoints;
        private string _gender;
        private int _height;
        private int _weight;
        private readonly Mount _mount = new Mount();

        //private DateTime _DOB;
        public BaseRole() // Default or parameterless constructor, the class fields do not contain any values when created but fields can be assigned provided there is a get set property
        {
                 
        }
        public BaseRole(int hitpoints, string gender, int height, int weight) // constructor overload means each person object must be created with these parameters
        {
            // each field is assigned with the input arguements
            this._hitpoints = hitpoints;
            this.Gender = gender;  // uses the property getter and setter 
            this._height = height;
            this._weight = weight;
            
            // but what if we enter gender as "GREG"? it is a string? 
        }

        public string Gender // we use properties to apply rules to the fields 
        {
            get // what is returned
            {
                return _gender;
            }

            set // what is set, we apply logic here. the input argument is value
            {
                if (value == "Male" || value == "male" || value =="m" || value == "M")
                {
                    _gender = "Male";
                }
                else if (value == "Female" || value == "female" || value == "f" || value == "F")
                {
                    _gender = "Female";
                }
                else
                    Console.WriteLine("Not a valid gender");
            } 
        }
        public virtual void Attack()
        {
            Console.WriteLine("smol hit logic");
        }

        // lets say all base roles have a mount. we can use composition for this as BaseRole HasA Mount
        // composition works in the constructor
        // easier to instansiate the object in the class field?
        // then call a method from that object (see below)?? 
        public void summonMount()
        {
            _mount.callMount("calls a mount");
        }

    }
}
