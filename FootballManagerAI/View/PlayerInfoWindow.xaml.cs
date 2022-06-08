using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace FootballManagerAI.View
{
    public partial class PlayerInfoWindow : Window
    {
        public PlayerInfoWindow()
        {
            InitializeComponent();
        }


        //public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
        //    "Text", typeof(string), typeof(PlayerInfoWindow), new FrameworkPropertyMetadata(null)
        //    );
        //public string Text
        //{
        //    get { return (string)GetValue(TextProperty); }
        //    set { SetValue(TextProperty, value); }
        //}
        //public static readonly RoutedEvent TextChangedEvent =
        //    EventManager.RegisterRoutedEvent("OtherTextChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(PlayerInfoWindow));
        //public event RoutedEventHandler TextChanged
        //{
        //    add { AddHandler(TextChangedEvent, value); }
        //    remove { RemoveHandler(TextChangedEvent, value); }
        //}
        //void RaiseTextChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    RoutedEventArgs args = new RoutedEventArgs(TextChangedEvent);
        //    RaiseEvent(args);
        //}
    }
}
