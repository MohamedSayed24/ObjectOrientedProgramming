using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP6
{
    public class Duration
    {
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }

        public DateTime Datetime { get; } = DateTime.Now;
        public Duration() { }
        public Duration(int hours, int minutes, int seconeds)
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

        public static Duration operator +(Duration Left, Duration Right)
        {
            return new Duration
            {
                Hours = Left.Hours + Right.Hours ,
                Minutes = Left.Minutes + Right.Minutes,
                Seconds = Left.Seconds + Right.Seconds
            };

        }

        public static Duration operator + (Duration D , int Seconeds)
        {
          int totalSeconds = D.Hours  * 3600 + D.Minutes  * 60 + D.Seconds  + Seconeds;
          return new Duration(totalSeconds);

        }

        public static Duration operator +(int totalSeconds, Duration d)
        {
            return d + totalSeconds;
        }

        public static Duration operator ++(Duration d)
        {
            if (d is not null)
                ++d.Minutes;
            return d;
        }

        public static Duration operator --(Duration d)
        {
            if (d is not null)
                --d.Minutes;
            return d;
        }

        public static Duration operator -(Duration Left, Duration Right)
        {
            return new Duration
            {
                Hours = Left.Hours  - Right.Hours,
                Minutes = Left.Minutes - Right.Minutes,
                Seconds = Left.Seconds - Right.Seconds
            };

        }

        public static bool operator >(Duration Left, Duration Right)
        {
          if(Left.Hours == Right.Hours)
                return Left.Minutes > Right.Minutes;
          else if (Left.Minutes == Right.Minutes)
                return Left.Seconds > Right.Seconds;
            else
                return Left.Hours > Right.Hours;

        }

        public static bool operator <(Duration Left, Duration Right)
        {
            if (Left.Hours == Right.Hours)
                return Left.Minutes < Right.Minutes;
            else if (Left.Minutes == Right.Minutes)
                return Left.Seconds < Right.Seconds;
            else
                return Left.Hours < Right.Hours;

        }

        public static bool operator >=(Duration Left, Duration Right)
        {
            if (Left.Hours == Right.Hours)
                return Left.Minutes >= Right.Minutes;
            else if (Left.Minutes == Right.Minutes)
                return Left.Seconds >= Right.Seconds;
            else
                return Left.Hours >= Right.Hours;
        }

        public static bool operator <=(Duration Left, Duration Right)
        {
            if (Left.Hours == Right.Hours)
            
                return Left.Minutes <= Right.Minutes;
            
            else if (Left.Minutes == Right.Minutes)
            
                return Left.Seconds <= Right.Seconds;
            
            else
            
                return Left.Hours <= Right.Hours;
            
        }


        public static implicit operator bool(Duration d)
        {
            return (d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0);
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(2025,1,26, d.Hours, d.Minutes, d.Seconds);
        }


        public override bool Equals(object obj)
            { 
            if (obj is Duration)
            {
                var other = (Duration)obj;
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            }
            return false;
             }
    }
 }

