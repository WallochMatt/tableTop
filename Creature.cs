using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    abstract class Creature
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //pub int level
        protected int health;
        public int Health
        {
            get {return health;}
            set { health = value;}
        }

        protected List<string> languages = new List<string> ();
        public List<string> Languages
        {
            get { return languages; }
            set { languages.AddRange(value); }
        }

        protected int armorClass;
        public int ArmorClass
        { 
            get { return armorClass; } 
            set { armorClass = value; }
        }



        public int proficiencyBonus;






        protected int strength;
        public int Strength
        {
            get { return strength; }
            set { strength += value; }   
        }

        protected int dexterity;
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        protected int constitution;
        public int Constitution
        {
            get { return constitution; }
            set { constitution = value; }
        }
        protected int intelligence;
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        protected int wisdom;
        public int Wisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }
        protected int charisma;
        public int Charisma
        {
            get { return charisma; }
            set { charisma = value; }
        }


        //static method instead???
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


        //public virtual void Attack(Creature target, Weapon attackerWeapon, bool advantage = false)
        //{
        //    int checkResults = performCheck(target.ArmorClass, advantage);
        //    Weapon attackersWeapon = Weapon;

        //    switch (checkResults)
        //    {
        //        case 0:
        //            Console.WriteLine("Miss");
        //            break;

        //        case 1:
        //            Console.WriteLine("Hit");
        //            target.health -= (attackersWeapon.rollForDamage());
        //            break;

        //        case 2:
        //            Console.WriteLine("Critical Hit!");
        //            target.health -= (attackersWeapon.rollForDamage()) * 2;
        //            break;
        //    }
        //}


        //public void DonArmor(Armor armor) 
        //{
        //    ArmorClass = armor.armorClass;
        //}

        //public void DoffArmor() 
        //{
        //    ArmorClass = 2;
        //}


        //Level up method: Increase level by one,
        // Increase health by a hit die and add CON modifier
        //allow user to increase stats on ASI

        //Could maybe use static classes for DND Classes, using methods on level ups to grant the features 
        public static void PrintCharacterSheet(Creature character) 
        {
            //Console.WriteLine("Name: " + character.name);

            //Console.WriteLine("Languages: " + character.languages);
            Console.WriteLine("Languages: " + String.Join(", ", character.languages));
            //Array.ForEach(character.race.languages, Console.WriteLine);
            Console.WriteLine("Health: " + character.health);
            Console.WriteLine("Proficiency Bonus: " + character.proficiencyBonus);

            Console.WriteLine("AC: " + character.ArmorClass);
            
            Console.WriteLine("Strength: " + character.strength);
            Console.WriteLine("Dexterity: " + character.dexterity);
            Console.WriteLine("Constitution: " + character.constitution);
            Console.WriteLine("Intelligence: " + character.intelligence);
            Console.WriteLine("Wisdom: " + character.wisdom);
            Console.WriteLine("Charisma: " + character.charisma);

        }


    }


}
