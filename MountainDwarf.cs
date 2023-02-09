using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class MountainDwarf : Race
    {
        protected int constitutionBonus;
        protected int strengthBonus;

        public MountainDwarf()
        {
            constitutionBonus = 2;
            strengthBonus = 2;
            nameOfRace= "MD";
            size = "Medium";
            speed = 25;
            darkvision = true;
            toolProf = "Artisan's Tools";
            raceLanguages = new List<string>{"Common", "Dwarvish" };
            
        }  

    }
}
