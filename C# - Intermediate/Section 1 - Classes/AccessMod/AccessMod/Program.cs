using System;

namespace AccessMod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access modifiers
            // Public
            // Private
            // Protected
            // Internal 
            // Protected Internal

            // Access modifiers are used to protect sensitive information in the program
            // One example is creating a private field in a class or a readonly list 

            // Cornerstones of OOP
            // Encapsulation / information hiding
            // Inheritance
            // Polymorphism

            /////// ENCAPSULATION ////////
            //////// ROLES /////////////
            /// Think of each class having different roles and these roles only need certain information
            /// - Define fields as private
            /// - Provide getter/setter methods are public
            /// 
            Person person = new Person();
            person.SetBirthDate(new DateTime(2022, 02, 11));
            Console.WriteLine(person.GetBirthDate());
        }
        public class Person
        {
            //private string _name;                // naming convention for fields is to use an _ before the name and follow the camel case
            //public void SetName(string name)
            //{
            //    if (!String.IsNullOrEmpty(name))
            //    {
            //        this._name = name;
            //    }

            //}
            //public string GetName()
            //{
            //    return _name;
            //}

            private DateTime _birthdate;            // Fields are internals 
                                                    // OOP is about the behaviour of the class 
                                                    // information about the internals / implementation details should be hidden

            public void SetBirthDate(DateTime birthdate)
            {
               _birthdate = birthdate;
            }
            public DateTime GetBirthDate()
            {
                return _birthdate;
            }

        }
    }
}
