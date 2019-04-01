using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string Name { get; set; }
        public string Cipher { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            Name = "";
            Cipher = "";
            Quantity = 0;
        }

        public void SetInfo()
        {
            Console.WriteLine("Введите информацию об изделии:");

            Console.Write("Название: ");
            Name = Console.ReadLine();

            Console.Write("Шифр: ");
            Cipher = Console.ReadLine();

            Console.Write("Количество: ");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Шифр: {Cipher}");
            Console.WriteLine($"Количество: {Quantity}");
        }
    }
}
