using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Devices
{
    public class SmartLamp : Device
    {
        public Color Color { get; private set; }

        public LightIntensity LightIntensity { get; private set; }

        public void ChangeColor(Color color)
        {
            this.Color = color;
            Console.WriteLine($"SmartLamp color is {this.Color}");
        }

        public void ChangeLightIntensity(LightIntensity lightIntensity)
        {
            this.LightIntensity = lightIntensity;
            Console.WriteLine($"SmartLamp lightIntensity is {this.LightIntensity}");
        }

        public SmartLamp(string name)
        {
            this.Name = name;
        }
    }
}
