using System;

namespace NinjasInSpace.Models {
    public class SetUp {
        public Hero PlayerSetup () {
            Console.WriteLine ("What is your name?");

            string name = Console.ReadLine ();
            string choice = "0";

            while (choice != "1" && choice != "2" && choice != "3") {
                Console.WriteLine ($"Please type of hero you would like to be {name}?\n1. Ninja\n2. Wizard\n3. Sensei");
                choice = Console.ReadLine ();
            }

            switch (choice) {
                case ("1"):
                    Ninja ninjaHero = new Ninja (name);
                    return ninjaHero;
                case ("2"):
                    // Change Ninja to another class of hero.
                    Ninja wizardHero = new Ninja (name);
                    return wizardHero;
                case ("3"):
                    // Change Ninja to another class of hero.
                    Ninja senseiHero = new Ninja (name);
                    return senseiHero;
            }
            return null;
        }
    }
}