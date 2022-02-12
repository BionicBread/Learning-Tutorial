using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDEMO
{
    static class OutClass
    {
        public static void OutMethod(out int result)
        {
            result = 1;
        }
    }
}
