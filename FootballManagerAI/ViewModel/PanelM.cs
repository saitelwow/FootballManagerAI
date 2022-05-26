using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;

namespace FootballManagerAI.ViewModel
{
    using Model;
    using View;
    using System.Windows.Controls;
    using Microsoft.Win32;
    internal class PanelM : BaseVM
    {
        #region Atrybuty
        private readonly int[] _minAges = new int[41];
        private readonly int[] _maxAges = new int[41];
        private int _selectedMinAge, _selectedMaxAge;
        private readonly int[] _minHeights = new int[62];
        private readonly int[] _maxHeights = new int[62];
        private int _selectedMinHeight, _selectedMaxHeight;
        private readonly string[] _positions = {"Goalkeeper", "Sweeper", "DefenderLeft", "DefenderCentral", "DefenderRight", "WingBackLeft",
            "DefensiveMidfielder", "WingBackRight", "MidfielderLeft", "MidfielderCentral", "MidfielderRight",
         "AttackingMidLeft", "AttackingMidRight", "AttackingMidCentral", "Striker"};
        private string _selectedPosition;
        private ObservableCollection<string> _normalAttributes, _impAttributes, _veryImpAttributes;
        private string _normalSelectedItem, _impSelectedItem, _veryimpSelectedItem;
        #endregion
        public PanelM()
        {
            for(int i = 13; i < 54; i++)
            { 
                MinAges[i - 13] = i + 1;
                MaxAges[i - 13] = i + 1;
            }
            for(int i = 149; i < 210; i++)
            {
                MinHeights[i - 149] = i;
                MaxHeights[i - 149] = i;
            }
            SelectedMinAge = MinAges[0];
            SelectedMaxAge = MaxAges[0];
            SelectedMinHeight = MinHeights[0];
            SelectedMaxHeight = MaxHeights[0];
            SelectedPosition = Positions[0];
            NormalAttributes = LoadAtt(SelectedPosition);
            NormalSelectedItem = null;
            ImpAttributes = new ObservableCollection<string>();
            ImpSelectedItem = null;
            VeryImpAttributes = new ObservableCollection<string>();
            VeryImpSelectedItem = null;
        }
        #region Gettery i Settery
        #region Age
        public int[] MinAges { get { return _minAges; } }
        public int[] MaxAges { get { return _maxAges; } }
        public int SelectedMinAge { get { return _selectedMinAge; } set { _selectedMinAge = value; OnPropertyChanged(nameof(SelectedMinAge)); } }
        public int SelectedMaxAge { get { return _selectedMaxAge; } set { _selectedMaxAge = value; OnPropertyChanged(nameof(SelectedMaxAge)); } }
        #endregion
        #region Height
        public int[] MinHeights { get { return _minHeights; } }
        public int[] MaxHeights { get { return _maxHeights; } }
        public int SelectedMinHeight { get { return _selectedMinHeight; } set { _selectedMinHeight = value; OnPropertyChanged(nameof(SelectedMinHeight)); } }
        public int SelectedMaxHeight { get { return _selectedMaxHeight; } set { _selectedMaxHeight = value; OnPropertyChanged(nameof(SelectedMaxHeight)); } }
        #endregion
        #region Position
        public string[] Positions { get { return _positions; } }
        public string SelectedPosition { get { return _selectedPosition; } set { _selectedPosition = value; OnPropertyChanged(nameof(SelectedPosition)); } }
        #endregion
        #region LBy
        public ObservableCollection<string> NormalAttributes
        {
            get { return _normalAttributes; }
            set { _normalAttributes = value; OnPropertyChanged(nameof(NormalAttributes)); }
        }
        public string NormalSelectedItem
        {
            get { return _normalSelectedItem; }
            set { _normalSelectedItem = value; OnPropertyChanged(nameof(NormalSelectedItem)); }
        }
        public ObservableCollection<string> ImpAttributes
        {
            get { return _impAttributes; }
            set { _impAttributes = value; OnPropertyChanged(nameof(ImpAttributes)); }
        }
        public string ImpSelectedItem
        {
            get { return _impSelectedItem; }
            set { _impSelectedItem = value; OnPropertyChanged(nameof(ImpSelectedItem)); }
        }
        public ObservableCollection<string> VeryImpAttributes
        {
            get { return _veryImpAttributes; }
            set { _veryImpAttributes = value; OnPropertyChanged(nameof(VeryImpAttributes)); }
        }
        public string VeryImpSelectedItem
        {
            get { return _veryimpSelectedItem; }
            set { _veryimpSelectedItem = value; OnPropertyChanged(nameof(VeryImpSelectedItem)); }
        }
        #endregion
        #endregion
        #region Metody
        #region Inne
        private bool CheckAges()
        {
            if (SelectedMinAge > SelectedMaxAge) return false;
            return true;
        }
        private bool CheckHeights()
        {
            if (SelectedMinHeight > SelectedMaxHeight) return false;
            return true;
        }
        private void SetDefault(int arg)
        {
            if (arg == 1)
            {
                SelectedMinAge = MinAges[0]; SelectedMaxAge = MaxAges[0];
            }
            if (arg == 2)
            {
                SelectedMinHeight = MinHeights[0]; SelectedMaxHeight = MaxHeights[0];
            }
        }
        private void ClearLBs()
        {
            NormalAttributes = LoadAtt(SelectedPosition);
            if (ImpAttributes.Count > 0)
            {
                ImpAttributes.Clear();
            }
            if (VeryImpAttributes.Count > 0)
            {
                VeryImpAttributes.Clear();
            }
        }
        #endregion
        #region Zmiany atrybutów
        public void minAgeChanged(object sender)
        {
            if (!CheckAges())
            {
                MessageBox.Show("Wartość maksymalna nie może być mniejsza od minimalnej.");
                SetDefault(1);
                return;
            }
        }
        public void maxAgeChanged(object sender)
        {
            if (!CheckAges())
            {
                MessageBox.Show("Wartość maksymalna nie może być mniejsza od minimalnej.");
                SetDefault(1);
                return;
            }
        }
        public void positionChanged(object sender)
        {
            ClearLBs();
        }
        public void minHeightChanged(object sender)
        {
            if (!CheckHeights())
            {
                MessageBox.Show("Wartość maksymalna nie może być mniejsza od minimalnej.");
                SetDefault(2);
                return;
            }
        }
        public void maxHeightChanged(object sender)
        {
            if (!CheckHeights())
            {
                MessageBox.Show("Wartość maksymalna nie może być mniejsza od minimalnej.");
                SetDefault(2);
                return;
            }
        }

        public void normalItemChanged(object sender)
        {
            
        }
        public void impItemChanged(object sender)
        {
            //MessageBox.Show(ImpSelectedItem);
            //SelectedCalculatedPlayer = null;
        }
        public void veryImpItemChanged(object sender)
        {
            //MessageBox.Show(VeryImpSelectedItem);
            //SelectedCalculatedPlayer = null;
        }
        #endregion
        public ObservableCollection<string> LoadAtt(string arg_position)
        {
            ObservableCollection<string> elements = new ObservableCollection<string>();
            if (arg_position == "Goalkeeper")
            {
                foreach (string att in LBAttributes.GkAtt)
                {
                    elements.Add(att);
                }
            }
            else
            {
                foreach (string att in LBAttributes.TechAtt)
                {
                    elements.Add(att);
                }
            }
            foreach (string att in LBAttributes.MentalAtt)
            {
                elements.Add(att);
            }
            foreach (string att in LBAttributes.PhysAtt)
            {
                elements.Add(att);
            }
            return elements;           
        }
        #endregion
    }
}
