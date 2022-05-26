using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FootballManagerAI.View
{
    public partial class FootballPanel : UserControl
    {
        public FootballPanel()
        {
            InitializeComponent();
        }
        #region Wlasnosci
        #region Ages
        public static readonly DependencyProperty MinAgesProperty = DependencyProperty.Register(
            "MinAges", typeof(int[]), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty MaxAgesProperty = DependencyProperty.Register(
            "MaxAges", typeof(int[]), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty CurrentMinAgeProperty = DependencyProperty.Register(
            "CurrentMinAge", typeof(int), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty CurrentMaxAgeProperty = DependencyProperty.Register(
            "CurrentMaxAge", typeof(int), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        #endregion
        #region Height
        public static readonly DependencyProperty MinHeightsProperty = DependencyProperty.Register(
           "MinHeights", typeof(int[]), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty MaxHeightsProperty = DependencyProperty.Register(
            "MaxHeights", typeof(int[]), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty CurrentMinHeightProperty = DependencyProperty.Register(
            "CurrentMinHeight", typeof(int), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty CurrentMaxHeightProperty = DependencyProperty.Register(
            "CurrentMaxHeight", typeof(int), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        #endregion
        #region Positions
        public static readonly DependencyProperty PositionsProperty = DependencyProperty.Register(
            "Positions", typeof(string[]), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty CurrentPositionProperty = DependencyProperty.Register(
            "CurrentPosition", typeof(string), typeof(FootballPanel), new FrameworkPropertyMetadata(null));
        #endregion
        #region LBy
        public static readonly DependencyProperty NormalItemsSourceProperty = DependencyProperty.Register(
            "NormalItemsSource", typeof(ObservableCollection<string>), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty NormalCurrentItemSourceProperty = DependencyProperty.Register(
            "NormalCurrentItemSource", typeof(string), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty ImpItemsSourceProperty = DependencyProperty.Register(
            "ImpItemsSource", typeof(ObservableCollection<string>), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty ImpCurrentItemSourceProperty = DependencyProperty.Register(
            "ImpCurrentItemSource", typeof(string), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty VeryImpItemsSourceProperty = DependencyProperty.Register(
            "VeryImpItemsSource", typeof(ObservableCollection<string>), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty VeryImpCurrentItemSourceProperty = DependencyProperty.Register(
            "VeryImpCurrentItemSource", typeof(string), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        #endregion
        #region Clicki
        public static readonly DependencyProperty AddNormalImpProperty = DependencyProperty.Register(
            "AddNormalImp", typeof(ICommand), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty RemNormalImpProperty = DependencyProperty.Register(
            "RemNormalImp", typeof(ICommand), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty AddImpVeryImpProperty = DependencyProperty.Register(
            "AddImpVeryImp", typeof(ICommand), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty RemImpVeryImpProperty = DependencyProperty.Register(
            "RemImpVeryImp", typeof(ICommand), typeof(FootballPanel), new FrameworkPropertyMetadata(null)
            );
        #endregion
        #endregion
        #region Gettery i Settery
        #region Ages
        public int[] MinAges
        {
            get { return (int[])GetValue(MinAgesProperty); }
            set { SetValue(MinAgesProperty, value); }
        }
        public int[] MaxAges
        {
            get { return (int[])GetValue(MaxAgesProperty); }
            set { SetValue(MaxAgesProperty, value); }
        }
        public int CurrentMinAge
        {
            get { return (int)GetValue(CurrentMinAgeProperty); }
            set { SetValue(CurrentMinAgeProperty, value); }
        }
        public int CurrentMaxAge
        {
            get { return (int)GetValue(CurrentMaxAgeProperty); }
            set { SetValue(CurrentMaxAgeProperty, value); }
        }
        #endregion
        #region Heights
        public int[] MinHeights
        {
            get { return (int[])GetValue(MinHeightsProperty); }
            set { SetValue(MinHeightsProperty, value); }
        }
        public int[] MaxHeights
        {
            get { return (int[])GetValue(MaxHeightsProperty); }
            set { SetValue(MaxHeightsProperty, value); }
        }
        public int CurrentMinHeight
        {
            get { return (int)GetValue(CurrentMinHeightProperty); }
            set { SetValue(CurrentMinHeightProperty, value); }
        }
        public int CurrentMaxHeight
        {
            get { return (int)GetValue(CurrentMaxHeightProperty); }
            set { SetValue(CurrentMaxHeightProperty, value); }
        }
        #endregion
        #region Positions
        public string[] Positions
        {
            get { return (string[])GetValue(PositionsProperty); }
            set { SetValue(PositionsProperty, value); }
        }
        public string CurrentPosition
        {
            get { return (string)GetValue(CurrentPositionProperty); }
            set { SetValue(CurrentPositionProperty, value); }
        }
        #endregion
        #region LBy
        public ObservableCollection<string> NormalItemsSource
        {
            get { return (ObservableCollection<string>)GetValue(NormalItemsSourceProperty); }
            set { SetValue(NormalItemsSourceProperty, value); }
        }
        public string NormalCurrentItemSource
        {
            get { return (string)GetValue(NormalCurrentItemSourceProperty); }
            set { SetValue(NormalCurrentItemSourceProperty, value); }
        }
        public ObservableCollection<string> ImpItemsSource
        {
            get { return (ObservableCollection<string>)GetValue(ImpItemsSourceProperty); }
            set { SetValue(ImpItemsSourceProperty, value); }
        }
        public string ImpCurrentItemSource
        {
            get { return (string)GetValue(ImpCurrentItemSourceProperty); }
            set { SetValue(ImpCurrentItemSourceProperty, value); }
        }
        public ObservableCollection<string> VeryImpItemsSource
        {
            get { return (ObservableCollection<string>)GetValue(VeryImpItemsSourceProperty); }
            set { SetValue(VeryImpItemsSourceProperty, value); }
        }
        public string VeryImpCurrentItemSource
        {
            get { return (string)GetValue(VeryImpCurrentItemSourceProperty); }
            set { SetValue(VeryImpCurrentItemSourceProperty, value); }
        }
        #endregion
        #region Clicki
        public ICommand AddNormalImp
        {
            get { return (ICommand)GetValue(AddNormalImpProperty); }
            set { SetValue(AddNormalImpProperty, value); }
        }
        public ICommand RemNormalImp
        {
            get { return (ICommand)GetValue(RemNormalImpProperty); }
            set { SetValue(RemNormalImpProperty, value); }
        }
        public ICommand AddImpVeryImp
        {
            get { return (ICommand)GetValue(AddImpVeryImpProperty); }
            set { SetValue(AddImpVeryImpProperty, value); }
        }
        public ICommand RemImpVeryImp
        {
            get { return (ICommand)GetValue(RemImpVeryImpProperty); }
            set { SetValue(RemImpVeryImpProperty, value); }
        }
        #endregion
        #endregion
        #region Eventy
        #region Age
        public static readonly RoutedEvent MinAgeChangedEvent =
            EventManager.RegisterRoutedEvent("OtherMinAgeSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler MinAgeChanged
        {
            add { AddHandler(MinAgeChangedEvent, value); }
            remove { RemoveHandler(MinAgeChangedEvent, value); }
        }
        void RaiseMinAgeChanged(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(MinAgeChangedEvent);
            RaiseEvent(args);
        }

        public static readonly RoutedEvent MaxAgeChangedEvent =
            EventManager.RegisterRoutedEvent("OtherMaxAgeSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler MaxAgeChanged
        {
            add { AddHandler(MaxAgeChangedEvent, value); }
            remove { RemoveHandler(MaxAgeChangedEvent, value); }
        }
        void RaiseMaxAgeChanged(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(MaxAgeChangedEvent);
            RaiseEvent(args);
        }
        #endregion
        #region Heights
        public static readonly RoutedEvent MinHeightChangedEvent =
            EventManager.RegisterRoutedEvent("OtherMinHeightSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler MinHeightChanged
        {
            add { AddHandler(MinHeightChangedEvent, value); }
            remove { RemoveHandler(MinHeightChangedEvent, value); }
        }
        void RaiseMinHeightChanged(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(MinHeightChangedEvent);
            RaiseEvent(args);
        }

        public static readonly RoutedEvent MaxHeightChangedEvent =
            EventManager.RegisterRoutedEvent("OtherMaxHeightSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler MaxHeightChanged
        {
            add { AddHandler(MaxHeightChangedEvent, value); }
            remove { RemoveHandler(MaxHeightChangedEvent, value); }
        }
        void RaiseMaxHeightChanged(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(MaxHeightChangedEvent);
            RaiseEvent(args);
        }
        #endregion
        #region Positions
        public static readonly RoutedEvent PositionChangedEvent =
            EventManager.RegisterRoutedEvent("OtherPositionSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler PositionChanged
        {
            add { AddHandler(PositionChangedEvent, value); }
            remove { RemoveHandler(PositionChangedEvent, value); }
        }
        
        void RaisePositionChangedEvent(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(PositionChangedEvent);
            RaiseEvent(args);
        }
        #endregion
        #region LBy
        public static readonly RoutedEvent NormalCurrentItemChangeEvent =
            EventManager.RegisterRoutedEvent("OtherNormalItemSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler NormalItemChanged
        {
            add { AddHandler(NormalCurrentItemChangeEvent, value); }
            remove { RemoveHandler(NormalCurrentItemChangeEvent, value); }
        }
        void RaiseNormalItemChanged(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(NormalCurrentItemChangeEvent);
            RaiseEvent(args);
        }

        public static readonly RoutedEvent ImpCurrentItemChangeEvent =
            EventManager.RegisterRoutedEvent("OtherImpItemSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler ImpItemChanged
        {
            add { AddHandler(ImpCurrentItemChangeEvent, value); }
            remove { RemoveHandler(ImpCurrentItemChangeEvent, value); }
        }
        void RaiseImpItemChanged(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(ImpCurrentItemChangeEvent);
            RaiseEvent(args);
        }

        public static readonly RoutedEvent VeryImpCurrentItemChangeEvent =
            EventManager.RegisterRoutedEvent("OtherVeryImpItemSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler VeryImpItemChanged
        {
            add { AddHandler(VeryImpCurrentItemChangeEvent, value); }
            remove { RemoveHandler(VeryImpCurrentItemChangeEvent, value); }
        }
        void RaiseVeryImpItemChanged(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(VeryImpCurrentItemChangeEvent);
            RaiseEvent(args);
        }
        #endregion
        #region Clicki
        public static readonly RoutedEvent AddNormalImpClickEvent =
            EventManager.RegisterRoutedEvent("OtherAddNormalImpClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler AddNormalImpClick
        {
            add { AddHandler(AddNormalImpClickEvent, value); }
            remove { RemoveHandler(AddNormalImpClickEvent, value); }
        }
        void RaiseAddNormalImpClick(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(AddNormalImpClickEvent);
            RaiseEvent(args);
        }

        public static readonly RoutedEvent RemNormalImpClickEvent =
            EventManager.RegisterRoutedEvent("OtherRemNormalImpClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler RemNormalImpClick
        {
            add { AddHandler(RemNormalImpClickEvent, value); }
            remove { RemoveHandler(RemNormalImpClickEvent, value); }
        }
        void RaiseRemNormalImpClick(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(RemNormalImpClickEvent);
            RaiseEvent(args);
        }

        public static readonly RoutedEvent AddImpVeryImpClickEvent =
            EventManager.RegisterRoutedEvent("OtherAddImpVeryImpClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler AddImpVeryImpClick
        {
            add { AddHandler(AddImpVeryImpClickEvent, value); }
            remove { RemoveHandler(AddImpVeryImpClickEvent, value); }
        }
        void RaiseAddImpVeryImpClick(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(AddImpVeryImpClickEvent);
            RaiseEvent(args);
        }

        public static readonly RoutedEvent RemImpVeryImpClickEvent =
            EventManager.RegisterRoutedEvent("OtherRemImpVeryImpClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FootballPanel));
        public event RoutedEventHandler RemImpVeryImpClick
        {
            add { AddHandler(RemImpVeryImpClickEvent, value); }
            remove { RemoveHandler(RemImpVeryImpClickEvent, value); }
        }
        void RaiseRemImpVeryImpClick(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(RemImpVeryImpClickEvent);
            RaiseEvent(args);
        }
        #endregion
        #endregion
    }
}
