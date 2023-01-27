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

        public static int RollD20(Boolean advantage = false) 
        {
            int result = roll.Next(1, 21);
            Console.WriteLine("Roll is: " + result);
            if (advantage == true)
            {
                int result2 = roll.Next(1, 21);
                Console.WriteLine("Extra roll is: " + result2);
                
                if (result > result2) { return result; }
                else return result2;
            }
            else return result;
 
        }

        // Dice lower than d20 can be used for damage, and need to incorporate the amount of rolls
        // EX: 5d6 is the total of 5 times rolled d6s
        public static int RollD12(int timesToRoll = 1)
        {
            int result = 0;
            for (int i = 0; i < timesToRoll; i++)
                result += roll.Next(1, 13);

            return result;
        }

        public static int RollD10(int timesToRoll = 1)
        {
            int result = 0;
            for (int i = 0; i < timesToRoll; i++)
                result += roll.Next(1, 11);

            return result;
        }

        public static int RollD8(int timesToRoll = 1)
        {
            int result = 0;
            for (int i = 0; i < timesToRoll; i++)
                result += roll.Next(1, 9);

            return result;
        }

        public static int RollD6(int timesToRoll = 1)
        {
            int result = 0;
            for (int i = 0; i < timesToRoll; i++)
                result += roll.Next(1, 7);

            return result;
        }

        public static int RollD4(int timesToRoll = 1)
        {
            int result = 0;
            for (int i = 0; i < timesToRoll; i++)
                result += roll.Next(1, 5);

            return result;
        }
    }
}
