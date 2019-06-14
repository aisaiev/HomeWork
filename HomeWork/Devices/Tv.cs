using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Tv : MultimediaDevice
    {
        private int currentChannel;

        public int CurrentChannel
        {
            get
            {
                return this.currentChannel;
            }
            private set
            {
                if (value > 0)
                {
                    this.currentChannel = value;
                }
            }
        }

        public List<string> ChannelList { get; private set; }

        public void SwitchChannel(int channel)
        {
            this.CurrentChannel = channel;
            Console.WriteLine($"Current channel is {this.CurrentChannel}");
        }

        public void AddChannel(string channelName)
        {
            if (!string.IsNullOrEmpty(channelName))
            {
                this.ChannelList.Add(channelName);
                Console.WriteLine($"{channelName} has been added to the channel list");
            }
        }

        public void RemoveChannel(string channelName)
        {
            if (!string.IsNullOrEmpty(channelName))
            {
                this.ChannelList.Remove(channelName);
                Console.WriteLine($"{channelName} has been removed from the channel list");
            }
        }

        public Tv(string name)
        {
            this.Name = name;
            this.ChannelList = new List<string>();
        }
    }
}
