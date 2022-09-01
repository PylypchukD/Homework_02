using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Employee
    {
        readonly string name, surname;
        int expirience;
        string position;

        public int Expirience {
            get
            {
                return expirience;
            } 
            set
            {
                if (value > 0)
                    expirience = value;
            }
        }

        public string Position { get 
            { 
                return position;
            } set 
            {
                if (!string.IsNullOrEmpty(value))
                    position = value;
                else
                    position = "должность не определена";
            } 
        }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void ShowSalaryInfo()
        {
            double salary;
            if (position == "manager")
            {
                salary = 2500;
            }
            else if (position == "director")
            {
                salary = 5000;
            }
            else if (position == "developer")
            {
                salary = 4000;
            }
            else
            {
                salary = 0;
            }

            double salaryOut = salary;
            if (expirience > 5)
            {
                salaryOut *= 1.2;
            }
            else if (expirience > 3)
            {
                salaryOut *= 1.1;
            }
            else if (expirience > 1)
            {
                salaryOut *= 1.05;
            }
            else
            {
                salaryOut *= 1;
            }

            Console.WriteLine($"Сотрудник: {name} {surname}, {position}\nБазовая ставка: {salary}\nЗарплата с учетом стажа: {salaryOut}, налог 20%: {salaryOut * 0.2}\n");

        }

    }
}
