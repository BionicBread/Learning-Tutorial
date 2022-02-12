using System;
using System.Collections.Generic;
namespace Indexers
{
    public class HttpCookie
    {
        // data pairs can be stored in a "dictionary" it's a data type in generic.
        // uses "hash table" by looking up items by a key
        // a list looks up items by index

        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>(); // type in between the angled brackets specifics the type of the dictionary 
                                                                                                    // <string, string> key is type string and the values is type string

        // Two options for _dictionary: initialise in a constructor (below) or initialise as a field (above)

        //public HttpCookie()
        //{
        //    _dictionary = new Dictionary<string, string>(); // new keyword creates the dictionary
        //}
        ///////////////IF USING CONSTRUCTOR, BE SURE THIS IS THE DEFAULT SO IT CREATES THE DICTIONARY/////////////////////////////////
        ///

        //// Declaring an index is same as properties
        public string this[string key]     // instead "this" keyword is used
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value; // readonly is added to the dictionary field to stop overwrite
            }
            
        }
        public DateTime Expire { get; set; }
        ///////////////////////////////////////////END////////////////////////////////////////////////
        public string SetItem(string key, string value) ////////// Place holder methods DOESNT ACTUALLY WORK
        {
            return value;
        }

        public string GetItem(string key)  ////////// Place holder methods DOESNT ACTUALLY WORK
        {
            return key;
        }
    }
}
