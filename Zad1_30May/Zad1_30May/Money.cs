using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_30May
{
    class Money
    {
        int rub,kop;

        public int Rub
        {
            get
            {
                return rub;
            }
            set
            {
                if (value > 0)
                    rub = value;
                else
                    rub = 0;
            }
        }
        public int Kop
        {
            get
            {
                return kop;
            }
            set
            {
                if (value > 0)
                {
                    if (value < 100)
                        kop = value;
                    else
                    {
                        kop = value % 100;
                        rub += value / 100;
                    }    
                }
                else
                    kop = 0;
            }
        }


        public Money(int r, int k)
        {
            Rub = r;
            Kop = k;
        }
        public Money()
        {
            Rub = 0;
            Kop = 0;
        }

        public void Show()
        {
            Console.WriteLine($"{rub}р. {kop}коп.");
        }

        public void Init()
        {
            Rub = Program.InputIntNumber("Введите рубли");
            Kop = Program.InputIntNumber("Введите копейки");

        }

        public static Money Sum(Money m1, Money m2)
        {
            //int temp = m1.Rub * 100 + m1.Kop + m2.Rub * 100 + m2.Kop;
            //Money m = new Money(0, temp);
            //return m;
            Money m = new Money();
            m.Rub = m1.Rub + m2.Rub;
            m.Kop = m1.Kop + m2.Kop;
            return m;
        }

        public Money Sum1(Money m2)
        {
            int temp = m2.Rub * 100 + m2.Kop + Rub * 100 + Kop;
            Money m = new Money(0, temp);
            return m;
        }
        public static Money operator ++(Money m)
        {
            m.Kop++;
            return m;
        }
        public static Money operator +(Money m1, Money m2)
        {
            Money temp = new Money();
            temp.Rub = m1.Rub + m2.Rub;
            temp.Kop = m1.Kop + m2.Kop;
            return temp;
        }

        public static Money operator +(Money m1, int kop)
        {
            Money temp = new Money();
            temp.Rub = m1.Rub;
            temp.Kop = m1.Kop + kop;
            return temp;
        }
        public static Money operator +( int kop, Money m1)
        {
            Money temp = new Money();
            temp.Rub = m1.Rub;
            temp.Kop = m1.Kop + kop;
            return temp;
        }

        public static bool operator ==(Money m1, Money m2)
        {
            //if (m1.Rub == m2.Rub && m1.Kop == m2.Kop)
            //    return true;
            //else
            //    return false;
            return m1.Rub == m2.Rub && m1.Kop == m2.Kop;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            //if (m1.Rub == m2.Rub && m1.Kop == m2.Kop)
            //    return false;
            //else
            //    return true;
            return !(m1.Rub == m2.Rub && m1.Kop == m2.Kop);
        }

    }
}
