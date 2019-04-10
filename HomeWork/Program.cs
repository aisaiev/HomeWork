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

        private static void Task6()
        {
            Console.Write("Enter natural number: ");
            int number = int.Parse(Console.ReadLine());
            int evenNumbersCounter = 0;
            if (IsNumberSimple(number))
            {
                while (number != 0)
                {
                    if (number % 2 == 0)
                    {
                        evenNumbersCounter++;
                    }
                    number /= 10;
                }
                Console.WriteLine($"Number of even numbers: {evenNumbersCounter}");
            }
            else
            {
                Console.WriteLine("Enter natural number");
            }
        }

        private static void Task7()
        {
            Console.Write("Enter number A: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter number B: ");
            int numberB = int.Parse(Console.ReadLine());
            int sum = 0;
            int numbersCount = 0;
            for (int i = numberA; i <= numberB; i++)
            {
                sum += i;
                numbersCount++;
            }
            Console.WriteLine($"Average numbers from {numberA} to {numberB} is {(double)sum / numbersCount}");
        }

        private static void Task8()
        {
            int distanceInTheFirstDay = 10;
            double denominator = 1.1;
            int numberOfDays = 0;
            double sum = 0;
            while (sum <= 100)
            {
                numberOfDays++;
                sum = distanceInTheFirstDay * (Math.Pow(denominator, numberOfDays) - 1) / (denominator - 1);
            }
            Console.WriteLine(numberOfDays);
        }

        private static void Task9()
        {
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNUmber = int.Parse(Console.ReadLine());
            int result = 0;
            int tempNumber = secondNUmber;
            if (secondNUmber < 0)
            {
                tempNumber = -secondNUmber;
            }
            for (int i = 0; i < tempNumber; i++)
            {
                result += firstNumber;
            }
            if (secondNUmber < 0)
            {
                result = -result;
            }
            Console.WriteLine($"{firstNumber} * {secondNUmber} = {result}");
        }

        private static void Task10()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (Math.Pow(i, 2) < number)
                {
                    Console.WriteLine($"{i} * {i} = {Math.Pow(i, 2)}");
                }
            }
        }

        private static void Task12()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        private static int Fibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }

        private static void Task11()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                int fibonacci = Fibonacci(i);
                if (fibonacci < number)
                {
                    Console.Write(fibonacci + " ");
                }
            }
        }

        private static void Task13()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int reversedNumber = 0;
            List<int> intList = new List<int>();
            do
            {
                intList.Add(number % 10);
                number /= 10;
            } while (number > 0);
            foreach (var item in intList)
            {
                reversedNumber = 10 * reversedNumber + item;
            }
            Console.WriteLine(reversedNumber);
        }

        private static void Task14()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            do
            {
                intList.Add(number % 10);
                number /= 10;
            } while (number > 0);
            intList.Reverse();
            foreach (var item in intList)
            {
                Console.Write(item);
            }
        }

        private static void Task15()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter power: ");
            int power = int.Parse(Console.ReadLine());
            int temp = 1;
            for (int i = 0; i < power; i++)
            {
                temp *= number;
            }
            Console.WriteLine($"{number}^{power} = {temp}");
        }

        private static void Task16()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter number to delete: ");
            int numberToDelete = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            int tempNumber = number;
            do
            {
                intList.Add(tempNumber % 10);
                tempNumber /= 10;
            } while (tempNumber > 0);
            intList.Reverse();
            intList.RemoveAt(intList.IndexOf(numberToDelete));
            Console.WriteLine($"Number {number} without {numberToDelete}: {int.Parse(string.Join("", intList))}");
        }

        private static void Task17()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            List<int> intList = new List<int>();
            do
            {
                intList.Add(number % 10);
                number /= 10;
            } while (number > 0);
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] > maxNumber)
                {
                    maxNumber = intList[i];
                }
            }
            Console.WriteLine($"Maximum number is {maxNumber}");
        }
    }
}
