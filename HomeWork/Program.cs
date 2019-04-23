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
            string str = "How can mirrors be real if our eyes aren't real";
            string[] words = str.Split(' ');
            string[] resultWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                resultWords[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            string resultStr = string.Join(" ", resultWords);
            Console.WriteLine(resultStr);
        }

        private static void Task2()
        {
            string str = "aaaaaaaaaaaaaabbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            char[] controlChars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };
            int numberOfErrors = 0;
            foreach (var item in str)
            {
                if (!controlChars.Contains(item))
                {
                    numberOfErrors++;
                }
            }
            Console.WriteLine($"{numberOfErrors}/{str.Length}");
        }

        private static void Task3()
        {
            string str = "abracadabra";
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int numberOfVowels = 0;
            foreach (var item in str)
            {
                if (vowels.Contains(item))
                {
                    numberOfVowels++;
                }
            }
            Console.WriteLine($"{str} - {numberOfVowels} vowels");
        }
    }
}
