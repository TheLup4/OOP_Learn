using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_8_06
{
    class InputData
    {
        public static int InputIntNumber(string msg="")
        {
           
            bool ok;
            int number;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out number);
                if (!ok)//ok==false
                {
                    Console.WriteLine("Ошибка введите целое число");
                }
            } while (!ok);
            return number;
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1. Заполнить коллекцию ДСЧ");
            Console.WriteLine("2. Вывести коллекцию");
            Console.WriteLine("3. Удалить элемент с заданным номером");
            Console.WriteLine("4. Удаление по ключу");
            Console.WriteLine("5. Добавить студента");
            Console.WriteLine("6. Добавить сотрудника");
            Console.WriteLine("7. Изменить объект коллекции");
            Console.WriteLine("8. Количество отличников");
            Console.WriteLine("9. Студенты, подлежащие отчислению");
            Console.WriteLine("10. Средняя зарплата сотрудников");
            Console.WriteLine("0. Выход"  );
        }
    }
}
