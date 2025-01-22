using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingC_
{
    public class Duration
    {
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }
        public Duration(int hours , int minutes , int seconeds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconeds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600; 
            totalSeconds %= 3600;  

            Minutes = totalSeconds / 60;  
            Seconds = totalSeconds % 60;  
        }

        
        public Duration(double seconds)
        {
            Minutes = (int)(seconds / 60);  
            Seconds = (int)(seconds % 60);  
        }
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours} , Minutes: {Minutes} , Seconses: {Seconds}";

            else if (Minutes > 0) return $"Minutes: {Minutes} , Seconses: {Seconds}";

            else
                return $"Seconses : {Seconds}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
