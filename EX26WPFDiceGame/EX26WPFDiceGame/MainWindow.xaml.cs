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

namespace EX26WPFDiceGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        // int Dice = 0;
        short Score = 0;
        short highScore = 0;
        int newroll = 0;
        int oldroll = 0;

        byte liv = 0;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            oldroll = rnd.Next(1, 7);
            lblDice.Content = oldroll;
            Score = 0;
            lblScore.Content = Score;

            if (dif1liv.IsChecked == true) {
                liv = 1;
            }
            else if (dif3liv.IsChecked == true)
            {
                liv = 3;
            }
            else if (dif5liv.IsChecked == true)
            {
                liv = 5;
            }
            lblLiv.Content = liv;
        }

        private void btnLower_Click(object sender, RoutedEventArgs e)
        {
            newroll = rnd.Next(1, 7);

            if (newroll <= oldroll)
            {
                Score++;
                lblScore.Content = Score;
            }
            else
            {
                end();
            }
            oldroll = newroll;
            lblDice.Content = oldroll;

        }

        private void btnHigher_Click(object sender, RoutedEventArgs e)
        {
            newroll = rnd.Next(1, 7);

            if (newroll >= oldroll)
            {
                Score++;
                lblScore.Content = Score;
            }
            else
            {
                end();
            }
            oldroll = newroll;
            lblDice.Content = oldroll;
        }

        void end()
        {
            liv--;
            lblLiv.Content = liv;
            if(liv == 0)
            {
                MessageBox.Show("Desværre - du tabte. Du endte med en score på " + Score, "Game Over!");

                if (Score > highScore)
                {
                    highScore = Score;
                    lblHighScore.Content = highScore;
                }
            }
            
        }
    }
}
