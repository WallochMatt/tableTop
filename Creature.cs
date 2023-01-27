using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Creature
    {
        //member variables
        public int health;
        public int armorClass;
        //could add stats in the future

        //Use a dice roll method, which returns an int, for health
        public Creature(int health, int aromrClass) 
        {
            this.health = health;
            this.armorClass = aromrClass;
        }
        //damage roll being a dice roll method 
        public void attack(Creature creature, int damageRoll)
        {
            if (creature.armorClass < Dice.RollD20())
                creature.health = creature.health - damageRoll;
            else Console.WriteLine("The attack misses");
        }
    }
}
