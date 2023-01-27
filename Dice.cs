using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Dice
    {
        public static int timesToRoll;
        public static Random roll;

        static Dice() 
        {
            roll = new Random();
        }

        public static int Rolld20() 
        {
            int result = roll.Next(1, 21);
            return result;
        }
    }
}
