using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerAI.ViewModel
{
    using Model;
    using View;
    using System.Windows.Controls;
    using Microsoft.Win32;
    using System.Collections.ObjectModel;
    using System.Windows;
    using System.ComponentModel;

    internal class RightPanelVM : BaseVM
    {
        public PanelM Panel { get; set; }
        public RightPanelVM(PanelM arg)
        {
            Panel = arg;
        }
        #region Atrybuty
        private List<Player> listOfPlayers = new List<Player>();
        private List<Player> tempList;
        private ObservableCollection<string> _calculatedPlayers = new ObservableCollection<string>();
        private string _selectedCalculatedPlayer;
        private bool _baseIsLoad = false;
        #endregion
        #region Gettery i Settery
        public List<Player> ListOfPlayers
        {
            get { return listOfPlayers; }
            set { listOfPlayers = value; }
        }
        public List<Player> TempList
        {
            get { return tempList; }
            set { tempList = value; }
        }
        public ObservableCollection<string> CalculatedPlayers
        {
            get { return _calculatedPlayers; }
            set { _calculatedPlayers = value; OnPropertyChanged(nameof(CalculatedPlayers)); }
        }
        public string SelectedCalculatedPlayer
        {
            get { return _selectedCalculatedPlayer; }
            set { _selectedCalculatedPlayer = value; OnPropertyChanged(nameof(SelectedCalculatedPlayer)); }
        }
        #endregion
        #region Metody
        public void LoadBase(object sender)
        {
            if (_baseIsLoad) return;
            string path = "dataset.csv";
            ListOfPlayers = UtilityAI.Read(path);
            MessageBox.Show("Baza została załadowana.");
            _baseIsLoad = true;
        }
        public void checkClick(object sender)
        {
            if (!_baseIsLoad)
            {
                MessageBox.Show("Żadna baza nie została załadowana."); return;
            }
            if (Panel.ImpAttributes.Count == 0 && Panel.VeryImpAttributes.Count == 0)
            {
                MessageBox.Show("Wybierz co najmniej jeden atrybut jako ważny lub bardzo ważny.");
                return;
            }
            TempList = new List<Player>(ListOfPlayers);
            CalculatedPlayers.Clear();
            MessageBox.Show("Przedział wiekowy: " + Panel.SelectedMinAge.ToString() + " - " + Panel.SelectedMaxAge.ToString() + "\n"
                + "Przedział wzrostu: " + Panel.SelectedMinHeight.ToString() + " - " + Panel.SelectedMaxHeight.ToString() + "\n"
                + "Pozycja: " + Panel.SelectedPosition);
            TempList = UtilityAI.ClearList(Panel.SelectedMinAge, Panel.SelectedMaxAge, Panel.SelectedMinHeight,
                Panel.SelectedMaxHeight, Panel.SelectedPosition, TempList);
            if (TempList.Count <= 0)
            {
                MessageBox.Show("Nie znalazło nikogo.");
                return;
            }
            TempList = UtilityAI.Calculate(Panel.ImpAttributes, Panel.VeryImpAttributes, TempList);
            TempList = TempList.OrderByDescending(o => o.Overall).ToList();          
            for (int i = 0; i < TempList.Count; i++)
            {
                CalculatedPlayers.Add(TempList.ElementAt(i).Attr[1].ToString());
                if (i == 9) break;
            }
        }
        #endregion
    }
}
