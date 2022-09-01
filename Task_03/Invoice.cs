using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;

        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CostWat()
        {
            double cost = 0;
            switch (Article)
            {
                case "computer":
                    cost = 1200;
                    break;
                case "monitor":
                    cost = 600;
                    break;
                case "mouse":
                    cost = 60;
                    break;
                default:
                    Console.WriteLine("Нет товара");
                    return;
            }

            Console.WriteLine($"Сумма с ПДВ - {cost * Quantity}, сумма без ПДВ - {cost * 5 / 6 * Quantity}");
        }
    }
}
