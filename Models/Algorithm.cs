using System;

namespace NinjasInSpace.Models {
    public class Algorithm {
        public bool FirstChallenge (Hero player) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine ("You have been hit by a MathAttack! You must solve for the following equations to survive!");
            Console.ResetColor ();
            Console.WriteLine ("\nPredect the output of the following problem.\n\nint[] Arr = { 1, 2, 3, 4, 5, 6, 9 };\nint Val = Arr[0];\nfor (int i = 0; i < Arr.Length; i++) {\nif (Arr[i] > Val) {\n}\nConsole.WriteLine (Val);\n}");
            string response = Console.ReadLine ();
            while (response != "9") {
                Console.WriteLine ("Your Answer Prooves to be false!");
                int dmg = 10 - player.Intelligence;
                player.Intelligence -= 1;
                player.TakeDamage (dmg);
                response = Console.ReadLine ();
                if (player.Health <= 0) {
                    IsDead ();
                }
            }
            if (response == "9") {
                player.Intelligence += 4;
                return true;
            } else {
                return false;
            }
        }
        public void IsDead () {
            Console.WriteLine ("You have died. You and your team will be lost in space forever.\n\n press enter to exit.");
            ConsoleKey end = Console.ReadKey (true).Key;
            while (end != ConsoleKey.Enter) {
                end = Console.ReadKey (true).Key;
                Console.Clear ();
                Environment.Exit (0);
            }
        }
    }
}