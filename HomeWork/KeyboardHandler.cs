using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class KeyboardHandler
    {
        public event EventHandler KeyLeft;

        public event EventHandler KeyRight;

        protected virtual void OnKeyLeft()
        {
            this.KeyLeft?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnKeyRight()
        {
            this.KeyRight?.Invoke(this, EventArgs.Empty);
        }

        private ConsoleKeyInfo ReadLastKey()
        {
            Console.SetCursorPosition(0, 0);
            ConsoleKeyInfo keyPressed = new ConsoleKeyInfo();
            while (Console.KeyAvailable)
            {
                keyPressed = Console.ReadKey(true);
            }
            return keyPressed;
        }

        public void QueryKbH()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = ReadLastKey();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            this.OnKeyLeft();
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            this.OnKeyRight();
                            break;
                        }
                }
            }

        }
    }
}
