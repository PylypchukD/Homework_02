using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Требуется: Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
             * Поле дата заполнения анкеты должно быть проинициализировано только один раз 
             * (при создании экземпляра данного класса) без возможности его дальнейшего изменения. 
             * Реализуйте вывод на экран информации о пользователе.
             */

            User user = new User("Грегорий", "Иванов", "NinjaMonkey321", 15);
            Console.WriteLine($"Пользователь создан. Дата создания: {user.DateCreate}");

            Console.ReadKey();

        }
    }
}
