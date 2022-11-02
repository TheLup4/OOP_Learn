using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_8_06
{
    class Student :Person
    {
        public string Group { get; set; }
        protected int rating;
        public int Rating
        {
            get => rating;
            set
            {
                if (value >= 0 && value <= 10)
                    rating = value;
                else
                    rating = 0;
            }
        }

        public Student():base()
        {
            Group = "";
            Rating = 0;
        }
       
        public Student(string name, int age, string group, int rating)
            :base(name, age)
        {
            Group = group;
            Rating = rating;
        }

        //методы
        public override void Show()
        {
            Console.WriteLine($"{Name}, {Age}, " +
                $"группа {Group}, рейтинг {Rating}");
        }

        public override string ToString()
        {
            return base.ToString() + $", группа {Group}, рейтинг {Rating}";
        }

        public override bool Equals(object obj)
        {
            Student p = obj as Student;
            if (p != null)
            {
                return this.Name == p.Name && this.Age == p.Age 
                    &&this.Group==p.Group&&this.Rating==p.Rating;
            }
            else
                return false;
        }

        public override void ReadInfo()
        {
            base.ReadInfo();
            Console.WriteLine("введите группу");
            Group = Console.ReadLine();
            Rating = InputData.InputIntNumber("Введите рейтинг");
        }

        public override void RandomInfo()
        {
            base.RandomInfo();
            Group = rnd.Next(1, 10).ToString();
            Rating = rnd.Next(1, 10);
        }
    }
}
