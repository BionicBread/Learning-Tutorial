using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Example
    {
        static void ExampleIndex()
        {
            var cookie = new HttpCookie();
            cookie.Expire = DateTime.Today.AddDays(5);

            cookie["name"] = "someName"; //////// indexer code
            cookie.SetItem("name", "myName"); ////// alternatively, a method could be made in the HttpCookie class. METHOD IS BROKEN BTW

            var name = cookie["name"]; ///////// indexer code
            var name1 = cookie.GetItem("name"); /////////////// same outcome but using a method (this is bad, don't do this) 
        }
    }
}
