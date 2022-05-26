using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FootballManagerAI.ViewModel
{
    using View;
    class MainVM : BaseVM
    {
        public PanelM Panel { get; set; }
        public RightPanelVM RightPanel { get; set; }
        public PlayerInfoWindowVM Piw { get; set; }
        public MainVM()
        {
            Panel = new PanelM();
            RightPanel = new RightPanelVM(Panel);
            Piw = new PlayerInfoWindowVM();
        }
        #region ICommandy
        #region Age
        private ICommand _minAgeChanged = null;
        public ICommand MinAgeChanged
        {
            get
            {
                if (_minAgeChanged == null)
                {
                    _minAgeChanged = new RelayCommand(Panel.minAgeChanged, arg => true);
                }
                return _minAgeChanged;
            }
        }
        private ICommand _maxAgeChanged = null;
        public ICommand MaxAgeChanged
        {
            get
            {
                if (_maxAgeChanged == null)
                {
                    _maxAgeChanged = new RelayCommand(Panel.maxAgeChanged, arg => true);
                }
                return _maxAgeChanged;
            }
        }
        #endregion
        #region Position
        private ICommand _positionChanged = null;
        public ICommand PositionChanged
        {
            get
            {
                if (_positionChanged == null)
                {
                    _positionChanged = new RelayCommand(Panel.positionChanged, arg => true);
                }
                return _positionChanged;
            }
        }
        #endregion
        #region Height
        private ICommand _minHeightChanged = null;
        public ICommand MinHeightChanged
        {
            get
            {
                if (_minHeightChanged == null)
                {
                    _minHeightChanged = new RelayCommand(Panel.minHeightChanged, arg => true);
                }
                return _minHeightChanged;
            }
        }
        private ICommand _maxHeightChanged = null;
        public ICommand MaxHeightChanged
        {
            get
            {
                if (_maxHeightChanged == null)
                {
                    _maxHeightChanged = new RelayCommand(Panel.maxHeightChanged, arg => true);
                }
                return _maxHeightChanged;
            }
        }
        #endregion
        #region LBy
        private ICommand _normalItemChanged = null;
        public ICommand NormalItemChanged
        {
            get
            {
                if (_normalItemChanged == null)
                {
                    _normalItemChanged = new RelayCommand(Panel.normalItemChanged, arg => true);
                }
                return _normalItemChanged;
            }
        }
        private ICommand _impItemChanged = null;
        public ICommand ImpItemChanged
        {
            get
            {
                if (_impItemChanged == null)
                {
                    _impItemChanged = new RelayCommand(Panel.impItemChanged, arg => true);
                }
                return _impItemChanged;
            }
        }
        private ICommand _veryImpItemChanged = null;
        public ICommand VeryImpItemChanged
        {
            get
            {
                if (_veryImpItemChanged == null)
                {
                    _veryImpItemChanged = new RelayCommand(Panel.veryImpItemChanged, arg => true);
                }
                return _veryImpItemChanged;
            }
        }
        private ICommand _calcPlayerChanged = null;
        public ICommand CalcPlayerChanged
        {
            get
            {
                if (_calcPlayerChanged == null)
                {
                    _calcPlayerChanged = new RelayCommand(RightPanel.calcPlayerChanged, arg => true);
                }
                return _calcPlayerChanged;
            }
        }
        #endregion
        #region Clicki
        #region PanelM
        private ICommand _addNormalImpClick = null;
        public ICommand AddNormalImpClick
        {
            get
            {
                if (_addNormalImpClick == null)
                {
                    _addNormalImpClick = new RelayCommand(addNormalImpClick,
                        arg => true
                        );
                }
                return _addNormalImpClick;
            }
        }

        private ICommand _remNormalImpClick = null;
        public ICommand RemNormalImpClick
        {
            get
            {
                if (_remNormalImpClick == null)
                {
                    _remNormalImpClick = new RelayCommand(remNormalImpClick,
                        arg => true
                        );
                }
                return _remNormalImpClick;
            }
        }
        private ICommand _addImpVeryImpClick = null;
        public ICommand AddImpVeryImpClick
        {
            get
            {
                if (_addImpVeryImpClick == null)
                {
                    _addImpVeryImpClick = new RelayCommand(addImpVeryImpClick,
                        arg => true
                        );
                }
                return _addImpVeryImpClick;
            }
        }
        private ICommand _remImpVeryImpClick = null;
        public ICommand RemImpVeryImpClick
        {
            get
            {
                if (_remImpVeryImpClick == null)
                {
                    _remImpVeryImpClick = new RelayCommand(remImpVeryImpClick,
                        arg => true
                        );
                }
                return _remImpVeryImpClick;
            }
        }
        #endregion
        #region RightPanel
        private ICommand _checkClick = null;
        public ICommand CheckClick
        {
            get
            {
                if (_checkClick == null)
                {
                    _checkClick = new RelayCommand(RightPanel.checkClick, arg => true);
                }
                return _checkClick;
            }
        }
        private ICommand _loadClick = null;
        public ICommand LoadClick
        {
            get
            {
                if (_loadClick == null)
                {
                    _loadClick = new RelayCommand(RightPanel.LoadBase, arg => true);
                }
                return _loadClick;
            }
        }
        #endregion
        #endregion
        #region AddRemClicki
        public void addNormalImpClick(object sender)
        {
            if (Panel.NormalSelectedItem == null)
            {
                return;
            }
            //if (Panel.NormalSelectedItem != null && Panel.ImpSelectedItem != null)
            if (Panel.NormalSelectedItem != null && Panel.ImpSelectedItem != null)
            {
                Panel.NormalSelectedItem = null;
                Panel.ImpSelectedItem = null;
                Panel.VeryImpSelectedItem = null;
                return;
            }
            Panel.ImpAttributes.Add(Panel.NormalSelectedItem);
            Panel.NormalAttributes.Remove(Panel.NormalSelectedItem);
        }
        public void remNormalImpClick(object sender)
        {
            if (Panel.ImpSelectedItem == null)
            {
                return;
            }
            if (Panel.NormalSelectedItem != null && Panel.ImpSelectedItem != null)
            {
                Panel.NormalSelectedItem = null;
                Panel.ImpSelectedItem = null;
                Panel.VeryImpSelectedItem = null;
                return;
            }
            Panel.NormalAttributes.Add(Panel.ImpSelectedItem);
            Panel.ImpAttributes.Remove(Panel.ImpSelectedItem);
        }
        public void addImpVeryImpClick(object sender)
        {
            if (Panel.ImpSelectedItem == null)
            {
                return;
            }
            if (Panel.ImpSelectedItem != null && Panel.VeryImpSelectedItem != null)
            {
                Panel.NormalSelectedItem = null;
                Panel.ImpSelectedItem = null;
                Panel.VeryImpSelectedItem = null;
                return;
            }
            Panel.VeryImpAttributes.Add(Panel.ImpSelectedItem);
            Panel.ImpAttributes.Remove(Panel.ImpSelectedItem);
        }
        public void remImpVeryImpClick(object sender)
        {
            if (Panel.VeryImpSelectedItem == null)
            {
                return;
            }
            if (Panel.ImpSelectedItem != null && Panel.VeryImpSelectedItem != null)
            {
                Panel.NormalSelectedItem = null;
                Panel.ImpSelectedItem = null;
                Panel.VeryImpSelectedItem = null;
                return;
            }
            Panel.ImpAttributes.Add(Panel.VeryImpSelectedItem);
            Panel.VeryImpAttributes.Remove(Panel.VeryImpSelectedItem);
        }
        #endregion
        #endregion

    }
}
