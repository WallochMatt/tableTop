using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    static class RandomNumberGenerator
    {
        public static Random rng;

        static RandomNumberGenerator()
        {
            rng = new Random();
        }
        public static int Generate(int maximum)
        {
            int randomNum = rng.Next(1, maximum + 1);
            return randomNum;
        }
    }
}
