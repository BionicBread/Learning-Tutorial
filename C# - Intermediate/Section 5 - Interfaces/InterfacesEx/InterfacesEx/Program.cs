using System;

namespace InterfacesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaces
            // enhances testability
            // What is an interface!
            Order chrisOrder = new Order();
            chrisOrder.TotalCost = 100f;
            chrisOrder.IsShipped = true;

            Console.WriteLine("Has the order been shipped?: {0} \nTotal cost of order?: £{1}", chrisOrder.IsShipped, chrisOrder.TotalCost);
            
        }
    }
}
