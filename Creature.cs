using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Creature
    {
        private string name;
        //pub int level
        public int health;

        private List<string> languages = new List<string> ();
        public List<string> Languages
        {
            get { return languages; }
            set { languages.AddRange(value); }
        }
        //race
        private Race race;
        public Race Race
        { 
            get { return race; }
            set { race = value; }
        }

        private int armorClass;
        public int ArmorClass
        { 
            get { return armorClass; } 
            set { armorClass = value; }
        }
        private Weapon weapon;
        public Weapon Weapon 
        {
            get { return weapon; }
            set { weapon = value; }
        }
        public int proficiencyBonus;

   
        private int strength;
        public int Strength
        {
            get { return strength; }
            set { strength += value; }   
        }

        private int dexterity;
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        private int constitution;
        public int Constitution
        {
            get { return constitution; }
            set { constitution = value; }
        }
        private int intelligence;
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        private int wisdom;
        public int Wisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }
        private int charisma;
        public int Charisma
        {
            get { return charisma; }
            set { charisma = value; }
        }


        //Use a dice roll method, which returns an int, for health
        public Creature(string name, Race race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int health, Weapon weapon, int aromrClass = 8)
        {
            this.name = name;  
            this.race = race;
            this.strength += strength;
            this.dexterity= dexterity;
            this.constitution= constitution;
            this.intelligence= intelligence;
            this.wisdom= wisdom;
            this.charisma= charisma;
            this.health = health;

            this.weapon = weapon;
            this.armorClass = aromrClass;

            this.proficiencyBonus = 2;
            Languages = race.raceLanguages;
        }


        public int performCheck(int valueToBeat, bool advantage = false)
        {

            int initialValue = RandomNumberGenerator.Generate(20);
            Console.WriteLine("Roll is: " + initialValue);



            if (advantage == true)
            {
                int advantageValue = RandomNumberGenerator.Generate(20);
                Console.WriteLine("Extra roll is: " + advantageValue);
                if (initialValue <= advantageValue)
                {
                    initialValue = advantageValue;
                }

            };
            // ^^ Checks the in play roll when player has advantage

            int actualValue = initialValue + proficiencyBonus;
            Console.WriteLine("Plus  proficiency( " + proficiencyBonus + "): " + actualValue);


            if ((valueToBeat < actualValue == true) && initialValue == 20)
            {//if crit
                return 2;
            }
            else if (valueToBeat < actualValue)
            {//if passed
                return 1;
            }//if failed
            else return 0;
        }


        public void Attack(Creature target, Weapon attackerWeapon, bool advantage = false)
        {
            int checkResults = performCheck(target.ArmorClass, advantage);
            Weapon attackersWeapon = Weapon;

            switch (checkResults) 
            {
                case 0:
                    Console.WriteLine("Miss");
                    break;

                case 1:
                    Console.WriteLine("Hit"); 
                    target.health -= (attackersWeapon.rollForDamage());
                    break; 
                
                case 2:
                    Console.WriteLine("Critical Hit!");
                    target.health -= (attackersWeapon.rollForDamage()) * 2;
                    break;
            }
        }

        
        public void DonArmor(Armor armor) 
        {
            ArmorClass = armor.armorClass;
        }

        public void DoffArmor() 
        {
            ArmorClass = 2;
        }


        //Level up method: Increase level by one,
        // Increase health by a hit die and add CON modifier
        //allow user to increase stats on ASI

        //Could maybe use static classes for DND Classes, using methods on level ups to grant the features 
        public static void PrintCharacterSheet(Creature character) 
        {
            Console.WriteLine("Name: " + character.name);
            Console.WriteLine("Race: " + character.race.name);

            //Console.WriteLine("Languages: " + character.languages);
            Console.WriteLine("Languages: " + String.Join(", ", character.languages));
            //Array.ForEach(character.race.languages, Console.WriteLine);


            Console.WriteLine("Health: " + character.health);
            Console.WriteLine("Proficiency Bonus: " + character.proficiencyBonus);

            Console.WriteLine("AC: " + character.ArmorClass);
            Console.WriteLine("Weapon: " + character.Weapon.name + " - Damage: " + character.Weapon.diceCount + "d" +character.Weapon.die.numOfSides);


            Console.WriteLine("Strength: " + character.strength);
            Console.WriteLine("Dexterity: " + character.dexterity);
            Console.WriteLine("Constitution: " + character.constitution);
            Console.WriteLine("Intelligence: " + character.intelligence);
            Console.WriteLine("Wisdom: " + character.wisdom);
            Console.WriteLine("Charisma: " + character.charisma);

        }


    }


}
