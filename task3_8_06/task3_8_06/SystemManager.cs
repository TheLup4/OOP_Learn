using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_8_06
{
    
    class SystemManager
    {
        public static List<Person> info = new List<Person>();

        /// <summary>
        /// заполнение коллекции датчиком случайных чисел
        /// </summary>
        /// <param name="length"></param>
        public static void MakeRandomList(int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    Student s = new Student();
                    s.RandomInfo();
                    info.Add(s);
                }
                else
                {
                    Employee e = new Employee();
                    e.RandomInfo();
                    info.Add(e);
                }
            }
        }

        public static void ShowList()
        {
            int number = 1;
            if(IsEmpty())
            {
                Console.WriteLine("Коллекция пустая");
            }
            else
            foreach (var item in info)
            {
                Console.WriteLine(number+" : "+item.ToString());
                    number++;
            }
        }

        public static bool IsEmpty()
        {          
            return info.Count == 0;           
        }
        public static bool RemoveIndex(int index)
        { 
            if(IsEmpty())
            {
                Console.WriteLine("Коллекция пустая, удаление не возможно");
                return false;
            }
            if(index-1<0||index-1>=info.Count)
            {
                Console.WriteLine("Элемент не существует");
                return false;
            }
            info.RemoveAt(index-1);
            return true;
        }

        public static int FindKey(Person p )
        {
            int number = -1;
            foreach (var item in info)
            {
                number++;
                if (item.Name==p.Name&&item.Age==p.Age)
                    return number;               
            }

            return -1;
        }
        public static bool RemoveKey(string name, int age)
        {
            bool ok;
            Person p = new Person(name, age);
            int pos = FindKey(p)+1;
            if (pos >= 0)
            {
                ok = RemoveIndex(pos);
            }
            else
                ok = false;
            return ok;
        }

        public static void AddItem(Person p)
        {
            info.Add(p);
        }

        //Количество отличников
        public static int ExcellentStudentsCount()
        {
            int count = 0;
            foreach (var item in info)
            {
                if (item is Student)
                    if (((Student)item).Rating >= 8)
                        count++;
                
            }
            return count;
        }
        public static List<Student> BadStudentsCount()
        {
            List<Student> temp = new List<Student>();
            foreach (var item in info)
            {
                if (item is Student)
                    if (((Student)item).Rating <= 4)
                        temp.Add((Student)item);

            }
            return temp;
        }
        public static double AverageSalary()
        {
            double summ = 0;
            int count = 0;
            foreach (var item in info)
            {
                if (item is Employee e)
                {
                    summ+=(double)e.Salary;
                    count++;
                }
            }
            return summ / count;
        }

        public static double AverageSalaryExtention()
        {
            return info.Where(x => x is Employee).Average(x => ((Employee)x).Salary);
        }
    }
}
