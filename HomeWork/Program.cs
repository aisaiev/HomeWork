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

        private static void Task2()
        {
            double sum = 0;
            string[] goods = new string[]
            {
                "Груши", "Яблоки", "Огурцы", "Помидоры", "Укроп",
                "Петрушка", "Курица", "Сыр", "Масло", "Молоко"
            };
            double[] price = new double[]
            {
                40.5, 31.2, 21.8, 35, 150,
                145, 200, 400, 81.40, 53.35
            };
            for (int i = 0; i < goods.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {goods[i]} - {price[i]} грн.");
            }
            Console.WriteLine("Что берём? (вводите № товара; если ничего, то 0)");
            while (true)
            {
                Console.Write("Товар: ");
                int selectedGoods = int.Parse(Console.ReadLine());
                if (selectedGoods != 0)
                {
                    Console.Write("Количество: ");
                    double selectedGoodsQuantity = double.Parse(Console.ReadLine());
                    sum += price[selectedGoods - 1] * selectedGoodsQuantity;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Сумма к оплате: {sum}");
        }

        private static void Task3()
        {
            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static string EncryptText(string text)
        {
            char[] encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };
            char[] textToEncrypt = text.ToCharArray();
            char[] cipherText = new char[textToEncrypt.Length];
            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                int index = Array.IndexOf(encryptChars, textToEncrypt[i]);
                if (index != -1)
                {
                    cipherText[i] = cipher[index];
                }
                else
                {
                    cipherText[i] = cipher[10];
                }
            }
            return new string(cipherText);
        }

        private static string DecryptText(string text)
        {
            char[] encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };
            char[] textToDecrypt = text.ToCharArray();
            char[] decryptedText = new char[textToDecrypt.Length];
            for (int i = 0; i < decryptedText.Length; i++)
            {
                if (textToDecrypt[i] == '$')
                {
                    decryptedText[i] = 'a';
                }
                else
                {
                    decryptedText[i] = encryptChars[Array.IndexOf(cipher, textToDecrypt[i])];
                }
            }
            return new string(decryptedText);
        }
    }

    enum Position
    {
        Zero,
        One
    }
}
