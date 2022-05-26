using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerAI.Model
{
    internal static class LBAttributes
    {
        #region Atrybuty
        private static string[] _gkAtt = {"AerialAbility", "CommandOfArea", "Communication", "Eccentricity", "FirstTouch",
                                    "Handling", "Kicking", "OneOnOnes", "Passing" , "PenaltyTaking", "Reflexes",
                                    "RushingOut", "TendencyToPunch", "Throwing" };
        private static string[] _techAtt = { "Corners", "Crossing", "Dribbling", "Finishing", "FirstTouch", "Freekicks",
                                        "Heading", "LongShots", "Longthrows", "Marking", "Passing", "PenaltyTaking", "Tackling", "Technique" };
        private static string[] _mentalAtt = { "Aggression", "Anticipation", "Bravery", "Composure", "Concentration", "Vision", "Decisions", "Determination",
                                                "Flair", "Leadership", "OffTheBall", "Positioning", "Teamwork", "Workrate"};
        private static string[] _physAtt = { "Acceleration", "Agility", "Balance", "Jumping", "NaturalFitness", "Pace", "Stamina", "Strength" };
        #endregion
        static LBAttributes() { }
        #region Gettery i Settery
        public static string[] GkAtt { get { return _gkAtt; } set { _gkAtt = value; } }
        public static string[] TechAtt { get { return _techAtt; } set { _techAtt = value; } }
        public static string[] MentalAtt { get { return _mentalAtt; } set { _mentalAtt = value; } }
        public static string[] PhysAtt { get { return _physAtt; } set { _physAtt = value; } }
        #endregion
    }
}
