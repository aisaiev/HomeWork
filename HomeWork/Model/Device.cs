using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public abstract class Device
    {
        private string name;

        public State State { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        public void TurnOn()
        {
            this.State = State.On;
            Console.WriteLine($"{this.GetType().Name} is on");
        }

        public void TurnOff()
        {
            this.State = State.Off;
            Console.WriteLine($"{this.GetType().Name} is off");
        }
    }
}
