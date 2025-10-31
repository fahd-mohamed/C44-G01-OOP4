using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    internal class Duration
    {
        #region 1.Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

        #region Attributes
        private int hours;
        private int minutes;
        private int seconds;





        #endregion

        #region Properties


        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = value;
                while (seconds >= 60)
                {
                    minutes += seconds / 60;
                    seconds %= 60;
                }
                while (minutes >= 60)
                {
                    hours += minutes / 60;
                    minutes %= 60;
                }
            }
        }


        public int Minutes
        {
            get { return minutes; }
            set
            {
                minutes = value;
                while (minutes >= 60)
                {
                    hours += minutes / 60;
                    minutes %= 60;
                }
            }
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }




        #endregion

        #region Constructors
        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }

        public Duration(int _seconds)
        {
            Seconds = _seconds;
        }
        public Duration()
        {
            hours = minutes = seconds = 0;
        }
        #endregion


        #endregion



        #region 3.Define All Required Constructors to Produce this output:
        //  Duration D1 = new Duration(1, 10, 15);
        //  D1.ToString(); 
        //  Output: Hours: 1, Minutes :10, Seconds :15

        //  Duration D1 = new Duration(3600);
        //                D1.ToString(); 
        //Output: Hours: 1, Minutes :0, Seconds :0

        //Duration D2 = new Duration(7800);
        //        D2.ToString(); 
        //Output: Hours: 2, Minutes :10, Seconds :0

        //Duration D3 = new Duration(666);
        //        D3.ToString(); 
        //Output: Minutes :11, Seconds :6

        //Try in Main() --->

        #endregion

        #region 4.Implement All required Operators overloading to enable this Code

        #region D3=D1+D2
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = (left?.hours ?? 0) + (right?.hours ?? 0),
                Minutes = (left?.minutes ?? 0) + (right?.minutes ?? 0),
                Seconds = (left?.seconds ?? 0) + (right?.seconds ?? 0),

            };
        }

        #endregion

        #region D3=D1 + 7800
        public static Duration operator +(Duration left, int right)
        {
            return new Duration()
            {
                Hours = (left?.hours ?? 0) + (right / 3600),
                Minutes = (left?.minutes ?? 0) + (right % 3600 / 60),
                Seconds = (left?.seconds ?? 0) + (right % 3600 % 60),

            };
        }
        #endregion

        #region D3=666+D3
        public static Duration operator +(int left, Duration right)
        {
            return new Duration()
            {
                Hours = (left / 3600) + (right?.hours ?? 0),
                Minutes = (left % 3600 / 60) + (right?.minutes ?? 0),
                Seconds = (left % 3600 % 60) + (right?.seconds ?? 0)


            };
        }
        #endregion

        #region D3 = ++D1(Increase One Minute)
        public static Duration operator ++(Duration D)
        {
            return new Duration()
            {
                Hours = D?.Hours ?? 0,
                Minutes = (D?.minutes ?? 0) + 1,
                Seconds = (D?.seconds ?? 0)
            };
        }

        #endregion

        #region D3 = --D2(Decrease One Minute)
        public static Duration operator --(Duration D)
        {
            if (D.minutes == 0 && D.Hours != 0)
            {
                return new Duration()
                {
                    Hours = (D?.hours ?? 0) - 1,
                    Minutes = 59,
                    Seconds = D?.seconds ?? 0
                };
            }
            else
            {
                return new Duration()
                {
                    Hours = (D?.hours ?? 0),
                    Minutes = (D?.minutes ?? 0) - 1,
                    Seconds = (D?.seconds ?? 0)
                };
            }
        }
        #endregion

        #region If (D1>D2)
        public static bool operator >(Duration left, Duration right)
        {
            return (left.hours > right.hours) || (left.hours == right.hours && left.minutes > right.minutes
                ) || (left.hours == right.hours && left.minutes == right.minutes && left.seconds > right.seconds);
        }
        public static bool operator <(Duration left, Duration right)
        {
            return (left.hours < right.hours) || (left.hours == right.hours && left.minutes < right.minutes
                ) || (left.hours == right.hours && left.minutes == right.minutes && left.seconds < right.seconds);
        }
        #endregion

        #region D1= D1 -D2
        public static Duration operator -(Duration left, Duration right)
        {
            if (left > right)
            {
                int seconds;
                seconds = ((left.hours * 3600) + (left.minutes * 60) + left.seconds) -
                          ((right.hours * 3600) + (right.minutes * 60) + right.seconds);
                return new Duration(seconds);
            }
            else
                return new Duration();
        }

        #endregion

        #region If (D1<=D2)
        public static bool operator <=(Duration left, Duration right)
        {
            return ((left.hours * 3600) + (left.minutes * 60) + left.seconds)
                <= ((right.hours * 3600) + (right.minutes * 60) + right.seconds);
        }
        public static bool operator >=(Duration left, Duration right)
        {
            return ((left.hours * 3600) + (left.minutes * 60) + left.seconds)
                >= ((right.hours * 3600) + (right.minutes * 60) + right.seconds);
        }
        #endregion

        #region If (D1)
        public static bool operator true(Duration D)
        {
            return (D.Hours != 0 || D.minutes != 0 || D.seconds != 0);
        }
        public static bool operator false(Duration D)
        {
            return (D.Hours == 0 || D.minutes == 0 || D.seconds == 0);
        }
        #endregion

        #region DateTime Obj = (DateTime) D1
        public static explicit operator DateTime(Duration D)
        {
            return new DateTime(2025, 07, 28, D.Hours, D.Minutes, D.Seconds);
        }

        #endregion


        #endregion
    }
}

