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
        private double CalcImp(int[] indexes)
        {
            double res = 0;
            foreach (int index in indexes)
            {
                res += (Convert.ToDouble(Attr[index]) / 20);
            }
            return res;
        }
        private double CalcVeryImp(int[] indexes)
        {
            double res = 0;
            foreach (int index in indexes)
            {
                res += Math.Pow((Convert.ToDouble(Attr[index]) / 20), 2);
            }
            return res;
        }
        public void CalcOverall(int[] impInd, int[] veryImpInd)
        {
            Overall = CalcImp(impInd) + CalcVeryImp(veryImpInd);
            Overall = Math.Round(Overall, 8);
        }
        #endregion
    }
}
