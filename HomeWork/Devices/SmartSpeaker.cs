using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class SmartSpeaker : MultimediaDevice
    {
        public Source Source { get; private set; }

        public void SetSource(Source source)
        {
            this.Source = source;
            Console.WriteLine($"SmartSpeaker source is {this.Source}");
        }

        public SmartSpeaker(string name)
        {
            this.Name = name;
        }
    }
}
