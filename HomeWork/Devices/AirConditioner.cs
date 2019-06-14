using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Devices
{
    public class AirConditioner : Device
    {
        private readonly int minTemperature = -5;

        private readonly int maxTemperature = 40;

        private int temperature;

        public int Temperature
        {
            get
            {
                return this.temperature;
            }
            private set
            {
                if (value >= minTemperature && value <= maxTemperature)
                {
                    this.temperature = value;
                }
            }
        }

        public void DownTemperature()
        {
            this.temperature--;
            Console.WriteLine($"Temperature is {this.temperature}");
        }

        public void UpTemperature()
        {
            this.temperature++;
            Console.WriteLine($"Temperature is {this.temperature}");
        }

        public AirConditioner(string name)
        {
            this.Name = name;
        }
    }
}
