using FootballManagerAI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerAI.ViewModel
{
    internal class PlayerInfoWindowVM : BaseVM
    {
        public PlayerInfoWindowVM() { }
        #region Gettery i Settery
        public string PlayerPosition { get; set; }
        public string[] AttributesOfPlayer { get; set; }
        public string PlayerName { get; set; }
        public string PlayerAge { get; set; }
        public string PlayerHeight { get; set; }
        public ObservableCollection<string> GkTechAtts { get; set; }        //nazwy atrybutow ludzikow
        public ObservableCollection<string> GkTechNbs { get; set; }         //liczby do kazdego atrybutu
        public ObservableCollection<string> MentalAtts { get; set; }
        public ObservableCollection<string> MentalNbs { get; set; }
        public ObservableCollection<string> PhysAtts { get; set; }
        public ObservableCollection<string> PhysNbs { get; set; }
        #endregion
        #region Metody
        public void SetInfo(Player setPlayer, string position)
        {
            AttributesOfPlayer = setPlayer.Attr;
            PlayerPosition = position;
            PlayerName = setPlayer.Attr[UtilityAI.SearchIndex("Name", UtilityAI.firstLine)];
            PlayerAge = setPlayer.Attr[UtilityAI.SearchIndex("Age", UtilityAI.firstLine)];
            PlayerHeight = setPlayer.Attr[UtilityAI.SearchIndex("Height", UtilityAI.firstLine)];
            if (position == "Goalkeeper")
            {
                foreach (string att in LBAttributes.GkAtt)
                {
                    GkTechAtts.Add(att);
                    GkTechNbs.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
                }
            }
            else
            {
                foreach (string att in LBAttributes.TechAtt)
                {
                    GkTechAtts.Add(att);
                    GkTechNbs.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
                }
            }
            foreach (string att in LBAttributes.MentalAtt)
            {
                MentalAtts.Add(att);
                MentalNbs.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
            }
            foreach (string att in LBAttributes.PhysAtt)
            {
                PhysAtts.Add(att);
                PhysNbs.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
            }
        }
        #endregion
    }
}
