using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Требуется: Создать класс Employee. В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, 
             * и инициализирует поля, соответствующие фамилии и имени сотрудника. 
             * Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор. 
             * Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор. 
             */

            Employee employee = new Employee("John", "Smith");
            employee.Expirience = 1;
            employee.Position = "manager";
            employee.ShowSalaryInfo();

            Employee employee1 = new Employee("Mia", "Linamo");
            employee1.Expirience = 4;
            employee1.Position = "developer";
            employee1.ShowSalaryInfo();
            
            Employee employee2 = new Employee("Bill", "Wong");
            employee2.Expirience = 12;
            employee2.Position = "director";
            employee2.ShowSalaryInfo();
            
            Console.ReadKey();

        }
    }
}
