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
    public partial class RightPanel : UserControl
    {
        public RightPanel()
        {
            InitializeComponent();
        }
        #region Wlasnosci
        public static readonly DependencyProperty CheckClickProperty = DependencyProperty.Register(
            "CheckCl", typeof(ICommand), typeof(RightPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty LoadClickProperty = DependencyProperty.Register(
            "LoadCl", typeof(ICommand), typeof(RightPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty CalcPlayersProperty = DependencyProperty.Register(
            "CalcPlayers", typeof(ObservableCollection<string>), typeof(RightPanel), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty CalcPlayerSelectedProperty = DependencyProperty.Register(
            "CalcPlayerSelected", typeof(string), typeof(RightPanel), new FrameworkPropertyMetadata(null)
            );
        #endregion
        #region Gettery i Settery
        public ICommand CheckCl
        {          
            get { return (ICommand)GetValue(CheckClickProperty); }
            set { SetValue(CheckClickProperty, value); }
        }
        public ICommand LoadCl
        {
            get { return (ICommand)GetValue(LoadClickProperty); }
            set { SetValue(LoadClickProperty, value); }
        }
        public ObservableCollection<string> CalcPlayers
        {
            get { return (ObservableCollection<string>)GetValue(CalcPlayersProperty); }
            set { SetValue(CalcPlayersProperty, value); }
        }
        public string CalcPlayerSelected
        {
            get { return (string)GetValue(CalcPlayerSelectedProperty); }
            set { SetValue(CalcPlayerSelectedProperty, value); }
        }
        #endregion
        #region Eventy
        public static readonly RoutedEvent CheckClickEvent =
            EventManager.RegisterRoutedEvent("OtherCheckClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(RightPanel));
        public event RoutedEventHandler CheckClick
        {
            add { AddHandler(CheckClickEvent, value); }
            remove { RemoveHandler(CheckClickEvent, value); }
        }
        void RaiseCheckClick(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(CheckClickEvent);
            RaiseEvent(args);
        }
        public static readonly RoutedEvent LoadClickEvent =
            EventManager.RegisterRoutedEvent("OtherLoadClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(RightPanel));
        public event RoutedEventHandler LoadClick
        {
            add { AddHandler(LoadClickEvent, value); }
            remove { RemoveHandler(LoadClickEvent, value); }
        }
        void RaiseLoadClick(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(LoadClickEvent);
            RaiseEvent(args);
        }
        public static readonly RoutedEvent CalcPlayersChangedEvent =
            EventManager.RegisterRoutedEvent("OtherCalcPlayerSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(RightPanel));
        public event RoutedEventHandler CalcPlayerChanged
        {
            add { AddHandler(CalcPlayersChangedEvent, value); }
            remove { RemoveHandler(CalcPlayersChangedEvent, value); }
        }
        void RaiseCalcPlayerChanged(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(CalcPlayersChangedEvent);
            RaiseEvent(args);
        }
        #endregion

    }
}
