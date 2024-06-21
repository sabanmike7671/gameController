using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step2coder_ConsoleApp16
{
    public class SuperHuman: Human
    {
        //vererbung weitergabe bestimmter eigenschaften
        //klasse und vererbte klasse ist superhuman
        //vergleich zu java, c++, python



        string specialability;

        public SuperHuman()
        {
            this.name = "DO";
        }
        public SuperHuman(string _name)
        {
            this.name = _name;
        }
        //void bedeutet, dass kein rückgabewert erzeugt wird
        public void fight()
        {

        }

    }
}
