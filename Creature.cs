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

        public int strSaveProficiency;
        public int dexSaveProficiency;
        public int conSaveProficiency;
        public int intSaveProficiency;
        public int wisSaveProficiency;
        public int chaSaveProficiency;


        //static method instead???
        public int PerformCheck(int valueToBeat, int toHitBonus = 0, bool advantage = false)
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

            int actualValue = initialValue + proficiencyBonus + toHitBonus;
            Console.WriteLine("Plus  proficiency and to hit bonus(" + proficiencyBonus + " + " + toHitBonus + "): " + actualValue);


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

        public virtual void RunResult(int checkResults, int damageDealt, Creature target)
        {
            switch (checkResults)
            {
                case 0:
                    Console.WriteLine("Miss");
                    break;

                case 1:
                    Console.WriteLine("Hit for " + damageDealt + " damage!");
                    target.health -= damageDealt;
                    break;

                case 2:
                    Console.WriteLine("Critical Hit! " + damageDealt + " damage!");
                    target.health -= damageDealt * 2;
                    break;
            }
        }

        // Damage calculated in the respective attack method
        public virtual int SavingThrow(int saveProficiency, int rawStat) 
        {
            int saveModifier = GetAbilityModifier(rawStat);
             int saveStatus = saveProficiency + saveModifier + RandomNumberGenerator.Generate(20);
            if (saveStatus > 17)
            {
                return 2; //take half damage
            }
            else { return 1; } //take full damage
        }

        public virtual int GetAbilityModifier(int stat) 
        { 
            int statModifier = (stat - 10) / 2;
            return statModifier;
        }




    //Level up method: Increase level by one,
    // Increase health by a hit die and add CON modifier
    //allow user to increase stats on ASI

    //Could maybe use static classes for DND Classes, using methods on level ups to grant the features 
    public static void PrintCharacterSheet(Creature character) 
        {
            Console.WriteLine("Name: " + character.name);

            if (character is Adventurer)
            {
                ;
            }
           

            
            Console.WriteLine("Languages: " + String.Join(", ", character.languages));
            Console.WriteLine("Health: " + character.health);
            Console.WriteLine("Proficiency Bonus: " + character.proficiencyBonus);
            Console.WriteLine("AC: " + character.ArmorClass);
            Console.WriteLine("Strength: " + character.strength + "(" + character.GetAbilityModifier(character.Strength) + ")");
            Console.WriteLine("Dexterity: " + character.dexterity + "(" + character.GetAbilityModifier(character.Dexterity) + ")");
            Console.WriteLine("Constitution: " + character.constitution + "(" + character.GetAbilityModifier(character.Constitution) + ")");
            Console.WriteLine("Intelligence: " + character.intelligence + "(" + character.GetAbilityModifier(character.Intelligence) + ")");
            Console.WriteLine("Wisdom: " + character.wisdom + "(" + character.GetAbilityModifier(character.Wisdom) + ")");
            Console.WriteLine("Charisma: " + character.charisma + "(" + character.GetAbilityModifier(character.Charisma) + ")");

            Console.WriteLine(
                "Saves: " + "\n" +
                "\tStrength Save: " + (character.strSaveProficiency + character.GetAbilityModifier(character.Strength)) + "\n" +
                "\tDexterity Save: " + (character.dexSaveProficiency + character.GetAbilityModifier(character.Dexterity)) + "\n" +
                "\tConstitutuin Save: " + (character.conSaveProficiency + character.GetAbilityModifier(character.Constitution)) +  "\n" +
                "\tIntelligence Save: " + (character.intSaveProficiency + character.GetAbilityModifier(character.Intelligence)) + "\n" +
                "\tWisdom Save: " + (character.wisSaveProficiency + character.GetAbilityModifier(character.Wisdom)) + "\n" +
                "\tCharisma Save: " + (character.chaSaveProficiency + character.GetAbilityModifier(character.Charisma))
            );

        }

    }

}
