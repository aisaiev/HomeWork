using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Task1()
        {
            int x1 = 0;
            Console.WriteLine($"x1: {x1}");
        }

        private static void Task2()
        {
            Console.WriteLine("Ваше имя?");
            string str1 = Console.ReadLine();
            string str2 = "Привет " + str1;
            Console.WriteLine(str2);
        }

        private static void Task3()
        {
            var v1 = 'v';
            v1 = 'a';
            Console.WriteLine($"v1: {v1}");
        }

        private static void Task4()
        {
            Console.Write("Введите длину стороны квадрата: ");
            int x = int.Parse(Console.ReadLine());
            int perimeter = 4 * x;
            Console.WriteLine($"Периметр квадрата: {perimeter}");
        }
    }
}
