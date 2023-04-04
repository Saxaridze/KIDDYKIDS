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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;
using System.IO;
using System.ComponentModel;
using System.Windows.Markup;
using System.Globalization;

namespace KIDDYKIDS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SoundPlayer Player = new SoundPlayer();

        public MainWindow()
        {
            InitializeComponent();

            Manager.MainFrame = MainFrame;
            MainFrame.Navigate(new PageMain());
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (!MainFrame.CanGoBack)
                BtnBack.Visibility = Visibility.Collapsed;
            else
                BtnBack.Visibility = Visibility.Visible;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
                MainFrame.GoBack();
        }

        private void BtnTurnONMusic_Click(object sender, RoutedEventArgs e)
        {
            this.Player.SoundLocation = "TwirlyTops.wav";
            this.Player.Load();
            this.Player.PlayLooping();
            BtnTurnONMusic.Visibility = Visibility.Hidden;
            BtnTurnOFFMusic.Visibility = Visibility.Visible;
        }

        private void BtnTurnOFFMusic_Click(object sender, RoutedEventArgs e)
        {
            this.Player.Stop();
            BtnTurnOFFMusic.Visibility = Visibility.Hidden;
            BtnTurnONMusic.Visibility = Visibility.Visible;
        }
    }
}
