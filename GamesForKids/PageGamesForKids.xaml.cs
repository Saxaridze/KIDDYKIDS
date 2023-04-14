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
    /// Логика взаимодействия для PageGamesForKids.xaml
    /// </summary>
    public partial class PageGamesForKids : Page
    {
        public PageGamesForKids()
        {
            InitializeComponent();
        }

        private void ImageWiderNarrower_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowGameWiderNarrower taskWindow = new WindowGameWiderNarrower();
            taskWindow.Show();
        }

        private void ImageCloserFurther_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageMessageBox taskWindow = new PageMessageBox();
            taskWindow.Show();
        }

        private void ImageBouquetOfFlowers_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageMessageBox taskWindow = new PageMessageBox();
            taskWindow.Show();
        }

        private void ImageRhomb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageMessageBox taskWindow = new PageMessageBox();
            taskWindow.Show();
        }

        private void ImageOval_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageMessageBox taskWindow = new PageMessageBox();
            taskWindow.Show();
        }

        private void ImageRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageMessageBox taskWindow = new PageMessageBox();
            taskWindow.Show();
        }

        private void ImageTriangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageMessageBox taskWindow = new PageMessageBox();
            taskWindow.Show();
        }

        private void ImageSquare_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageMessageBox taskWindow = new PageMessageBox();
            taskWindow.Show();
        }

    }
}
