﻿using System;
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
        public string name;
        
        private int speed;

        private bool darkvision;

        private string toolProf; // Tool class needed

        public string[] languages;

        public Race(string name, int speed, bool darkvision, string toolProf, string[] languages) 
        {
            this.name = name;
            this.speed = speed;
            this.darkvision = darkvision;
            this.toolProf = toolProf;   
            this.languages = languages;

        }


    }
}