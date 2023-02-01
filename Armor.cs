using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Armor
    {
        public string name;
        public int weight;
        public int armorClass;
        //price
        //stealth

        public Armor(string name,int weight, int armorClass)
        {
            this.name = name;
            this.weight = weight;
            this.armorClass = armorClass;   
        }

        //don and doff armor? Or shiuld that be a creature method


    }
}
