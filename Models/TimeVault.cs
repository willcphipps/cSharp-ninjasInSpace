using System;
using System.Collections.Generic;
using NinjasInSpace.Interfaces;

namespace NinjasInSpace.Models {
    public class TimeVault {
        private static List<ISolvable> _timeVault;

        //constructor
        public TimeVault () {
            _timeVault = new List<ISolvable> () 
            {
                new HolyGemOfKnowledge ("The First Algorithm", "String", 5, "string"),
            };
            
    }
}
}