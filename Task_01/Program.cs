using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter convert = new Converter(40,40,0.25);
            
            double amount = convert.ConvertToUsd(100);
            Console.WriteLine($"100 гривен = {amount} долларов");
            
            amount = convert.ConvertFromUsd(100);
            Console.WriteLine($"100 долларов = {amount} гривен");

            Console.ReadKey();
        }
    }
}
