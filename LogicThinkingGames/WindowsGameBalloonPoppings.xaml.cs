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


namespace KIDDYKIDS.LogicThinkingGames
{
    /// <summary>
    /// Логика взаимодействия для WindowsGameBalloonPoppings.xaml
    /// </summary>
    public partial class WindowsGameBalloonPoppings : Window
    {
        DispatcherTimer gameTimer = new DispatcherTimer();

        int speed = 3;
        int intervals = 90;
        Random rand = new Random();

        List<Rectangle> itemRemover = new List<Rectangle>();

        ImageBrush backgroundImage = new ImageBrush();

        int balloonSkins;
        int i;

        int missedBalloons;
        bool gameIsActive;
        int score;

        MediaPlayer player = new MediaPlayer();

        public WindowsGameBalloonPoppings()
        {
            InitializeComponent();
            gameTimer.Tick += GameEngine;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/LogicThinkingGames/LogicThinkingGamesImage/background-Image.jpg"));
            MyCanvas.Background = backgroundImage;

            RestartGame();
        }

        private void GameEngine(object sender, EventArgs e)
        {
            scoreLabel.Content = "Поймано: " + score;

            intervals -= 10;

            if (intervals < 1)
            {
                ImageBrush balloonImage = new ImageBrush();

                balloonSkins += 1;

                if (balloonSkins > 5)
                {
                    balloonSkins = 1;
                }
                switch (balloonSkins)
                {
                    case 1:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/LogicThinkingGames/LogicThinkingGamesImage/balloon1.png"));
                        break;
                    case 2:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/LogicThinkingGames/LogicThinkingGamesImage/balloon2.png"));
                        break;
                    case 3:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/LogicThinkingGames/LogicThinkingGamesImage/balloon3.png"));
                        break;
                    case 4:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/LogicThinkingGames/LogicThinkingGamesImage/balloon4.png"));
                        break;
                    case 5:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/LogicThinkingGames/LogicThinkingGamesImage/balloon5.png"));
                        break;
                }
                Rectangle newBalloon = new Rectangle
                {
                    Tag = "balloon",
                    Height = 120,
                    Width = 100,
                    Fill = balloonImage
                };

                Canvas.SetLeft(newBalloon, rand.Next(100, 1550));
                Canvas.SetTop(newBalloon, 800);

                MyCanvas.Children.Add(newBalloon);

                intervals = rand.Next(90, 150);
            }

            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                if ((string)x.Tag == "balloon")
                {
                    i = rand.Next(-5, 5);

                    Canvas.SetTop(x, Canvas.GetTop(x) - speed);
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - (i * -1));
                }

                if (Canvas.GetTop(x) < 20)
                {
                    itemRemover.Add(x);
                    missedBalloons += 1;
                }
            }

            foreach (Rectangle y in itemRemover)
            {
                MyCanvas.Children.Remove(y);
            }

            if (missedBalloons > 3)
            {
                gameIsActive = false;
                gameTimer.Stop();
                MessageBoxResult result = MessageBox.Show("Конец игры вы пропустили 3 шара" +
                    Environment.NewLine + "Нажмите кнопку ДА чтобы начать заново", "!!!", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        RestartGame();
                        break;
                    case MessageBoxResult.No:
                        gameTimer.Stop();
                        this.Close();
                        break;
                }
            }
            if (score > 10)
            {
                speed = 8;
            }
            else if (score > 20)
            {
                speed = 10;
            }
            else if (score > 30)
            {
                speed = 12;
            }
            else if (score > 40)
            {
                speed = 14;
            }
            else if (score > 50)
            {
                speed = 16;
            }
        }

        private void popBalloons(object sender, MouseButtonEventArgs e)
        {
            if (gameIsActive)
            {
                if (e.OriginalSource is Rectangle)
                {
                    Rectangle activeRec = (Rectangle)e.OriginalSource;
                    player.Open(new Uri("../../LogicThinkingGames/LogicThinkingGamesImage/pop_sound.mp3", UriKind.RelativeOrAbsolute));
                    player.Play();
                    MyCanvas.Children.Remove(activeRec);

                    score += 1;
                }
            }
        }

        private void StartGame()
        {
            gameTimer.Start();

            missedBalloons = 0;
            score = 0;
            intervals = 90;
            gameIsActive = true;
            speed = 6;
        }

        private void RestartGame()
        {
            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                itemRemover.Add(x);
            }

            foreach (Rectangle y in itemRemover)
            {
                MyCanvas.Children.Remove(y);
            }

            itemRemover.Clear();

            StartGame();
        }

        private void canvasKeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gameTimer.Stop();
        }
    }
}
