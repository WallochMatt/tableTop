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
        public Weapon weapon;
        //proficiency bonus
        //could add stats in the future

        //Use a dice roll method, which returns an int, for health
        public Creature(int health, int aromrClass, Weapon weapon)
        {
            this.health = health;
            this.armorClass = aromrClass;
            this.weapon = weapon;
        }


        public int performCheck(int valueToBeat, bool advantage = false)
        {

            int actualValue = RandomNumberGenerator.Generate(20);
            Console.WriteLine("Roll is: " + actualValue);

            if (advantage == true)
            {
                int advantageValue = RandomNumberGenerator.Generate(20);
                Console.WriteLine("Extra roll is: " + advantageValue);
                if (actualValue >= advantageValue)
                {
                    actualValue += 0;
                }
                else 
                { 
                    actualValue = advantageValue; 
                };
            }
            // ^^ Checks the in play roll when player has advantage


            if ((valueToBeat < actualValue == true) && actualValue == 20)
            {//if crit
                return 2;
            }
            else if (valueToBeat < actualValue)
            {//if passed
                return 1;
            }//if failed
            else return 0;
        }

        public Weapon GetWeapon()
        {
            return weapon;
        }

        public void Attack(Creature creature, Weapon attackerWeapon, bool advantage = false)
        {
            int checkResults = performCheck(creature.armorClass, advantage);
            Weapon attackersWeapon = GetWeapon();

            switch (checkResults) 
            {
                case 0:
                    Console.WriteLine("Miss");
                    break;

                case 1:
                    Console.WriteLine("Hit"); 
                    creature.health -= (attackersWeapon.rollForDamage());
                    break; 
                
                case 2:
                    Console.WriteLine("Critical Hit!");
                    creature.health -= (attackersWeapon.rollForDamage()) * 2;
                    break;
            }
        }
    }
}
