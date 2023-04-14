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
using System.Windows.Threading;

namespace KIDDYKIDS.GamesForKids
{
    /// <summary>
    /// Логика взаимодействия для WindowGameWiderNarrower.xaml
    /// </summary>
    public partial class WindowGameWiderNarrower : Window
    {
        public int Otvet = 0;
        MediaPlayer player = new MediaPlayer();

        public WindowGameWiderNarrower()
        {
            InitializeComponent();
        }

        public void CountOtvet()
        {
            if (Otvet == 0)
            {
                player.Open(new Uri("../../GamesForKids/GamesForKidsSound/WhatWider.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
                TxtOtvet.Text = "Что Шире?";
                TxtOtvet.Visibility = Visibility.Visible;
                ImageOtvet1.Visibility = Visibility.Visible;
                ImageOtvet2.Visibility = Visibility.Visible;
                TxtItoge.Visibility = Visibility.Hidden;
                BtnCloseGame.Visibility = Visibility.Hidden;
                BtnRestartGame.Visibility = Visibility.Hidden;
                ImageStar1.Visibility = Visibility.Hidden;
                ImageStar2.Visibility = Visibility.Hidden;
                ImageStar3.Visibility = Visibility.Hidden;
                ImageStar4.Visibility = Visibility.Hidden;
                ImageStar5.Visibility = Visibility.Hidden;
                ImageStar6.Visibility = Visibility.Hidden;
            }
            else if(Otvet == 1)
            {
                player.Open(new Uri("../../GamesForKids/GamesForKidsSound/WhatAlready.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
                TxtOtvet.Text = "Что Уже?";
                ImageOtvet1.Visibility = Visibility.Hidden;
                ImageOtvet2.Visibility = Visibility.Hidden;
                ImageOtvet3.Visibility = Visibility.Visible;
                ImageOtvet4.Visibility = Visibility.Visible;
                ImageStar1.Visibility = Visibility.Visible;
            }
            else if (Otvet == 2)
            {
                player.Open(new Uri("../../GamesForKids/GamesForKidsSound/WhatAlready.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
                TxtOtvet.Text = "Что Уже?";
                ImageOtvet3.Visibility = Visibility.Hidden;
                ImageOtvet4.Visibility = Visibility.Hidden;
                ImageOtvet5.Visibility = Visibility.Visible;
                ImageOtvet6.Visibility = Visibility.Visible;
                ImageStar2.Visibility = Visibility.Visible;
            }
            else if (Otvet == 3)
            {
                player.Open(new Uri("../../GamesForKids/GamesForKidsSound/WhatWider.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
                TxtOtvet.Text = "Что Шире?";
                ImageOtvet5.Visibility = Visibility.Hidden;
                ImageOtvet6.Visibility = Visibility.Hidden;
                ImageOtvet7.Visibility = Visibility.Visible;
                ImageOtvet8.Visibility = Visibility.Visible;
                ImageStar3.Visibility = Visibility.Visible;
            }
            else if (Otvet == 4)
            {
                player.Open(new Uri("../../GamesForKids/GamesForKidsSound/WhatAlready.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
                TxtOtvet.Text = "Что Уже?";
                ImageOtvet7.Visibility = Visibility.Hidden;
                ImageOtvet8.Visibility = Visibility.Hidden;
                ImageOtvet9.Visibility = Visibility.Visible;
                ImageOtvet10.Visibility = Visibility.Visible;
                ImageStar4.Visibility = Visibility.Visible;
            }
            else if (Otvet == 5)
            {
                player.Open(new Uri("../../GamesForKids/GamesForKidsSound/WhatWider.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
                TxtOtvet.Text = "Что Шире?";
                ImageOtvet9.Visibility = Visibility.Hidden;
                ImageOtvet10.Visibility = Visibility.Hidden;
                ImageOtvet11.Visibility = Visibility.Visible;
                ImageOtvet12.Visibility = Visibility.Visible;
                ImageStar5.Visibility = Visibility.Visible;
            }
            else if (Otvet == 6)
            {
                player.Open(new Uri("../../GamesForKids/GamesForKidsSound/Clever.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
                TxtOtvet.Visibility = Visibility.Hidden;
                ImageOtvet11.Visibility = Visibility.Hidden;
                ImageOtvet12.Visibility = Visibility.Hidden;
                ElpsCenter.Visibility = Visibility.Hidden;
                ImageStar6.Visibility = Visibility.Visible;
                TxtItoge.Visibility = Visibility.Visible;
                BtnCloseGame.Visibility = Visibility.Visible;
                BtnRestartGame.Visibility = Visibility.Visible;
            }
        }

        private void ImageOtvet1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            CountOtvet();
        }

        private void ImageOtvet3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            CountOtvet();
        }

        private void ImageOtvet7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            CountOtvet();
        }

        private void ImageOtvet6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            CountOtvet();
        }

        private void ImageOtvet10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            CountOtvet();
        }

        private void ImageOtvet12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            CountOtvet();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRestartGame_Click(object sender, RoutedEventArgs e)
        {
            Otvet = 0;
            CountOtvet();
        }

        private void BtnCloseGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnGameStart_Click(object sender, RoutedEventArgs e)
        {
            BorderStart.Visibility = Visibility.Hidden;
            player.Open(new Uri("../../GamesForKids/GamesForKidsSound/WhatWider.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }
    }
}
