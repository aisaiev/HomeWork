using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        private static Position position;
        static void Main(string[] args)
        {
        }

        private static void Task1()
        {
            Console.Write("Enter size of array: ");
            int arraySize = int.Parse(Console.ReadLine());
            Console.Write("Enter elements of array through the space: ");
            string arrayString = Console.ReadLine();
            string[] stringArray = arrayString.Split(' ');
            int[] intArray = new int[arraySize];
            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }
            if (intArray[0] == 0)
            {
                position = Position.One;
            }
            else
            {
                position = Position.Zero;
            }
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == 0)
                {
                    continue;
                }
                else
                {
                    if (position == Position.Zero)
                    {
                        for (int j = 0; j < intArray[i]; j++)
                        {
                            Console.Write(0);
                        }
                        position = Position.One;
                    }
                    else
                    {
                        for (int j = 0; j < intArray[i]; j++)
                        {
                            Console.Write(1);
                        }
                        position = Position.Zero;
                    }
                }
            }
        }
    }

    enum Position
    {
        Zero,
        One
    }
}
