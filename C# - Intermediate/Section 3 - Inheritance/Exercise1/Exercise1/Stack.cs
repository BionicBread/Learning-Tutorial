using System;
using System.Collections;
using System.Collections.Generic;
namespace Exercise1
{
    public class Stack
    {
        // contructor should init an array list or generic list
        private ArrayList list = new ArrayList();  //initiate the array
        public void Push(Object obj) // stores the given object at the top of the stack
        {
            if (obj != null)
                list.Add(obj);
            else
                throw new NullReferenceException();
        }

        public void Clear() // clears the stack
        {
            list.Clear();
            
        }

        public Object Pop() // returns the first element in the stack
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int index = list.Count - 1;
            var top = list[index];
            list.Remove(list[index]);
            return top;
      
        }     
    }
}
