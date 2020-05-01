using System;

namespace NinjasInSpace.Models {
    public class Wizard : Hero {
        public Wizard (string name) : base (name) {
            Intelligence = 10;
        }
        public override void SayName () 
        {
            Console.WriteLine ($"Hello My name is {Name}, and I'm a Wizard.");
        }

    }
}