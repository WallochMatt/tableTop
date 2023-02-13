﻿using System;
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
            runResult(checkResults, damageDealt, target);
        }


        public virtual void Claw(Creature target, bool advantage = false)

        {
            int checkResults = performCheck(target.ArmorClass, 10, advantage);
            int damageDealt = (claw.rollForDamage() + 6);
            runResult(checkResults, damageDealt, target);
        }

        public virtual void Breath(Creature target, bool advantage = false)

        {

            int damageDealt;
            int checkResults = performCheck(0, 0, advantage);
            int saveStatus = target.dexSave + RandomNumberGenerator.Generate(20); ;
            if (saveStatus > 17) 
            {
                damageDealt = (breath.rollForDamage() / 2);
            }
            else { damageDealt = breath.rollForDamage(); }

            runResult(checkResults, damageDealt, target);
        }
    }
}