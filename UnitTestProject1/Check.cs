using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Check
    {
        int s;
        public int Add()
        {
            s = 5 + 5;  
            return s;
        }
        public int Sub()
        {
            s = 5 - 3;
            return s;
        }
        public int Multiply()
        {
            s = 5 * 3;
            return s;
        }
        public bool Div()
        {
            bool s = 5 < 7;
            return s;
        }

    }
}
