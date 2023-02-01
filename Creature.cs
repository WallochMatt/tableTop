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
        public int proficiencyBonus;
    
        //could add stats in the future

        //Use a dice roll method, which returns an int, for health
        public Creature(int health, Weapon weapon, int aromrClass = 8)
        {
            this.health = health;
            
            this.weapon = weapon;
            this.armorClass = aromrClass;
            this.proficiencyBonus = 2;
        }


        public int performCheck(int valueToBeat, bool advantage = false)
        {

            int initialValue = RandomNumberGenerator.Generate(20);
            Console.WriteLine("Roll is: " + initialValue);



            if (advantage == true)
            {
                int advantageValue = RandomNumberGenerator.Generate(20);
                Console.WriteLine("Extra roll is: " + advantageValue);
                if (initialValue <= advantageValue)
                {
                    initialValue = advantageValue;
                }

            };
            // ^^ Checks the in play roll when player has advantage

            int actualValue = initialValue + proficiencyBonus;
            Console.WriteLine("Plus  proficiency( " + proficiencyBonus + "): " + actualValue);


            if ((valueToBeat < actualValue == true) && initialValue == 20)
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
