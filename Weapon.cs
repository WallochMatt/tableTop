using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Weapon
    {
        private string nameOfWeapon;
        public int diceCount;
        public int dieSize;

        public Weapon(string nameOfWeapon, int diceCount, int dieSize) 
        { 
            this.nameOfWeapon = nameOfWeapon;
            this.diceCount = diceCount;
            this.dieSize = dieSize;
        }   

        public int rollForDamage()
        {
            int totalDamage = 0;
            for (int i = 0; i < diceCount; i++)
                totalDamage += RandomNumberGenerator.Generate(dieSize);
            return totalDamage;
        }

    }
}
