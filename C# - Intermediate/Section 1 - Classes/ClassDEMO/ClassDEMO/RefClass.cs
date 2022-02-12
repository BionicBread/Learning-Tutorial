using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDEMO
{
    static class RefClass
    {
        public static void MyMethod(int a)
        {
            a += 2;    
        }
        public static void MyRefMethod(ref int a)
        {
            a += 2;
        }
    }
}
