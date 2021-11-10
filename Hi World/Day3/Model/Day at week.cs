using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Model
{
    class Day_at_week
    {

        public static string DayOfWeek(int D)
        {

            if (D == 1)
                return "Pondeli";
            else if (D == 2)
                return "Utery";
            else if (D == 3)
                return "Streda";
            else if (D == 4)
                return "Ctvrtek";
            else if (D == 5)
                return "Patek";
            else if (D == 6)
                return "Sobota";
            else if (D == 7)
                return "Nedele";
            else
                return "Neexistujici den";
        }
        public static bool DayIsWeekend(int D)
        {

            if (D == 1)
                return true;
            else if (D == 2)
                return true;
            else if (D == 3)
                return true;
            else if (D == 4)
                return true;
            else if (D == 5)
                return true;
            else if (D == 6)
                return false;
            else if (D == 7)
                return false;
            else
                throw new Exception("index musi byt v rozsahu 1-7");
        }
    }
}
