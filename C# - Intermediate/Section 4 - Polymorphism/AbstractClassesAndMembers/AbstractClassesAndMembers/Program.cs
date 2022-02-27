namespace AbstractClassesAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract modifier
            // Rules about abstract classes and member
            // var shape = new Shape(); cannot create and object of an abstract class

            /// base object called stream
            /// View >> object viewer 
            /// shows all the .NET classes
            Circle circle = new Circle(); // draw a circle
            circle.Draw();

            Rectangle rectangle = new Rectangle(); // draw a rectange (no override)
            rectangle.Draw();   // this method is inherited from Shape class as there is no methods in rectangle. To avoid this, the "abstract" modifier can help.
                                // 

        }
    }
}
