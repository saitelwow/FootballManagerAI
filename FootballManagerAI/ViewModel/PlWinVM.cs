using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerAI.ViewModel
{
    using Model;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Timers;
    using System.Windows;
    using View;
    internal class PlWinVM : BaseVM
    {
        #region Atrybuty
        private ObservableCollection<string> gkTechAttr = new ObservableCollection<string>();
        private ObservableCollection<string> gkTechNbs = new ObservableCollection<string>();
        private ObservableCollection<string> mentalAttr = new ObservableCollection<string>();
        private ObservableCollection<string> mentalNbs = new ObservableCollection<string>();
        private ObservableCollection<string> physAttr = new ObservableCollection<string>();
        private ObservableCollection<string> physNbs = new ObservableCollection<string>();
        private string _playerPosition;
        private string[] _attributesOfPlayer;
        private string _playerName;
        private string _age;
        private string _height;
        #endregion

        #region Gettery i Settery
        public ObservableCollection<string> GkTechAttr { get { return gkTechAttr; } set { gkTechAttr = value; OnPropertyChanged(nameof(GkTechAttr)); } }
        public ObservableCollection<string> GkTechNbs { get { return gkTechNbs; } set { gkTechNbs = value; OnPropertyChanged(nameof(GkTechNbs)); } }
        public ObservableCollection<string> MentalAttr { get { return mentalAttr; } set { mentalAttr = value; OnPropertyChanged(nameof(MentalAttr)); } }
        public ObservableCollection<string> MentalNbs { get { return mentalNbs; } set { mentalNbs = value; OnPropertyChanged(nameof(MentalNbs)); } }
        public ObservableCollection<string> PhysAttr { get { return physAttr; } set { physAttr = value; OnPropertyChanged(nameof(PhysAttr)); } }
        public ObservableCollection<string> PhysNbs { get { return physNbs; } set { physNbs = value; OnPropertyChanged(nameof(PhysNbs)); } }
        public string PlayerPosition { get { return _playerPosition; } set { _playerPosition = value; OnPropertyChanged(nameof(PlayerPosition)); } }
        public string[] AttributesOfPlayer { get { return _attributesOfPlayer; } set { _attributesOfPlayer = value; OnPropertyChanged(nameof(AttributesOfPlayer)); } }
        public string PlayerName { get { return _playerName; } set { _playerName = value; OnPropertyChanged(nameof(PlayerName)); } }
        public string Age { get { return _age; } set { _age = value; OnPropertyChanged(nameof(Age)); } }
        public string Height { get { return _height; } set { _height = value; OnPropertyChanged(nameof(Height)); } }
        #endregion

        #region Metody   
        public void SetInfo(Player setPlayer, string position)
        {
            GkTechAttr.Clear(); GkTechNbs.Clear(); MentalAttr.Clear(); MentalNbs.Clear(); PhysAttr.Clear(); PhysNbs.Clear();
            AttributesOfPlayer = setPlayer.Attr;
            PlayerPosition = position;
            PlayerName = setPlayer.Attr[UtilityAI.SearchIndex("Name", UtilityAI.firstLine)];
            Age = setPlayer.Attr[UtilityAI.SearchIndex("Age", UtilityAI.firstLine)];
            Height = setPlayer.Attr[UtilityAI.SearchIndex("Height", UtilityAI.firstLine)];
            if (position == "Goalkeeper")
            {
                foreach (string att in LBAttributes.GkAtt)
                {
                    GkTechAttr.Add(att);
                    GkTechNbs.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
                }
            }
            else
            {
                foreach (string att in LBAttributes.TechAtt)
                {
                    GkTechAttr.Add(att);
                    GkTechNbs.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
                }
            }
            foreach (string att in LBAttributes.MentalAtt)
            {
                MentalAttr.Add(att);
                MentalNbs.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
            }
            foreach (string att in LBAttributes.PhysAtt)
            {
                PhysAttr.Add(att);
                PhysNbs.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
            }
        }
        public void OpenWindow(object sender)
        {
            if (RightPanel.SelectedCalculatedPlayer == null) return;
            SetInfo(RightPanel.TempList.ElementAt(RightPanel.CalculatedPlayers.IndexOf(RightPanel.SelectedCalculatedPlayer)),Panel.SelectedPosition);

            PIW = new PlayerInfoWindow();
            PIW.DataContext = this;
            PIW.Show();
            RightPanel.SelectedCalculatedPlayer = null;           
        }
        #endregion
        PlayerInfoWindow PIW { get; set; }
        PanelM Panel { get; set; }
        RightPanelVM RightPanel { get; set; }
        public PlWinVM(PanelM arg, RightPanelVM rpvmarg)
        {
            Panel = arg;
            RightPanel = rpvmarg;
        }
        public PlWinVM() { }
    }
}
