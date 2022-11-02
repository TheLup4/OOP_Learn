using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_1Jun
{
    class Program
    {
        public static int InputIntTime(string message)
        {
            Console.WriteLine(message);
            int number;
            string buf = Console.ReadLine();
            number = Convert.ToInt32(buf);
            Console.WriteLine();
            return number;
        }
        static void Main(string[] args)
        {
            Time t = new Time();
            t.Init();
            t.Show();
            Time t2 = new Time(12, 23);
            t2.Show();
            Console.WriteLine("Считаем сумму static");
            Time res = Time.Sum(t, t2);
            res.Show();
            Console.WriteLine(" Перегрузка операций");
            Console.WriteLine("Инкремент");
            t++;
            t.Show();
            ++t;
            t.Show();
            Console.WriteLine("Дикремент");
            t--;
            t.Show();
            --t;
            t.Show();
            Console.WriteLine("Сложение");
            Time t3 = t + t2;
            t3.Show();
            Console.WriteLine("Прибавление минут");
            Time t4 = t3 + 20;
            t4.Show();
            Time t5 = 20 + t4;
            t5.Show();
            Console.WriteLine("Вычитание");
            Time t6 = t5 - t;
            t6.Show();
            Console.WriteLine("Вычитание минут");
            Time t7 = t6 - 62;
            t7.Show();
            Console.WriteLine("операции == и !=");
            Console.WriteLine(t5 != t6);
            Time t8 = t;
            Console.WriteLine(t == t8);


        }
    }
}
