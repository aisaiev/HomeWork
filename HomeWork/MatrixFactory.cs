using HomeWork.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork
{
    class MatrixFactory
    {
        public void Run(int density, int speed)
        {
            Console.CursorVisible = false;
            List<List<Node>> nodeList = GenerateFigures(density);
            do
            {
                for (int i = 0; i < nodeList.Count; i++)
                {
                    int offset = nodeList[i][nodeList[i].Count - 1].X;
                    DrawFigure(nodeList[i]).Wait();
                    Thread.Sleep(speed);
                    MoveFigure(nodeList[i]).Wait();
                    CheckIsNodeOnTheBottomOfTheConsole(nodeList[i]);
                    if (nodeList[i].Count == 0)
                    {
                        nodeList[i] = GenereteFigure(offset);
                    }
                }
            } while (true);
        }

        private List<List<Node>> GenerateFigures(int density)
        {
            List<List<Node>> nodeList = new List<List<Node>>();
            for (int i = 0; i < Console.WindowWidth / density; i++)
            {
                nodeList.Add(GenereteFigure(i * density));
            }
            return nodeList;
        }

        public static Task DrawFigure(List<Node> nodes)
        {
            return Task.Run(() =>
            {
                foreach (var node in nodes)
                {
                    if (node.Y >= 0)
                    {
                        Console.SetCursorPosition(node.X, node.Y);
                        Console.ForegroundColor = (ConsoleColor)node.Color;
                        Console.Write(node.Symbol);
                    }
                }
            });
        }

        private Task MoveFigure(List<Node> nodes)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (i == nodes.Count - 1)
                    {
                        if (nodes[i].Y >= 0)
                        {
                            Console.SetCursorPosition(nodes[i].X, nodes[i].Y);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(' ');
                        }
                    }
                    if (i == 0)
                    {
                        nodes[i].Symbol = GenerateSymbol();
                    }
                    else
                    {
                        nodes[i].Symbol = GenerateSymbol();
                    }
                    nodes[i].MoveDown();
                }
            });
        }

        private List<Node> GenereteFigure(int offset)
        {
            List<Node> nodes = new List<Node>();
            int size = Utils.GenerateRandomInt(5, 20) * -1;
            for (int i = -1; i >= size; i--)
            {
                if (i == -1)
                {
                    nodes.Add(new Node(offset, i, Color.White, GenerateSymbol()));
                }
                else if (i == -2)
                {
                    nodes.Add(new Node(offset, i, Color.Green, GenerateSymbol()));
                }
                else
                {
                    nodes.Add(new Node(offset, i, Color.DarkGreen, GenerateSymbol()));
                }
            }
            return nodes;
        }

        private void CheckIsNodeOnTheBottomOfTheConsole(List<Node> nodes)
        {
            foreach (var node in new List<Node>(nodes))
            {
                if (node.Y == Console.WindowHeight)
                {
                    nodes.Remove(node);
                }
            }
        }

        private char GenerateSymbol()
        {
            return (char)Utils.GenerateRandomInt(65, 91);
        }
    }
}
