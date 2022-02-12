using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();  // create the object 
            cookie["name"] = "someName";    // store the key value pair using the indexer. HERE "name" is the key and "someName" is the value
            Console.WriteLine(cookie["name"]); // read from the cookie object
        }
    }
}
