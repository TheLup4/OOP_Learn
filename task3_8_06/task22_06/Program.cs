using System;
using System.Collections.Generic;

namespace task22_06
{
    class Program
    {
        delegate void Handler(int x, ref int res);//ДЕЛЕГАТ

        static int ForEach(List<int>list,int res, Handler h)
        {
            foreach (var item in list)
            {
                h(item, ref res);
            }

            return res;
        }

        static void CountNegative(int x,ref int res)
        {
            if (x < 0) res++;
        }
        static void CountPositive(int x, ref int res)
        {
            if (x >= 0) res++;
        }
        static void FindMin(int x, ref int res)
        {
            if (x < res) res = x;
        }
        static void FindMax(int x, ref int res)
        {
            if (x > res) res = x;
        }
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(-10, 10));
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //считаем отрицательные
            int countNeg = 0;
            countNeg = ForEach(list, countNeg, CountNegative);
            Console.WriteLine($"Количество отрицательных чисел = {countNeg}");
            Console.WriteLine();

            //считаем положительные
            int countPos = 0;
            countPos = ForEach(list, countPos,(int x,ref int res) =>{ if (x >= 0) res++; });
            Console.WriteLine($"Количество положительных чисел = {countPos}");
            Console.WriteLine();

            //минимальное значение
            int min = list[0];
            min = ForEach(list, min, FindMin);
            Console.WriteLine($"Минимальное число = {min}");
            Console.WriteLine();

            //максимальное значение
            int max = list[0];
            max = ForEach(list, min, FindMax);
            Console.WriteLine($"Минимальное число = {max}");


        }
    }
}
