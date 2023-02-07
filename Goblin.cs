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
        //Same for bow

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

     
            //Weapon bow = new Weapon();
        }

        public virtual void ScimtiarAttack(Creature target, bool advantage = false)

        {
            int checkResults = performCheck(target.ArmorClass, advantage);

            switch (checkResults)
            {
                case 0:
                    Console.WriteLine("Miss");
                    break;

                case 1:
                    Console.WriteLine("Hit");
                    target.Health -= (scimitar.rollForDamage());
                    break;

                case 2:
                    Console.WriteLine("Critical Hit!");
                    target.Health -= (scimitar.rollForDamage()) * 2;
                    break;
            }
        }

    }
}
