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
        //public Weapon weapon;
        //proficiency bonus
        //could add stats in the future

        //Use a dice roll method, which returns an int, for health
        public Creature(int health, int aromrClass) 
        {
            this.health = health;
            this.armorClass = aromrClass;
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



        public void attack(Creature creature, bool advantage = false)
        {
            int checkResults = performCheck(creature.armorClass, advantage);

            switch (checkResults) 
            {
                case 0:
                    Console.WriteLine("Miss");
                    break;

                case 1:
                    Console.WriteLine("Hit"); 
                    creature.health = creature.health - 1; //subtract weapon damage
                    break; 
                
                case 2:
                    Console.WriteLine("Critical Hit!");
                    creature.health = creature.health - (1 * 2);// 1 is weapon damage placeholder
                    break;

                    //^^ Damage logic can be changed when Weapon is properly implemented
            }
        }
    }
}
