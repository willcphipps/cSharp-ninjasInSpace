using System;
using NinjasInSpace.Models;

namespace NinjasInSpace {
    class Program {
        static void Main (string[] args) {
            Algorithm algo = new Algorithm ();
            Story s1 = new Story ();
            SetUp p1 = new SetUp ();
            ConsoleYellow ("********NINJAS IN SPACE********");
            Hero player = p1.PlayerSetup ();
            ConsoleYellow ($"You, {player.Name}, have been chosen(randomly selected) to join a team of developer ninjas on a space quest!  To seek out new algorithms, new data structures, and go where no else wants to go! DEEP SPACE!!!\n\nHere you will encounter aliens, space monsters, and the unknown to bring back algorithms to benefit all humans. You now must choose your team.\n\nPress Enter to Start");
            ConsoleKey key = Console.ReadKey (true).Key;
            while (key != ConsoleKey.Enter) {
                key = Console.ReadKey (true).Key;
            }
            s1.FirstPlanet (player, algo);

            // Console.WriteLine ("You have died. You and your team will be lost in space forever.\n\n press enter to exit.");
            // ConsoleKey end = Console.ReadKey (true).Key;
            // while (end != ConsoleKey.Enter) {
            //     end = Console.ReadKey (true).Key;
            //     Console.Clear ();
            //     Environment.Exit (0);
            // }

            // algo.FirstChallenge ();

            //write a method that will create other team mates.

            // make a game(while) loop to run your game
        }

        static void ConsoleYellow (string text) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine (text);
            Console.ResetColor ();
        }

    }
}