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
        double challengeRating;
  

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
            challengeRating = .25;

            strSaveProficiency = 0;
            dexSaveProficiency = 0;
            conSaveProficiency = 0;
            intSaveProficiency = 0;
            wisSaveProficiency = 0;
            chaSaveProficiency = 0;

    }

        public virtual void ScimtiarAttack(Creature target, bool advantage = false)

        {
            int checkResults = performCheck(target.ArmorClass, 4, advantage);
            int damageDealt = (scimitar.rollForDamage() + 2);
            runResult(checkResults, damageDealt, target);
        }


        public virtual void BowAttack(Creature target, bool advantage = false)

        {
            int checkResults = performCheck(target.ArmorClass, 4, advantage);
            int damageDealt = (shortbow.rollForDamage() + 2);
            runResult(checkResults, damageDealt, target);
        }

    }
}
