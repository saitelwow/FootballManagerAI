using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FootballManagerAI.Model
{
    public class Player
    {
        #region Atrybuty
        private string[] _attr;
        public string[] Attr { get { return _attr; } set { _attr = value; } }
        private double _overall = 0;
        public double Overall { get { return _overall; } set { _overall = value; } }
        #endregion
        public Player() { }
        public Player(string[] arg)
        {
            Attr = arg;
        }
        #region Metody
        public void CalcOverall(int[] impInd, int[] veryImpInd)
        {
            Overall = UtilityAI.CalcImp(impInd, Attr) + UtilityAI.CalcVeryImp(veryImpInd, Attr);
            Overall = Math.Round(Overall, 8);
        }
        #endregion
    }
}
