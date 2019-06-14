using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Devices
{
    public class Fan : Device
    {
        public Speed Speed { get; set; }

        public bool isSwing;

        public Fan(string name)
        {
            this.Name = name;
        }
    }
}
