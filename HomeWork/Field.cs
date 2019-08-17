using HomeWork.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Field
    {
        public Figure roadBorder;

        public Figure myCar;

        public List<Figure> otherCars;

        public KeyboardHandler kbh;

        private readonly Drawer drawer;

        public readonly int Width = 12;

        public readonly int Height = 18;

        public Field(Figure roadBorder, Figure myCar, List<Figure> otherCars)
        {
            this.roadBorder = roadBorder;
            this.myCar = myCar;
            this.otherCars = otherCars;
            this.drawer = new Drawer();
            this.InitializeState();
            this.roadBorder.InitializeState();
            this.myCar.InitializeState();
            this.otherCars[0].InitializeState();
            this.kbh = new KeyboardHandler();
            this.kbh.KeyLeft += Kbh_KeyLeft;
            this.kbh.KeyRight += Kbh_KeyRight;
        }

        public Field()
        {

        }

        private void InitializeState()
        {
            this.drawer.DrawField(this);
        }

        private void Kbh_KeyRight(object sender, EventArgs e)
        {
            if (IsManoeuvreAvailable(MoveDirection.Right))
            {
                foreach (var node in this.myCar.nodes)
                {
                    this.drawer.ClearNode(node.X, node.Y);
                }
                this.myCar.Move(MoveDirection.Right);
                this.drawer.DrawFigure(this.myCar);
            }
        }

        private void Kbh_KeyLeft(object sender, EventArgs e)
        {
            if (IsManoeuvreAvailable(MoveDirection.Left))
            {
                foreach (var node in this.myCar.nodes)
                {
                    this.drawer.ClearNode(node.X, node.Y);
                }
                this.myCar.Move(MoveDirection.Left);
                this.drawer.DrawFigure(this.myCar);
            }
        }

        public bool IsMyCarOnAnotherCar()
        {
            foreach (var myCarNode in this.myCar.nodes)
            {
                foreach (var otherCar in this.otherCars)
                {
                    foreach (var otherCarNode in otherCar.nodes)
                    {
                        if (myCarNode.X == otherCarNode.X && myCarNode.Y == otherCarNode.Y)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool IsManoeuvreAvailable(MoveDirection direction)
        {
            if (direction == MoveDirection.Left)
            {
                Node theLeftmostMyCarNode = this.myCar.nodes.OrderBy(node => node.X).First();

                if (theLeftmostMyCarNode.X - 3 <= 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (direction == MoveDirection.Right)
            {
                Node theRightmostMyCarNode = this.myCar.nodes.OrderByDescending(node => node.X).First();

                if (theRightmostMyCarNode.X + 3 >= this.Width - 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
