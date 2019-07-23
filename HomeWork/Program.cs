using HomeWork.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            List<List<Node>> nodeList = new List<List<Node>>();
            nodeList.Add(GenereteFigure(10));
            nodeList.Add(GenereteFigure(20));
            nodeList.Add(GenereteFigure(30));
            nodeList.Add(GenereteFigure(40));
            nodeList.Add(GenereteFigure(50));
            nodeList.Add(GenereteFigure(60));
            nodeList.Add(GenereteFigure(70));
            nodeList.Add(GenereteFigure(80));
            nodeList.Add(GenereteFigure(90));
            nodeList.Add(GenereteFigure(100));
            nodeList.Add(GenereteFigure(110));

            do
            {
                foreach (var nodes in nodeList)
                {
                    DrawFigure(nodes).Wait();
                    Thread.Sleep(7);
                    MoveFigure(nodes).Wait();
                }
            } while (true);

            //List<Node> nodes = GenereteFigure(5);
            //do
            //{
            //    DrawFigure(nodes);
            //    Thread.Sleep(200);
            //    MoveDown(nodes);
            //    IsNodeOnTheBottom(nodes);
            //    if (nodes.Count == 0)
            //    {
            //        nodes = GenereteFigure(5);
            //    }
            //} while (true);
        }

        public static void GenerateFigures()
        {

        }

        public static Task DrawFigure(List<Node> nodes)
        {
            return Task.Run(() =>
            {
                foreach (var node in nodes)
                {
                    Console.SetCursorPosition(node.X, node.Y);
                    Console.ForegroundColor = (ConsoleColor)node.Color;
                    Console.Write(node.Symbol);
                }
            });
        }

        public static Task MoveFigure(List<Node> nodes)
        {
            return Task.Run(() =>
            {
                Random rnd = new Random();
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (i == nodes.Count - 1)
                    {
                        Console.SetCursorPosition(nodes[i].X, nodes[i].Y);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(' ');
                    }
                    if (i == 0)
                    {
                        nodes[i].Symbol = (char)rnd.Next(35, 39);
                    }
                    else
                    {
                        nodes[i].Symbol = (char)rnd.Next(97, 123);
                    }
                    nodes[i].MoveDown();
                }
            });
        }

        public static List<Node> GenereteFigure(int offset)
        {
            List<Node> nodes = new List<Node>();
            Random rnd = new Random();
            int size = GenerateRandomInt(5, 10);
            for (int i = size; i > 0; i--)
            {
                if (i == size)
                {
                    nodes.Add(new Node(offset, i - 1, Color.White, (char)rnd.Next(35, 39)));
                }
                else if (i == size - 1)
                {
                    nodes.Add(new Node(offset, i - 1, Color.Green, (char)rnd.Next(97, 123)));
                }
                else
                {
                    nodes.Add(new Node(offset, i - 1, Color.DarkGreen, (char)rnd.Next(97, 123)));
                }
            }
            return nodes;
        }

        public static void IsNodeOnTheBottom(List<Node> nodes)
        {
            foreach (var node in new List<Node>(nodes))
            {
                if (node.Y == Console.WindowHeight)
                {
                    nodes.Remove(node);
                }
            }
        }

        private static int GenerateRandomInt(int min, int max)
        {
            RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();

            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                byte[] four_bytes = new byte[4];
                Rand.GetBytes(four_bytes);
                scale = BitConverter.ToUInt32(four_bytes, 0);
            }
            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }

        //public static void DrawFigure(List<Node> nodes)
        //{
        //    foreach (var node in nodes)
        //    {
        //        Console.SetCursorPosition(node.X, node.Y);
        //        Console.ForegroundColor = node.Color;
        //        Console.Write(node.NodeSymbol);
        //    }
        //}

        //public static void MoveDown(List<Node> nodes)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < nodes.Count; i++)
        //    {
        //        if (i == nodes.Count - 1)
        //        {
        //            Console.SetCursorPosition(nodes[i].X, nodes[i].Y);
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.Write(' ');
        //        }
        //        if (i == 0)
        //        {
        //            nodes[i].NodeSymbol = (char)rnd.Next(35, 39);
        //        }
        //        else
        //        {
        //            nodes[i].NodeSymbol = (char)rnd.Next(97, 123);
        //        }
        //        nodes[i].MoveDown();
        //    }
        //}
    }
}
