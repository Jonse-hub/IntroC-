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

namespace EX25WPFSmallGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private byte currentGameStep = 0;
        private bool isStarted = false;
        public MainWindow()
        {

            InitializeComponent();

            

        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            if (isStarted == false)
            {
                tblMessage.Text = "Flyt mused over på den grønne kasse";
                isStarted = true;
                currentGameStep++;
                btnStartGame.Content = "Stop spillet!";
            }
            else if (isStarted == true)
            {
                MessageBoxResult result = MessageBox.Show("Ønsker du at stoppe spillet?", "Hov..", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    isStarted = false;
                    tblMessage.Text = "Her vil spillets instruktioner stå! Tryk Start Spillet for at begynde";
                    currentGameStep = 0;
                    btnStartGame.Content = "Start spillet!";
                }
            }

        }

        private void tblGreenBg_MouseEnter(object sender, MouseEventArgs e)
        {
            if (currentGameStep == 1)
            {
                tblMessage.Text = "Flot! Tryk nu på den højeste kasse";
                currentGameStep++;
            }
        }

        private void tblYellowBg_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentGameStep == 3)
            {
                tblMessage.Text = "Den forstod du godt! Fjern nu musen fra den lille kasse.";
                currentGameStep++;
            }
        }

        private void tblSmallText_MouseEnter(object sender, MouseEventArgs e)
        {
            if (currentGameStep == 5)
            {
                tblMessage.Text = "Sådan! Sidste step – før musen over den brede 2 gange";
                currentGameStep++;
            }
        }

        private void tblWide_MouseEnter(object sender, MouseEventArgs e)
        {
            if (currentGameStep==6)
            {
                currentGameStep++;
            }
            else if(currentGameStep == 7)
            {
                tblMessage.Text = "Tillykke du vandt!! Tryk på start for at prøve igen.";
                currentGameStep = 0;
                btnStartGame.Content = "Start spillet!";
                isStarted = false;
            }

        }

        private void tblMessage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentGameStep == 2)
            {
                tblMessage.Text = "Godt trykket! Højreklik nu på GRØN.";
                currentGameStep++;
            }
        }

        private void tblBigSize_MouseLeave(object sender, MouseEventArgs e)
        {
            if (currentGameStep == 4)
            {
                tblMessage.Text = "Godt gjort! Rør nu ved noget småt.";
                currentGameStep++;
            }
        }
    }
}
