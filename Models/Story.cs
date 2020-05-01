using System;
namespace NinjasInSpace.Models {
    public class Story {
        static void ConsoleBlue (string text) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine (text);
            Console.ResetColor ();
        }
        public void FirstPlanet (Hero player, Algorithm algo) {
            ConsoleBlue ("You have entered into the solar system of Kepler-69c. \nKepler-69c is a planet with a known circumstellar habitable zone roughly 12 billion lightyears away from earth.");
            Console.WriteLine ("pretty cool, huh?!\n1. Yes \n2. No");
            string choice = "0";
            while (choice != "1" && choice != "2") {
                choice = Console.ReadLine ();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (choice == "1") {
                Console.WriteLine ("Totally! A 'circumstellar habitable zone' (also known as a goldilox zone) is an area around certain stars in the universe that is hospitable to life as we know it.\nScientists estimate there are billions upon billions of planets and stars in the universe.");
            } else {
                Console.WriteLine ("Either way there are alot of stars in the Universe! Good thing we found one with some life on it!");
            }
            Console.ResetColor ();
            Console.WriteLine ("\n\nShould we take a look at this one?\n1. Yes\n2. No");
            choice = "0";
            while (choice != "1" && choice != "2") {
                choice = Console.ReadLine ();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (choice == "1") {
                Console.WriteLine ("When you land on Keplar you are attacked by space pirates, who attack you with an algorithm! You must solve this algorithm if you want to survive.\n\nGet ready! Press Enter when you are prepared.");
                ConsoleKey key = Console.ReadKey (true).Key;
                while (key != ConsoleKey.Enter) {
                    key = Console.ReadKey (true).Key;
                }
                algo.FirstChallenge (player);
            } else {
                SecondPlanet (player, algo);
            }
        }
    public void SecondPlanet (Hero hero, Algorithm math)
    {
        Console.WriteLine ("This is working?");
        ConsoleBlue ("Welcome to the second planet!");
    }
}
}