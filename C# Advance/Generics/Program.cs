namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new GenericList<int>(); //the data type is defined in the <> brackets
            //numbers.Add(3); //the add method is now looking for int type

            //// same generic list can be used to store different data type i.e list of objects

            //var stringList = new GenericList<string>();
            //stringList.Add("string"); // string data type is accepted 

            //NormalList testObj = new NormalList();
            //var endList = testObj.CreateList();

            //System.Console.WriteLine(endList.Count);

            //var dictionary = new GenericDictionary<string, Book>(); // key with type string and values with type Book 
            //dictionary.Add("one", new Book());

            var number = new Nullable<int>();
            System.Console.WriteLine("Has Value? " + number.HasValue);
            System.Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
