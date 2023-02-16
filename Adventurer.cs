using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Adventurer : Creature
    {
        //protected string name;


        protected Race race;

        protected Weapon weapon;

        protected Armor armor;


        public Adventurer(string name, int str, int dex, int con, int intl, int wis, int cha, Race race, Weapon weapon, Armor armor) 
        {
            this.name = name;
            Health = 10;
            proficiencyBonus= 2;
            Strength = str + race.strBonus;
            Dexterity = dex + race.dexBonus;
            Constitution = con + race.conBonus;
            Intelligence = intl + race.intBonus;
            Wisdom = wis + race.wisBonus;
            Charisma = cha + race.chaBonus;

            this.race = race;   
            this.weapon = weapon;
            this.armor = armor;
            armorClass = armor.armorClass;
            Languages.AddRange(race.raceLanguages);

        }
    }
}
