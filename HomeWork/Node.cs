using HomeWork.Enum;
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

        private Color color;

        private char symbol;

        public int X
        {
            get
            {
                return this.x;
            }
            set
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
            set
            {
                this.y = value;
            }
        }

        public Color Color
        {
            get
            {
                return this.color;
            }
            private set
            {
                this.color = value;
            }
        }

        public char Symbol
        {
            get
            {
                return this.symbol;
            }
            set
            {
                this.symbol = value;
            }
        }

        public Node(int x, int y, Color color, char symbol)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
            this.Symbol = symbol;
        }

        public void MoveDown()
        {
            this.Y++;
        }
    }
}
