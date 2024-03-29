﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using KIDDYKIDS.GamesForKids;

namespace KIDDYKIDS
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void BtnGamesForKids_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("GamesForKids/PageGamesForKids.xaml", UriKind.Relative));
        }

        private void BtnEducationalGames_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("EducationalGames/PageEducationalGames.xaml", UriKind.Relative));
        }

        private void BtnGamesForAttention_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("GamesAttentionMemory/PageGamesAttentionMemory.xaml", UriKind.Relative));
        }

        private void BtnLogicAndThinkingGames_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LogicThinkingGames/PageLogicThinkingGames.xaml", UriKind.Relative));
        }

        private void BtnColoringPages_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPuzzles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRiddles_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
