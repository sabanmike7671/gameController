using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step2coder_ConsoleApp16
{
    public static class GameController
    {

        //übergeordnete Instanz welche alles steuert als vererbungsklasse
        //statische Klasse
        //static class

        //human und superhuman als parametereingabe


        //static  statische Klasse braucht man kein objekt erzeugen
        // um auf die methode fight zugreifen brauche ich kein objekt

        //wie greifen wir auf fight in der klasse gamecontroller zu??

        //GameController gc = new GameController(); funktioniert nicht

        //weil aus superhuman sh Vererbung und Klasse human h daten verwendet wird


        public static void fight (Human h, SuperHuman s)
        {
            
            Console.WriteLine($"{h.name} is fighting {s.name}");

        }



        /*
         * 
"string? input" das Fragezeichen muss dahin, 
        
        damit dieser String auch Null sein darf

dieses || kann man mit "Alt Gr" "<" eingeben, 
        
        also die Taste "kleiner-" "größer-" Zeichen das ist als "Oder" bekannt.

In der Zeile if (input == null || string.IsNullOrWhiteSpace(input)) 
        
        überprüfe ich somit ob EINES der beiden Ausdrückeinnerhalb dieser "if-Abfrage" zutrifft.
        
        Wenn also entweder das links oder das rechts von diesem Ausdruck || 
        
        stimmtwird das innerhalb der geschwungenen Klammer ausgeführt.

string.IsNullOrWhiteSpace() ist eine Funktion in C# um zu sehen ob etwas "Null" oder "WhiteSpace" ist. 
        
        Also ob es"nicht existiert" oder ob es "Nur Leerzeichen" sind


        */




    }
}
