using System;

namespace Properties
{
    public class Person
    {
        private DateTime _birthdate;

        public DateTime BirthDate              //example of propertes
        {
            get { return _birthdate; }          // properties encapsulated in a getter and setter keyword block
            set { _birthdate = value; }


        } 
    }
}
