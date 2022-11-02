using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_8_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            do
            {
                InputData.PrintMenu();
                answer = InputData.InputIntNumber();
                switch(answer)
                {
                    case 1://формирование коллекции с помощью ДСЧ
                        {
                            int length = InputData.InputIntNumber("Введите размер коллекции");
                            SystemManager.MakeRandomList(length);
                            Console.WriteLine("Коллекция сформирована");
                            break;
                        }
                    case 2://вывод коллекции
                        {
                            SystemManager.ShowList();
                            break;
                        }
                    case 3://удаление по номеру
                        {
                            int index = InputData.InputIntNumber("Введите номер элемента для удаления");
                            if(SystemManager.RemoveIndex(index))
                                Console.WriteLine("Элемент удален");
                            break;
                        }
                    case 4://удаление по ключу
                        {
                            Console.WriteLine("Введите имя ");
                            string name = Console.ReadLine();
                            int age = InputData.InputIntNumber("Введите возраст");
                            if (SystemManager.RemoveKey(name, age))
                                Console.WriteLine("Элемент удален");
                            break;
                        }
                    case 5://добавление студента 
                        {
                            Console.WriteLine("Добавляем студента");
                            Student s = new Student();
                            s.RandomInfo();
                            SystemManager.AddItem(s);
                            Console.WriteLine("Элемент добавлен");
                            break;
                        }
                    case 6://добавление сотрудника
                        {
                            Console.WriteLine("Добавляем сотрудника");
                            Employee e = new Employee();
                            e.RandomInfo();
                            SystemManager.AddItem(e);
                            Console.WriteLine("Элемент добавлен");
                            break;
                        }
                    case 7://изменение элемента
                        {
                            Console.WriteLine("Изменение объекта");
                            int index = InputData.InputIntNumber("Введите номер элемента для изменения");
                            index--;
                            Person p = SystemManager.info[index];
                            Console.Write("Меняем элемент "+p);
                            Console.WriteLine(", введите новый элемент");
                            p.ReadInfo();
                            Console.WriteLine("Элемент изменён");
                            //   p.Show();

                            break;
                        }
                    case 8: //Количество отличников
                        {
                            int count = SystemManager.ExcellentStudentsCount();
                            Console.WriteLine($"Количество отличников {count}");
                            break;

                        }
                    case 9: //Список двоичников
                        {
                            List < Student > badStudents= new List<Student>();
                            badStudents=SystemManager.BadStudentsCount();
                            Console.WriteLine($"Список двоечников");

                            if (badStudents.Count > 0)
                            {
                                Console.WriteLine("Отчисляем:");
                                foreach (var item in badStudents)
                                    item.Show();
                            }

                            else
                                Console.WriteLine("Таких нет");
                            break;
                        }

                    case 10: //Средняя зарплата
                        {
                            double avsal = SystemManager.AverageSalary();
                            Console.WriteLine($"средняя зарплата {avsal}");
                            Console.WriteLine($"средняя зарплата{SystemManager.AverageSalaryExtention()}");
                            break;

                        }
                }

            } while (answer!=0);
        }
    }
}
