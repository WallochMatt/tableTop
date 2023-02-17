using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableTop
{
    internal class Vocation
    {
        public int strVocSaveProficiency;
        public int dexVocSaveProficiency;
        public int conVocSaveProficiency;
        public int intVocSaveProficiency;
        public int wisVocSaveProficiency;
        public int chaVocSaveProficiency;

        public Vocation(int strVocSaveProficiency, int dexVocSaveProficiency, int conVocSaveProficiency, int intVocSaveProficiency, int wisVocSaveProficiency, int chaVocSaveProficiency)
        { 
            this.strVocSaveProficiency= strVocSaveProficiency;
            this.dexVocSaveProficiency = dexVocSaveProficiency;
            this.conVocSaveProficiency = conVocSaveProficiency;
            this.intVocSaveProficiency = intVocSaveProficiency;
            this.wisVocSaveProficiency = wisVocSaveProficiency;
            this.chaVocSaveProficiency = chaVocSaveProficiency;
        }   
    }
}
