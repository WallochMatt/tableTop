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

            strSaveProficiency = 0;
            dexSaveProficiency = 4;
            conSaveProficiency = 9;
            intSaveProficiency = 0;
            wisSaveProficiency = 4;
            chaSaveProficiency = 8;

        }

        public virtual void Bite(Creature target, bool advantage = false)

        {
            int checkResults = PerformCheck(target.ArmorClass, 10, advantage);
            int damageDealt = (bite.RollForDamage() + 6) + 3;//+3 fire damage
            RunResult(checkResults, damageDealt, target);
        }


        public virtual void Claw(Creature target, bool advantage = false)

        {
            int checkResults = PerformCheck(target.ArmorClass, 10, advantage);
            int damageDealt = (claw.RollForDamage() + 6);
            RunResult(checkResults, damageDealt, target);
        }

        public virtual void Breath(Creature target, bool advantage = false)

        {
            int savingThrowResult = SavingThrow(target.dexSaveProficiency, target.Dexterity);
            int damageDealt = breath.RollForDamage() / savingThrowResult;
            RunResult(1, damageDealt, target);
        }
    }
}