using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application.
             * Требуется: Создать класс Invoice. В теле класса создать три поля int account, string customer, string provider, 
             * которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения. 
             * В теле класса создать два закрытых поля string article, int quantity Создать метод расчета стоимости заказа с НДС и без НДС. 
             * Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
             */
            Invoice invoice = new Invoice(1, "TOB Комп+", "Dell") { Article = "computer", Quantity = 3 };
            invoice.CostWat();

            Console.Read();

        }
    }
}
