using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Weapon
    {
        public int diceCount;
        public Dice die;

        public Weapon(int diceCount, Dice die) 
        { 
            this.diceCount = diceCount;
            this.die = die;
        }   

        public int rollForDamage()
        {
            int totalDamage = die.Roll(diceCount);
            return totalDamage;
        }

    }
}
