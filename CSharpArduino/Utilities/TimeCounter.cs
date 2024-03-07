using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArduino
{
    static class TimeCounter
    {
        public static DateTime startTime;

        public static long millis()
        {
            DateTime endTime = DateTime.Now;
            double diff = (endTime - startTime).TotalMilliseconds;
            return Convert.ToUInt32(diff);
        }
    }
}
