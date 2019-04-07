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

        private static void Task2()
        {
            Console.WriteLine("Enter number to draw figure\n1 - Line\n2 - Rectangle" +
                "\n3 - Right-angled triangle\n4 - Equilateral triangle\n5 - Rhombus");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                //
                // Draw line of symbols.
                //

                case 1:
                    Console.Write("Enter number of symbols: ");
                    int numberOfSymbols = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numberOfSymbols; i++)
                    {
                        Console.Write("*");
                    }
                    break;
                //
                // Draw rectangle of symbols.
                //

                case 2:
                    Console.Write("Enter height of rectangle: ");
                    int height = int.Parse(Console.ReadLine());
                    Console.Write("Enter width of rectangle: ");
                    int width = int.Parse(Console.ReadLine());
                    Console.Write("Is rectangle filled (y/n): ");
                    string isRectangleFilled = Console.ReadLine();
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1)
                            {
                                Console.Write("*");
                            }
                            else if (j == 0 || j == width - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                if (isRectangleFilled == "y")
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                        Console.Write("\n");
                    }
                    break;
                //
                // Draw right-angled triangle of symbols.
                //

                case 3:
                    Console.Write("Enter height of triangle: ");
                    int rectangleHeight = int.Parse(Console.ReadLine());
                    Console.Write("Is triangle filled (y/n): ");
                    string isTriangleFilled = Console.ReadLine();
                    int step = 1;
                    for (int i = 0; i < rectangleHeight; i++)
                    {
                        for (int j = 0; j < step; j++)
                        {
                            if (j == 0 || j == step - 1)
                            {
                                Console.Write("*");
                            }
                            else if (i == rectangleHeight - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                if (isTriangleFilled == "y")
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                        step++;
                        Console.Write("\n");
                    }
                    break;
                //
                // Draw equilateral triangle of symbols.
                //

                case 4:
                    Console.Write("Enter side length: ");
                    int sideLength = int.Parse(Console.ReadLine());
                    for (int i = 1; i < sideLength; i += 2)
                    {
                        for (int j = 0; j < (sideLength - i) / 2; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
            }
        }

        private static void Task3()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Number is negative");
                Console.WriteLine($"Is number simple: {IsNumberSimple(number)}");
                Console.WriteLine($"Is number divided by 2,5,3,6,9 without reminder: " +
                    $"{IsNumberDividedByTwoFiveThreeSixNineWithoutReminder(number)}");
            }
            else if (number > 0)
            {
                Console.WriteLine("Number is positive");
                Console.WriteLine($"Is number simple: {IsNumberSimple(number)}");
                Console.WriteLine($"Is number divided by 2,5,3,6,9 without reminder: " +
                    $"{IsNumberDividedByTwoFiveThreeSixNineWithoutReminder(number)}");
            }
            else
            {
                Console.WriteLine("NUmber is zero");
            }


        }

        private static bool IsNumberSimple(int number)
        {
            bool isNumberSimple = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isNumberSimple = false;
                }
            }
            if (isNumberSimple)
            {
                return isNumberSimple;
            }
            else
            {
                return isNumberSimple;
            }
        }

        private static bool IsNumberDividedByTwoFiveThreeSixNineWithoutReminder(int number)
        {
            if (number % 2 == 0 && number % 5 == 0 && number % 3 == 0 && number % 6 == 0 && number % 9 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void Task4()
        {
            Console.Write("Enter number of clients: ");
            int numberOfClients = int.Parse(Console.ReadLine());
            int numberOfDeliveryOptions = 1;
            do
            {
                numberOfDeliveryOptions *= numberOfClients;
                numberOfClients -= 1;
            } while (numberOfClients > 0);
            Console.WriteLine($"Number of delivery options: {numberOfDeliveryOptions}");
        }

        private static void Task5()
        {
            Console.Write("Enter number A: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter number B: ");
            int numberB = int.Parse(Console.ReadLine());
            int sum = 0;
            List<int> oddNumbersList = new List<int>();
            if (numberA < numberB)
            {
                for (int i = numberA; i <= numberB; i++)
                {
                    sum += i;
                    if (i % 2 != 0)
                    {
                        oddNumbersList.Add(i);
                    }
                }
                Console.WriteLine($"Sum numbers between A and B: {sum}");
                Console.WriteLine($"Odd numbers between A and B: {string.Join(",", oddNumbersList)}");
            }
            else
            {
                Console.WriteLine("Enter numbers A<B");
            }
        }
    }
}
