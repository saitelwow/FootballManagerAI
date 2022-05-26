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
    using Model;
    public partial class PlayerInfoWindow : Window
    {
        private string _playerPosition;
        public string PlayerPosition
        {
            get { return _playerPosition; }
            set { _playerPosition = value; }
        }
        private string[] attributesOfPlayer;
        public string[] AttributesOfPlayer
        {
            get { return attributesOfPlayer; }
            set { attributesOfPlayer = value; }
        }
        public PlayerInfoWindow(Player setPlayer, string position)
        {
            InitializeComponent();
            SetInfo(setPlayer, position);
        }
        public void SetInfo(Player setPlayer, string position)
        {
            AttributesOfPlayer = setPlayer.Attr;
            PlayerPosition = position;
            //playerName.Text = playerAtt[1];
            playerName.Text = setPlayer.Attr[UtilityAI.SearchIndex("Name", UtilityAI.firstLine)];
            Age.Text = setPlayer.Attr[UtilityAI.SearchIndex("Age", UtilityAI.firstLine)];
            Height.Text = setPlayer.Attr[UtilityAI.SearchIndex("Height", UtilityAI.firstLine)];
            if (position == "Goalkeeper")
            {
                foreach (string att in LBAttributes.GkAtt)
                {
                    gktechAtt.Items.Add(att);
                    gktechNbs.Items.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
                }
            }
            else
            {
                foreach (string att in LBAttributes.TechAtt)
                {
                    gktechAtt.Items.Add(att);
                    gktechNbs.Items.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
                }
            }
            foreach (string att in LBAttributes.MentalAtt)
            {
                mentalAtt.Items.Add(att);
                mentalNbs.Items.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
            }
            foreach (string att in LBAttributes.PhysAtt)
            {
                physAtt.Items.Add(att);
                physNbs.Items.Add(setPlayer.Attr[UtilityAI.SearchIndex(att, UtilityAI.firstLine)]);
            }
        }


        //public static readonly DependencyProperty NameOfProperty = DependencyProperty.Register(
        //    "NameOf", typeof(string), typeof(PlayerInfoWindow), new FrameworkPropertyMetadata(null));
        //public static readonly DependencyProperty AgeOfProperty = DependencyProperty.Register(
        //    "AgeOf", typeof(string), typeof(PlayerInfoWindow), new FrameworkPropertyMetadata(null));
        //public static readonly DependencyProperty HeightOfProperty = DependencyProperty.Register(
        //    "HeightOf", typeof(string), typeof(PlayerInfoWindow), new FrameworkPropertyMetadata(null));
        //public string NameOf
        //{
        //    get { return (string)GetValue(NameOfProperty); }
        //    set { SetValue(NameOfProperty, value); }
        //}
        //public string AgeOf
        //{
        //    get { return (string)GetValue(AgeOfProperty); }
        //    set { SetValue(AgeOfProperty, value); }
        //}
        //public string HeightOf
        //{
        //    get { return (string)GetValue(HeightOfProperty); }
        //    set { SetValue(HeightOfProperty, value); }
        //}
    }
}
