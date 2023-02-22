using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Adventurer : Creature
    {
        protected Race race;

        protected Weapon weapon;

        protected Armor armor;
        public Armor Armor
        {
            get { return armor; }
            set { armor = value; }
        }

        protected Background background;

        protected Vocation vocation;


        public Adventurer(string name, int str, int dex, int con, int intl, int wis, int cha, Background background, Race race, Weapon weapon, Armor armor, Vocation vocation)
        {
            this.name = name;
            proficiencyBonus = 2; //plus level
            Strength = str + race.strBonus;
            Dexterity = dex + race.dexBonus;
            Constitution = con + race.conBonus;
            Intelligence = intl + race.intBonus;
            Wisdom = wis + race.wisBonus;
            Charisma = cha + race.chaBonus;

            Health = vocation.startingHealth + GetAbilityModifier(Constitution);

            this.background = background;
            this.vocation = vocation;
            this.race = race;
            this.weapon = weapon;
            this.armor = armor;
            armorClass = armor.armorClass;

            Languages.AddRange(race.raceLanguages);
            Languages.AddRange(background.backgroundLanguages);
            AddSave(vocation.statSaveBonus1);
            AddSave(vocation.statSaveBonus2);
        }


        private void AddSave(string saveBonus)
        {
            switch (saveBonus)
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

        public void DonArmor(Armor newArmor)
        {
            Armor = newArmor;
            ArmorClass = newArmor.armorClass;
        }


        public static void PrintAdventurerInfo(Adventurer adventurer)
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
        }

        //public void DoffArmor()
        //{
        //    Armor = 
        //    ArmorClass = 2;
        //}


        public override void PrintCharacterSheet()
        {
            Console.WriteLine("Name: " + name);

            Console.WriteLine("Race: " + race.NameOfRace);
            Console.WriteLine("Vocation: " + vocation.nameOfVocation);
            Console.WriteLine("Bacground: " + background.Title);

            Console.WriteLine("Languages: " + String.Join(", ", languages));
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Proficiency Bonus: " + proficiencyBonus);
            Console.WriteLine("AC: " + ArmorClass);
            Console.WriteLine("Strength: " + strength + "(" + GetAbilityModifier(Strength) + ")");
            Console.WriteLine("Dexterity: " + dexterity + "(" + GetAbilityModifier(Dexterity) + ")");
            Console.WriteLine("Constitution: " + constitution + "(" + GetAbilityModifier(Constitution) + ")");
            Console.WriteLine("Intelligence: " + intelligence + "(" + GetAbilityModifier(Intelligence) + ")");
            Console.WriteLine("Wisdom: " + wisdom + "(" + GetAbilityModifier(Wisdom) + ")");
            Console.WriteLine("Charisma: " + charisma + "(" + GetAbilityModifier(Charisma) + ")");

            Console.WriteLine(
                "Saves: " + "\n" +
                "\tStrength Save: " + (strSaveProficiency + GetAbilityModifier(Strength)) + "\n" +
                "\tDexterity Save: " + (dexSaveProficiency + GetAbilityModifier(Dexterity)) + "\n" +
                "\tConstitutuin Save: " + (conSaveProficiency + GetAbilityModifier(Constitution)) + "\n" +
                "\tIntelligence Save: " + (intSaveProficiency + GetAbilityModifier(Intelligence)) + "\n" +
                "\tWisdom Save: " + (wisSaveProficiency + GetAbilityModifier(Wisdom)) + "\n" +
                "\tCharisma Save: " + (chaSaveProficiency + GetAbilityModifier(Charisma))
                );
               
            }
    }
}
