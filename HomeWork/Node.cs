using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Node
    {
        private int x;

        private int y;

        public int X
        {
            get
            {
                return this.x;
            }
            private set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            private set
            {
                this.y = value;
            }
        }

        public Node(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void MoveDown()
        {
            this.Y++;
        }

        public void MoveLeft()
        {
            this.X--;
        }

        public void MoveRight()
        {
            this.X++;
        }
    }
}
