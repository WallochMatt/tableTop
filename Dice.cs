using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Dice
    {
        public int numOfSides;

        public Dice(int numOfSides) 
        {
            this.numOfSides = numOfSides;
        }

        public int Roll(int timesToRoll = 1)
        {
            int result = 0;
            for (int i = 0; i < timesToRoll; i++)
                result += RandomNumberGenerator.Generate(this.numOfSides);

            return result;
        }

    }
}
