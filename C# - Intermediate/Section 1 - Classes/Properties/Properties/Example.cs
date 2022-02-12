using System;

namespace Properties
{
    public class Example
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }     // Auto implemented property shortcut "prop" code snippet
                                                            // Make "set" private will require a constructor to set it within the class
        public Example(DateTime birthdate)
        {
            BirthDate = birthdate;
        }
        
        public int Age
        {
            get
            {
                TimeSpan timeSpan = DateTime.Today - BirthDate;
                int years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
