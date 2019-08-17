using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Enum;

namespace HomeWork
{
    public class MyCar : Figure
    {
        public MyCar(ConsoleColor color, char symbol)
            : base(color, symbol) { }

        public override void InitializeState()
        {
            this.nodes = new List<Node>();
            this.GenerateMyCar();
            new Drawer().DrawFigure(this);
        }

        public override void Move(MoveDirection moveDirection)
        {
            switch (moveDirection)
            {
                case MoveDirection.Left:
                    foreach (var node in this.nodes)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            node.MoveLeft();
                        }
                    }
                    break;
                case MoveDirection.Right:
                    foreach (var node in this.nodes)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            node.MoveRight();
                        }
                    }
                    break;
            }
        }

        public void GenerateMyCar()
        {
            Field field = new Field();
            Random rnd = new Random();
            switch (rnd.Next(1, 3))
            {
                case 1:
                    this.nodes = new List<Node>
                    {
                        new Node(field.Width - 9, field.Height - 2),
                        new Node(field.Width - 7, field.Height - 2),
                        new Node(field.Width - 8, field.Height - 3),
                        new Node(field.Width - 8, field.Height - 4),
                        new Node(field.Width - 8, field.Height - 5),
                        new Node(field.Width - 9, field.Height - 4),
                        new Node(field.Width - 7, field.Height - 4)
                    };
                    break;
                case 2:
                    this.nodes = new List<Node>
                    {
                        new Node(field.Width - 6, field.Height - 2),
                        new Node(field.Width - 4, field.Height - 2),
                        new Node(field.Width - 5, field.Height - 3),
                        new Node(field.Width - 5, field.Height - 4),
                        new Node(field.Width - 5, field.Height - 5),
                        new Node(field.Width - 6, field.Height - 4),
                        new Node(field.Width - 4, field.Height - 4)
                    };
                    break;
            }
        }
    }
}
