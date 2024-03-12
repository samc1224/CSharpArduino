using System;

namespace CSharpArduino
{
    public class TimeCounter
    {
        public static DateTime startTime;

        public long millis()
        {
            DateTime endTime = DateTime.Now;
            double diff = (endTime - startTime).TotalMilliseconds;
            return Convert.ToUInt32(diff);
        }

        public long micros()
        {
            DateTime endTime = DateTime.Now;
            double diff = (endTime - startTime).TotalMilliseconds;
            return Convert.ToUInt32(diff);
        }
    }
}
