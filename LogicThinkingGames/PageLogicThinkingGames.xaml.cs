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

namespace KIDDYKIDS.LogicThinkingGames
{
    /// <summary>
    /// Логика взаимодействия для PageLogicThinkingGames.xaml
    /// </summary>
    public partial class PageLogicThinkingGames : Page
    {
        public PageLogicThinkingGames()
        {
            InitializeComponent();
        }

        private void ImageTheFourthExtra_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ImageColoredShapes_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ImageAssociations_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ImageBalloonPoppings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowsGameBalloonPoppings taskWindow = new WindowsGameBalloonPoppings();
            taskWindow.Show();
        }
    }
}
