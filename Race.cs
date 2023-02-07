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
        private string nameOfRace;
        
        private int speed;

        private bool darkvision;

        private string toolProf; // Tool class needed

        public List<string> raceLanguages;

        public Race(string nameOfRace, int speed, bool darkvision, string toolProf, List<string> raceLanguages) 
        {
            this.nameOfRace = nameOfRace;
            this.speed = speed;
            this.darkvision = darkvision;
            this.toolProf = toolProf;   
            this.raceLanguages = raceLanguages;
        }


    }
}
