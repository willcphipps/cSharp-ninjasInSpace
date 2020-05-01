using System;

namespace NinjasInSpace.Models {
    public class Sensei : Hero {
        public Sensei (string name) : base (name) {
            Strength = 10;
        }
        public override void SayName () {
            Console.WriteLine ($"Hello My name is {Name}, and I'm a Sensei.");
        }

    }
}