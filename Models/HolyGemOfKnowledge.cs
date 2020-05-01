using NinjasInSpace.Interfaces;

namespace NinjasInSpace.Models {
    public class HolyGemOfKnowledge : ISolvable {
        private string name { get; set; }
        private string planetOrigin { get; set; }
        private int challengeLevel { get; set; }
        private string monster { get; set; }

        public string Name {
            get { return name; }
            set { this.name = value; }
        }
        public string PlanetOrigin
        {
            get { return planetOrigin; }
            set { this.planetOrigin = value; }
        }
        public int ChallengeLevel
        {
            get { return challengeLevel; }
            set { this.challengeLevel = challengeLevel; }
        }
        public string Monster
        {
            get { return monster; }
            set { this.monster = monster; }
        }

        public HolyGemOfKnowledge (string name, string planet, int hard, string monst) {
            Name = name;
            PlanetOrigin = planet;
            ChallengeLevel = hard;
            Monster = monst;
        }

    }
}