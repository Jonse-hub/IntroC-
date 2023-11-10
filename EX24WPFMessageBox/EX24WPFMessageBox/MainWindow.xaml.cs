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

namespace EX24WPFMessageBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("En eller anden tekst", "En titel");

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("en OK knap", "OK", MessageBoxButton.OK);
        }

        private void OkCancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OkCancel", "OkCancel", MessageBoxButton.OKCancel);
        }

        private void YesNoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("YesNo", "YesNo", MessageBoxButton.YesNo);
        }

        private void YesNoCancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("YesNoCancel", "YesNoCancel", MessageBoxButton.YesNoCancel);
        }




        private void Asterisk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("detter er en Asterisk", "Asterisk", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void Error_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Exclamation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Exclamation", "Exclamation", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Hand_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hand", "Hand", MessageBoxButton.OK, MessageBoxImage.Hand);
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Information", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void None_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("None", "None", MessageBoxButton.OK, MessageBoxImage.None);
        }

        private void Question_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Question", "Question", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Stop", "Stop", MessageBoxButton.OK, MessageBoxImage.Stop);
        }

        private void Warning_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Warning", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Noget tekst", "En titel", MessageBoxButton.YesNoCancel);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Du trykkede ja!", "JA!!");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Du trykkede nej!", "NEJ!!");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Du trykkede cancel", "WHAT?");
                    break;
            }
        }
    }
    
}
