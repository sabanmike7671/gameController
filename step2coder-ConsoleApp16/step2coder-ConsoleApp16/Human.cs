using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step2coder_ConsoleApp16
{
    public class Human
    {




        private string id;


        public string name;
        public string haarfarbe;


        public int augen;


        //Basiskonstruktur wie Definition und Deklaration im Hauptprogramm

        public Human ()
        {
            this.name = "KU";
        }


        public Human (string _name)
        {
            this.name = _name;

        }

        public void printData()
        {
            Console.WriteLine("Namen" + name + "Augen" + augen + "Haarfarbe" + haarfarbe);
        }
    }
}
