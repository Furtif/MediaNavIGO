using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNavIGO.Utils
{
    public static class SizeUtils
    {
        public enum SizeUnits
        {
            Byte, KB, MB, GB, TB, PB, EB, ZB, YB
        }

        public static string ToSize(this long value, SizeUnits unit)
        {
            return (value / (double)Math.Pow(1024, (long)unit)).ToString("0.00");
        }
    }
}
