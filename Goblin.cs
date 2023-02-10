using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Goblin : Creature
    {
        Weapon scimitar = new Weapon("Scimitar", 1, 6);
        Weapon shortbow = new Weapon("Short Bow", 1, 6);

        public Goblin(string name) 
        {
            this.name = name;
            health = 7;
            languages = new List<string>() { "Common", "Gobbish" };
            strength = 8;
            dexterity = 14;
            constitution = 10;
            intelligence = 10;
            wisdom = 8;
            charisma = 8;
            armorClass = 15;
            proficiencyBonus = 2;

        }

        public virtual void ScimtiarAttack(Creature target, bool advantage = false)

        {
            int checkResults = performCheck(target.ArmorClass, 4, advantage);
            int damageDealt = (scimitar.rollForDamage() + 2);

            switch (checkResults)
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


        public virtual void BowAttack(Creature target, bool advantage = false)

        {
            int checkResults = performCheck(target.ArmorClass, 4, advantage);
            int damageDealt = (shortbow.rollForDamage() + 2);

            switch (checkResults)
            {
                case 0:
                    Console.WriteLine("Miss");
                    break;

                case 1:
                    Console.WriteLine("Hit: " + damageDealt);
                    target.Health -= damageDealt;
                    break;

                case 2:
                    Console.WriteLine("Critical Hit!: " + (damageDealt * 2));
                    target.Health -= damageDealt * 2;
                    break;
            }
        }

    }
}
