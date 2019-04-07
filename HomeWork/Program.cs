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
    }
}
