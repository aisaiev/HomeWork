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
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            if (number % 1 == 0 && number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"{number}! = {factorial}");
            }
            else if (number == 0)
            {
                Console.WriteLine("0! = 1");
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }
        }
    }
}
