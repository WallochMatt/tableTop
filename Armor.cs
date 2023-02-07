using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Armor
    {
        private string nameOfArmor;
        public int weight;
        public int armorClass;
        //price
        //stealth

        public Armor(string nameOfArmor,int weight, int armorClass)
        {
            this.nameOfArmor = nameOfArmor;
            this.weight = weight;
            this.armorClass = armorClass;   
        }


    }
}
