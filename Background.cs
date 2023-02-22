using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Background
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        //skill proficiencies
        public List<string> backgroundLanguages;
        //equipment
        //Feature?

        public Background(string title, List<string> backgroundLanguages)
        {
            this.title = title;
            this.backgroundLanguages = backgroundLanguages;
        }
    }
}
