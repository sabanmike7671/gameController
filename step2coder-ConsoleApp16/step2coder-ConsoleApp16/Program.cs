using System;

namespace step2coder_ConsoleApp16
{
    internal class Program
    {
        public static string input_reader()
        {
            string? input = Console.ReadLine();
            if (input == null || string.IsNullOrWhiteSpace(input))
            {
                return input = "Invalid input";
            }
            return input;
        }
        static void Main(string[] args)
        {

            string beenden = "";

            Human h1 = new Human();
            Human h2 = new Human("hansi");

            //Human ist die Elternklasse (parent)
            //Es werden alle public Attribute vererbt
            //private attribute werden nicht vererbt...
            //wenn private dann methoden welche umgeht public
            //ohne methoden funktioniert private nicht 
            //wie hacken über funktionen systeme manipulieren



            SuperHuman s1 = new SuperHuman();
            SuperHuman s2 = new SuperHuman("dergb");




            h1.printData();
            s1.fight();


            //Console c = new Console ();
            //c.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            Console.WriteLine("wer gegen wen?");

            string wahl_1 = input_reader();
            string wahl_2 = input_reader();
            
            // hier müsste man noch schreiben das wahl_1 human ist und whal_2 superhuman

            GameController.fight(h1, s1);


            Console.WriteLine("Wollen Sie mit JA beenden?");
            
            input_reader();

            beenden = Console.ReadLine().ToLower();

            if(beenden == "ja")
            {
                Environment.Exit(0);
            }


            
        }
    }
}
