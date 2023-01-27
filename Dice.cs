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

        // Dice lower than d20 can be used for damage, and need to incorporate the amount of rolls
        // EX: 5d6 is the total of 5 times rolled d6s
        public static int Rolld12(int timesToRoll = 1)
        {
            int result = 0;
            for (int i = 0; i < timesToRoll; i++)
                result += roll.Next(1, 13);

            return result;
        }
    }
}
