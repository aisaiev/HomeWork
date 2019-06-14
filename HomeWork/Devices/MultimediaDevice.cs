using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public abstract class MultimediaDevice : Device
    {
        private byte volume;

        public byte Volume
        {
            get
            {
                return this.volume;
            }
            private set
            {
                if (value >= 0)
                {
                    this.volume = value;
                }
            }
        }

        public void ChangeVolume(byte volumeLevel)
        {
            this.Volume = volumeLevel;
            Console.WriteLine($"Volume is {this.Volume}");
        }

        public void Mute()
        {
            this.Volume = 0;
            Console.WriteLine($"{this.GetType().Name} is mute");
        }
    }
}
