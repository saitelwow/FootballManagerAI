using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FootballManagerAI.Model
{
    using System.Collections.ObjectModel;
    
    internal static class UtilityAI
    {
        #region Atrybuty
        public static string[] firstLine;
        #endregion
        static UtilityAI() { }
        #region Metody
        public static int SearchIndex(string searched, string[] dbRow)
        {
            return Array.IndexOf(dbRow, searched);
        }
        public static List<Player> Read(string arg_path)
        {
            List<Player> listOfPlayers = new List<Player>();
            try
            {
                using (var reader = new StreamReader(arg_path))
                {
                    firstLine = reader.ReadLine().Split(",");
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(",");
                        listOfPlayers.Add(new Player(values));
                    }
                }
                return listOfPlayers;
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message);
                return listOfPlayers;
            }
        }
        public static List<Player> ClearList(int minAge, int maxAge, int minHeight, int maxHeight, string selectedPosition, List<Player> argList)
        {
            int positionIndex = SearchIndex(selectedPosition, firstLine);
            foreach (Player pl in argList.ToList())
            {
                if (Convert.ToInt64(pl.Attr[positionIndex]) < 18)
                {
                    argList.Remove(pl);
                }
            }
            int ageIndex = SearchIndex("Age", firstLine);
            foreach (Player pl in argList.ToList())
            {
                if (!((minAge <= Convert.ToInt64(pl.Attr[ageIndex])) && (Convert.ToInt64(pl.Attr[ageIndex]) <= maxAge)))
                {
                    argList.Remove(pl);
                }
            }
            int heightIndex = SearchIndex("Height", firstLine);
            foreach (Player pl in argList.ToList())
            {
                if (!((minHeight <= Convert.ToInt64(pl.Attr[heightIndex])) && (Convert.ToInt64(pl.Attr[heightIndex]) <= maxHeight)))
                {
                    argList.Remove(pl);
                }
            }
            return argList;
        }
        public static List<Player> Calculate(ObservableCollection<string> impAtt, ObservableCollection<string> veryImpAtt,
            List<Player> argListofPlayers)
        {
            int[] impAttIndexes = new int[impAtt.Count];
            int[] veryImpAttIndexes = new int[veryImpAtt.Count];
            for (int i = 0; i < impAtt.Count; i++)
            {
                impAttIndexes[i] = SearchIndex(impAtt.ElementAt(i), firstLine);
            }
            for (int i = 0; i < veryImpAtt.Count; i++)
            {
                veryImpAttIndexes[i] = SearchIndex(veryImpAtt.ElementAt(i), firstLine);
            }
            foreach (Player player in argListofPlayers)
            {
                player.CalcOverall(impAttIndexes, veryImpAttIndexes);
            }
            return argListofPlayers;
        }
        #endregion
    } 
}
