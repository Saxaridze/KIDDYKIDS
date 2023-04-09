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

namespace KIDDYKIDS.GamesForKids
{
    /// <summary>
    /// Логика взаимодействия для PageGameWiderNarrower.xaml
    /// </summary>
    public partial class PageGameWiderNarrower : Page
    {
        public int Otvet = 0;

        public PageGameWiderNarrower()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TxtOtvet.Text = "Что Шире?"; 
        }

        private void ImageOtvet1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            TxtOtvet.Text = "Что Уже?";
            ImageOtvet1.Visibility = Visibility.Hidden;
            ImageOtvet2.Visibility = Visibility.Hidden;
            ImageOtvet3.Visibility = Visibility.Visible;
            ImageOtvet4.Visibility = Visibility.Visible;
        }

        private void ImageOtvet2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtOtvet.Text = "Что Уже?";
            ImageOtvet1.Visibility = Visibility.Hidden;
            ImageOtvet2.Visibility = Visibility.Hidden;
            ImageOtvet3.Visibility = Visibility.Visible;
            ImageOtvet4.Visibility = Visibility.Visible;
        }

        private void ImageOtvet3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            TxtOtvet.Text = "Что Уже?";
            ImageOtvet3.Visibility = Visibility.Hidden;
            ImageOtvet4.Visibility = Visibility.Hidden;
            ImageOtvet5.Visibility = Visibility.Visible;
            ImageOtvet6.Visibility = Visibility.Visible;
        }

        private void ImageOtvet4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtOtvet.Text = "Что Уже?";
            ImageOtvet3.Visibility = Visibility.Hidden;
            ImageOtvet4.Visibility = Visibility.Hidden;
            ImageOtvet5.Visibility = Visibility.Visible;
            ImageOtvet6.Visibility = Visibility.Visible;
        }

        private void ImageOtvet5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtOtvet.Text = "Что Шире?";
            ImageOtvet5.Visibility = Visibility.Hidden;
            ImageOtvet6.Visibility = Visibility.Hidden;
            ImageOtvet7.Visibility = Visibility.Visible;
            ImageOtvet8.Visibility = Visibility.Visible;
        }

        private void ImageOtvet6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            TxtOtvet.Text = "Что Шире?";
            ImageOtvet5.Visibility = Visibility.Hidden;
            ImageOtvet6.Visibility = Visibility.Hidden;
            ImageOtvet7.Visibility = Visibility.Visible;
            ImageOtvet8.Visibility = Visibility.Visible;
        }

        public void Itoge()
        {
            if (Otvet == 6)
            {
                TxtItoge.Visibility = Visibility.Visible;
                ImageStar1.Visibility = Visibility.Visible;
                ImageStar2.Visibility = Visibility.Visible;
                ImageStar3.Visibility = Visibility.Visible;
                ImageStar4.Visibility = Visibility.Visible;
                ImageStar5.Visibility = Visibility.Visible;
                ImageStar6.Visibility = Visibility.Visible;
            }
            else if (Otvet == 5)
            {
                TxtItoge.Visibility = Visibility.Visible;
                ImageStar1.Visibility = Visibility.Visible;
                ImageStar2.Visibility = Visibility.Visible;
                ImageStar3.Visibility = Visibility.Visible;
                ImageStar4.Visibility = Visibility.Visible;
                ImageStar5.Visibility = Visibility.Visible;
            }
            else if (Otvet == 4)
            {
                TxtItoge.Text = "МОЛОДЕЦ!";
                TxtItoge.Visibility = Visibility.Visible;
                ImageStar1.Visibility = Visibility.Visible;
                ImageStar2.Visibility = Visibility.Visible;
                ImageStar3.Visibility = Visibility.Visible;
                ImageStar4.Visibility = Visibility.Visible;
            }
            else if (Otvet == 3)
            {
                TxtItoge.Text = "МОЛОДЕЦ!";
                TxtItoge.Visibility = Visibility.Visible;
                ImageStar1.Visibility = Visibility.Visible;
                ImageStar2.Visibility = Visibility.Visible;
                ImageStar3.Visibility = Visibility.Visible;
            }
            else if (Otvet == 2)
            {
                TxtItoge.Text = "ПОЧТИ!";
                TxtItoge.Visibility = Visibility.Visible;
                ImageStar1.Visibility = Visibility.Visible;
                ImageStar2.Visibility = Visibility.Visible;
            }
            else if (Otvet == 1)
            {
                TxtItoge.Text = "ПОЧТИ!";
                TxtItoge.Visibility = Visibility.Visible;
                ImageStar1.Visibility = Visibility.Visible;
            }
            else if (Otvet == 0)
            {
                TxtItoge.Text = "!";
                TxtItoge.Text = Convert.ToString(Otvet);
                TxtItoge.Visibility = Visibility.Visible;
            }
        }

        private void ImageOtvet7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            TxtOtvet.Text = "Что Уже?";
            ImageOtvet7.Visibility = Visibility.Hidden;
            ImageOtvet8.Visibility = Visibility.Hidden;
            ImageOtvet9.Visibility = Visibility.Visible;
            ImageOtvet10.Visibility = Visibility.Visible;
        }

        private void ImageOtvet8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtOtvet.Text = "Что Уже?";
            ImageOtvet7.Visibility = Visibility.Hidden;
            ImageOtvet8.Visibility = Visibility.Hidden;
            ImageOtvet9.Visibility = Visibility.Visible;
            ImageOtvet10.Visibility = Visibility.Visible;
        }

        private void ImageOtvet9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtOtvet.Text = "Что Шире?";
            ImageOtvet9.Visibility = Visibility.Hidden;
            ImageOtvet10.Visibility = Visibility.Hidden;
            ImageOtvet11.Visibility = Visibility.Visible;
            ImageOtvet12.Visibility = Visibility.Visible;
        }

        private void ImageOtvet10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            TxtOtvet.Text = "Что Шире?";
            ImageOtvet9.Visibility = Visibility.Hidden;
            ImageOtvet10.Visibility = Visibility.Hidden;
            ImageOtvet11.Visibility = Visibility.Visible;
            ImageOtvet12.Visibility = Visibility.Visible;
        }

        private void ImageOtvet11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtOtvet.Visibility = Visibility.Hidden;
            ImageOtvet11.Visibility = Visibility.Hidden;
            ImageOtvet12.Visibility = Visibility.Hidden;
            ElpsCenter.Visibility = Visibility.Hidden;
            Itoge();
        }

        private void ImageOtvet12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otvet++;
            TxtOtvet.Visibility = Visibility.Hidden;
            ImageOtvet11.Visibility = Visibility.Hidden;
            ImageOtvet12.Visibility = Visibility.Hidden;
            ElpsCenter.Visibility = Visibility.Hidden;
            Itoge();
        }
    }
}
