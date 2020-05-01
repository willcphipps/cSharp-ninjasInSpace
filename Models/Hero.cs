using System;

namespace NinjasInSpace.Models {
    public abstract class Hero {
        public string Name;
        public int Dexterity;
        public int Strength;
        public int Speed;
        public int Intelligence;
        protected int health;
        public int Health {
            get { return health; }
        }

        public Hero (string name) {
            Name = name;
            Dexterity = 5;
            Strength = 5;
            Speed = 5;
            Intelligence = 2;
            health = 100;

        }
        public void TakeDamage (int dmg) {
            health -= dmg;
        }

        public abstract void SayName ();

        public virtual void ShowStats () {
            Console.WriteLine ($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }

    }
}