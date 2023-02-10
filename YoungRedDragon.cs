using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class YoungRedDragon : Creature
    {
        Weapon bite = new Weapon("Bite", 2, 10);
        Weapon claw = new Weapon("Claw", 2, 6);
        Weapon breath = new Weapon("Fire Breath", 16, 6);
        double challengeRating;

        public YoungRedDragon(string name)
        {
            this.name = name;
            health = 178;
            languages = new List<string>() { "Common", "Draconic" };
            strength = 23;
            dexterity = 10;
            constitution = 21;
            intelligence = 14;
            wisdom = 11;
            charisma = 19;
            armorClass = 18;
            proficiencyBonus = 4;
            challengeRating = 10;

        }

        public virtual void Bite(Creature target, bool advantage = false)

        {
            int checkResults = performCheck(target.ArmorClass, 10, advantage);
            int damageDealt = (bite.rollForDamage() + 6) + 3;//+3 fire damage

            switch (checkResults) // DRY: Consider making this a function, it should work with any attack
            {
                case 0:
                    Console.WriteLine("Miss");
                    break;

                case 1:
                    Console.WriteLine("Hit for: " + damageDealt + " damage!");
                    target.Health -= damageDealt;
                    break;

                case 2:
                    Console.WriteLine("Critical Hit!: " + (damageDealt * 2) + " damage dealt!");
                    target.Health -= damageDealt * 2;
                    break;
            }
        }
    }
}