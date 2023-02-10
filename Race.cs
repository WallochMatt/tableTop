using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    abstract class Race
    {
        //Still need to figure out how to add the bonus stats of a Race to a Creature
        protected string nameOfRace;

        protected string size;
        
        protected int speed;

        protected bool darkvision;

        protected string toolProf; // Tool class needed

        protected List<string> raceLanguages;
    }
}
