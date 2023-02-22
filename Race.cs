using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Race
    {
        //Still need to figure out how to add the bonus stats of a Race to a Creature
        protected string nameOfRace;
        public string NameOfRace
        {
            get { return nameOfRace; }
            set { nameOfRace = value; }
        }

        protected string size;
        
        protected int speed;

        protected bool darkvision;

        protected string toolProf; // Tool class needed

        public List<string> raceLanguages;

        public int strBonus;
        public int dexBonus;
        public int conBonus;
        public int intBonus;
        public int wisBonus;
        public int chaBonus;
        //                                                               Porbably should become a class
        public Race(string nameOfRace, string size, int speed, bool darkvision, string toolProf, List<string> raceLanguages, int strBonus, int dexBonus, int conBonus, int intBonus, int wisBonus, int chaBonus) 
        { 
            this.nameOfRace = nameOfRace;
            this.size = size;
            this.speed = speed;
            this.darkvision = darkvision;
            this.toolProf = toolProf;
            this.raceLanguages = raceLanguages;

            this.strBonus = strBonus;
            this.dexBonus = dexBonus;
            this.conBonus = conBonus;
            this.intBonus = intBonus;
            this.wisBonus = wisBonus;
            this.chaBonus = chaBonus;
        }
        //Could do a switch case for the tools. Races get the list of tools and a character gets the one of their choosing
    }
}
