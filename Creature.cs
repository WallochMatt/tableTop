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
    }
}
