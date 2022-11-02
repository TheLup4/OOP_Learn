using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_8_06
{
    class Employee:Person
    {
        public string Department { get; set; }//подразделение
        protected int salary;//зарплата
        public int Salary
        {
            get => salary;
            set
            {
                if (value >= 0 && value <= 100000)
                    salary = value;
                else
                    salary = 0;
            }
        }

        public Employee() : base()
        {
            Department = "";
            Salary = 0;
        }

        public Employee(string name, int age, string dep, int salary)
            : base(name, age)
        {
            Department = dep;
            Salary = salary;
        }

        //методы
        public override void Show()
        {
            Console.WriteLine($"{Name}, {Age}, " +
                $"департамент {Department}, зарплата {Salary}");
        }

        public override string ToString()
        {
            return base.ToString() + $", департамент {Department}, зарплата {Salary}";
        }

        public override bool Equals(object obj)
        {
            Employee p = obj as Employee;
            if (p != null)
            {
                return this.Name == p.Name && this.Age == p.Age
                    && this.Department == p.Department && this.Salary == p.Salary;
            }
            else
                return false;
        }

        public override void ReadInfo()
        {
            base.ReadInfo();
            Console.WriteLine("введите департамент");
            Department = Console.ReadLine();
            Salary = InputData.InputIntNumber("Введите зарплату");
        }

        public override void RandomInfo()
        {
            base.RandomInfo();
            Department = rnd.Next(1, 10).ToString();
            Salary = rnd.Next(12000, 100000);
        }
    }
}

