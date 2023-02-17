using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Vocation
    {
        public int startingHealth;
        public string statSaveBonus1;
        public string statSaveBonus2;
        

        public Vocation(int startingHealth, string statSaveBonus1, string statSaveBonus2)
        {
            this.startingHealth = startingHealth;
            this.statSaveBonus1 = statSaveBonus1;
            this.statSaveBonus2 = statSaveBonus2;   
        }   
    }
}
