using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_8_06
{
    class Person:IComparable<Person>
    {
        protected static string[] names = { "Иван", "Алиса", "Мария", "Сергей",
            "Кирилл", "Елена", "Дмитрий", "Светлана","Вера", "Виктор","Ирина",
            "Никита","Егор","Анна","Анастасия" };
        protected static Random rnd = new Random();
        public string Name { get; set; }
        protected int age;
        public int Age
        {
            get => age;
            set
            {
                if (value >= 0 && value < 100)
                    age = value;
                else
                    age = 18;
            }
        }

        public Person()
        {
            Name = "NoName";
            Age = 18;
        }
        public Person(string name)
        {
            Name = name;
            Age = 18;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //методы
        public virtual void Show()
        {
            Console.WriteLine($"{Name}, {Age}");
        }

        public int CompareTo(Person other)
        {
            return String.Compare(this.Name, other.Name);
        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (p != null)
            {
                return this.Name == p.Name && this.Age == p.Age;
            }
            else
                return false;
        }

        public virtual void ReadInfo()
        {
            Console.WriteLine("ведите имя");
            Name = Console.ReadLine();
            Age = InputData.InputIntNumber("Введите возраст");
        }

        public virtual void RandomInfo()
        {
            Name = names[rnd.Next(names.Length)];
            Age = rnd.Next(18, 60);
        }
    }
}
