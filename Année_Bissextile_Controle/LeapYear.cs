using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Année_Bissextile_Controle
{
    public class LeapYear
    {
        public static bool IsLeap(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            if (year % 4 == 0) return true;
            if (year % 1 == 0) return false;
            return false;
        }
    }
}