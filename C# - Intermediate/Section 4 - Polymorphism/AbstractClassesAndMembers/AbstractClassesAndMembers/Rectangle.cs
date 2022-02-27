namespace AbstractClassesAndMembers
{
    public class Rectangle : Shape
    {
        // forget to override
        public override void Draw()
        {
            System.Console.WriteLine("draw a rectangle"); // the abstract class reminds the user to implement the override method
        }
    }
}
