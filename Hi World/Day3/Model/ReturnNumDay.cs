using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Model
{
    class ReturnNumDay
    {
        public static int NumDay(string n)
        {
            n = n.ToLower();

            if (n == "pondeli")
                return 1;
            else if (n == "utery")
                return 2;
            else if (n == "streda")
                return 3;
            else if (n == "ctvrtek")
                return 4;
            else if (n == "patek")
                return 5;
            else if (n == "sobota")
                return 6;
            else if (n == "nedele")
                return 7;
            else
                return 0;
        }
    }
}
