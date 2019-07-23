using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Utils
    {
        public static int GenerateRandomInt(int min, int max)
        {
            RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                byte[] bytes = new byte[4];
                Rand.GetBytes(bytes);
                scale = BitConverter.ToUInt32(bytes, 0);
            }
            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }
    }
}
