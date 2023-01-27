using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Creature
    {
        public int health;
        public int armorClass;
        //proficiency bonus
        //could add stats in the future

        //Use a dice roll method, which returns an int, for health
        public Creature(int health, int aromrClass) 
        {
            this.health = health;
            this.armorClass = aromrClass;
        }


        //damage roll being a dice roll method 
        public void attack(Creature creature, int damageRoll, Boolean advantage = false)//damage roll can be weapon later
        {
            int currentRoll = Dice.RollD20(advantage);
            if (creature.armorClass < currentRoll)
            { //+profeciency when applicable, may need weapon
                if (currentRoll == 20)
                {
                    damageRoll = damageRoll * 2;
                    Console.WriteLine("Critical hit!");
                }
                Console.WriteLine("Attack hits for: " + damageRoll);
                creature.health = creature.health - damageRoll;
            }
            else Console.WriteLine("The attack misses");
        }
    }
}
