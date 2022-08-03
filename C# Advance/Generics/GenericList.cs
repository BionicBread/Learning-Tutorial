using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T value) //add to generic list
        {

        }

        public T this[int index] //returns T at a given index
        {
            get { throw new NotImplementedException(); }
        }
    }
}
