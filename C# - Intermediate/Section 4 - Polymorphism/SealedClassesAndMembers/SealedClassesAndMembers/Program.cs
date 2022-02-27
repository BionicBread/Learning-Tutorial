using System;

namespace SealedClassesAndMembers
{
    public class Shape
    {
        public int someValue { get; set; }
        public virtual void Draw()
        {
            someValue = 1;
        }
    }

    public sealed class Circle : Shape
    {
        //circle is child of parent but as it is sealed it cannot be a super class (parent to other child classes)
        public sealed override void Draw()
        {

        }
    }

    public class TestClass : String
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            // 
            // prevents overriding (applyed to methods) and derivation (appied to class) from parent 
            // sealed classes are slightly faster because of run time optimization
            // EXAMPLE

            
        }
    }
}
