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


        public Adventurer(string name, int str, int dex, int con, int intl, int wis, int cha, Background background, Race race, Weapon weapon, Armor armor, Vocation vocation) 
        {
            this.name = name;
            proficiencyBonus= 2;
            Strength = str + race.strBonus;
            Dexterity = dex + race.dexBonus;
            Constitution = con + race.conBonus;
            Intelligence = intl + race.intBonus;
            Wisdom = wis + race.wisBonus;
            Charisma = cha + race.chaBonus;

            Health = vocation.startingHealth + GetAbilityModifier(Constitution);

            this.race = race;   
            this.weapon = weapon;
            this.armor = armor;
            armorClass = armor.armorClass;
            Languages.AddRange(race.raceLanguages);
            Languages.AddRange(background.backgroundLanguages);
            AddSaves(vocation.statSaveBonus1, vocation.statSaveBonus2);

        }

        private void AddSaves(string saveBonus1, string saveBonus2) 
        {
            switch (saveBonus1)
            {
                case "Strength":
                    strSaveProficiency += proficiencyBonus;
                    break;

                case "Dexterity":
                    dexSaveProficiency += proficiencyBonus;
                    break;

                case "Constitution":
                    conSaveProficiency += proficiencyBonus;
                    break;

                case "Intelligence":
                    intSaveProficiency += proficiencyBonus;
                    break;

                case "Wisdom":
                    wisSaveProficiency += proficiencyBonus;
                    break;

                case "Charisma":
                    chaSaveProficiency += proficiencyBonus;
                    break;
            }

            switch (saveBonus2)
            {
                case "Strength":
                    strSaveProficiency += proficiencyBonus;
                    break;

                case "Dexterity":
                    dexSaveProficiency += proficiencyBonus;
                    break;

                case "Constitution":
                    conSaveProficiency += proficiencyBonus;
                    break;

                case "Intelligence":
                    intSaveProficiency += proficiencyBonus;
                    break;

                case "Wisdom":
                    wisSaveProficiency += proficiencyBonus;
                    break;

                case "Charisma":
                    chaSaveProficiency += proficiencyBonus;
                    break;
            }
        } 
    }
}
