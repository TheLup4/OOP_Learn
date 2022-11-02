using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_1Jun
{
    class Time
    {
        int hour, min;
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value > 0)
                    hour = value;
                else
                    hour = 0;
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value > 0)
                {
                    if (value < 60)
                        min = value;
                    else
                    {
                        min = value % 60;
                        hour += value / 100;
                    }
                }
                else
                    min = 0;
            }
        }

        public Time(int h,int m)
        {
            Hour = h;
            Min = m;
        }
        public Time()
        {
            Hour = 0;
            Min = 0;
        }
        public void Show()
        {
            Console.WriteLine($"{hour}ч. {min}мин.");
        }

        public void Init()
        {
            Hour = Program.InputIntTime("Введите часы");
            Min = Program.InputIntTime("Введите минуты");
        }

        public static Time Sum(Time t1, Time t2)
        {
            Time t = new Time();
            t.Hour = t1.Hour + t2.Hour;
            t.Min = t1.Min + t2.Min;
            return t;
        }
        public static Time operator ++(Time t)
        {
            t.Min++;
            return t;
        }
        public static Time operator --(Time t)
        {
            t.Min--;
            return t;
        }
        public static Time operator +(Time t1, Time t2)
        {
            Time temp = new Time();
            temp.Hour = t1.Hour + t2.Hour;
            temp.Min = t1.Min + t2.Min;
            return temp;
        }
        public static Time operator +(Time t1, int min)
        {
            Time temp = new Time();
            temp.Hour = t1.Hour;
            temp.Min = t1.Min + min;
            return temp;
        }
        public static Time operator +(int min, Time t1)
        {
            Time temp = new Time();
            temp.Hour = t1.Hour;
            temp.Min = t1.Min + min;
            return temp;
        }

        public static Time operator -(Time t1, Time t2)
        {
            int temp1.Rub * 100 + m1.Kop + m2.Rub * 100 + m2.Kop

            return temp;
        }
        public static Time operator -(Time t1, int min)
        {
            Time temp = new Time();
            temp.Hour = t1.Hour;
            
            if (min > t1.Min)
            {
                if (min - t1.Min > 0)
                    temp.Hour--;
                temp.Min = 60 - (min - t1.Min);
            }
            else
                temp.Min = t1.Min - min;
            return temp;
        }
        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Hour == t2.Hour && t1.Min == t2.Min;
        }
        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1.Hour == t2.Hour && t1.Min == t2.Min);
        }

    }
}
