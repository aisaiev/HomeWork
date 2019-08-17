using HomeWork.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public abstract class Figure
    {
        public List<Node> nodes;

        public char Symbol { get; private set; }

        public ConsoleColor Color { get; private set; }

        public abstract void InitializeState();

        public abstract void Move(MoveDirection moveDirection);

        public Figure(ConsoleColor color, char symbol)
        {
            this.Color = color;
            this.Symbol = symbol;
        }
    }
}
