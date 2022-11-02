using System;

namespace Zad1_30May
{
    class Program
    {
       public static int InputIntNumber(string message) 
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
            //int number1,number2;
            //string message;
            //message = "Введите 1 число";
            //number1=InputIntNumber(message);
            //message = "Введите 2 число";
            //number2 =InputIntNumber(message);
            //Console.WriteLine($"Сумма чисел {number1} + {number2} = {number1+number2}");

            Money m = new Money();
            m.Rub = 100;
            m.Kop = 1150;
            m.Show();
            Money m2=new Money(10, 132);
            m2.Show();

            Money m3 = new Money();
            m3.Init();
            m3.Show();

            Console.WriteLine("Считаем сумму static");
            Money res = Money.Sum(m, m2);
            res.Show();
            Console.WriteLine("Считаем сумму not static");
            Money res2 = m.Sum1(m2);
            res2.Show();

            Console.WriteLine(" Перегрузка операций") ;
            Console.WriteLine("Инкремент");
            m3++;
            m3.Show();
            m3++;
            m3.Show();

            Console.WriteLine("Сложение");
            Money m4 = m3 + m2;
            m4.Show();

            Console.WriteLine("Прибавление копеек");
            Money m5 = m4+100;
            m5.Show();
            Money m6 = 100 + m4;
            m6.Show();

            Console.WriteLine("операции == и !=");
            Console.WriteLine(m5==m6);
            Console.WriteLine(m5 == m4);


        }
    }
}
