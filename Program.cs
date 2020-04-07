using System;
using NinjasInSpace.Models;

namespace NinjasInSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleYellow("********NINJAS IN SPACE********");

            Hero player = PlayerSetup();
            
            ConsoleYellow($"You, {player.Name}, have been chosen(randomly selected) to join a team of developer ninjas on a space quest!  To seek out new algorithms, new data structures, and go where no else wants to go! DEEP SPACE!!!\n\nHere you will encounter aliens, space monsters, and the unknown to bring back algorithms to benefit all humans. You now must choose your team.");

            //write a method that will create other team mates.

            // make a game(while) loop to run your game
        }

        static void ConsoleYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static Hero PlayerSetup()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            string choice = "0";

            while( choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Please type the number of the hero you would ike to be?\n1. Ninja\n2. Wizard\n3. Sensei");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case("1"):
                    Ninja ninjaHero = new Ninja(name);
                    return ninjaHero;
                case("2"):
                    // Change Ninja to another class of hero.
                    Ninja wizardHero = new Ninja(name);
                    return wizardHero;
                case("3"):
                    // Change Ninja to another class of hero.
                    Ninja senseiHero = new Ninja(name);
                    return senseiHero;
            }
            return null;
        }


        


    }
}
