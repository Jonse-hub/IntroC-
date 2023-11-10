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

namespace EX27WPFHeroGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> femaleFirstNames = new List<string> { "Olivia", "Emma", "Ava", "Charlotte", "Sophia", "Amelia", "Isabella", "Mia", "Evelyn", "Harper", "Camila", "Gianna", "Abigail", "Luna", "Ella", "Elizabeth", "Sofia", "Emily", "Avery", "Mila", "Scarlett"};
        List<string> maleFirstNames = new List<string> { "Liam", "Noah", "Oliver", "Elijah", "James", "William", "Benjamin", "Lucas", "Henry", "Theodore", "Jack", "Levi", "Alexander", "Jackson", "Mateo", "Daniel", "Michael", "Mason", "Sebastian", "Ethan", "Logan", "Owen", "Samuel", "Jacob", "Asher"};
        List<string> lastNames = new List<string> { "Elsher", "Solace", "Levine", "Thatcher", "Raven", "Bardot", "St. James", "Hansley", "Cromwell", "Ashley", "Monroe", "West", "Langley", "Daughtler", "Madison", "Marley", "Ellis", "Hope", "Cassidy", "Lopez", "Jenkins", "Poverly", "McKenna", "Gonzales", "Keller" };

        Random rnd = new Random();
        byte numberOfHeroes = 0;

        public MainWindow()
        {
            InitializeComponent();
            // femaleFirstNames.Clear();
            string[] array = new string[] { "", "" };
            array.Contains(""); // check contains på string
        }

        private void btnFemaleHeroes_Click(object sender, RoutedEventArgs e)
        {
            numberOfHeroes = byte.Parse(tbxNumberOfHeroes.Text);

            for (byte i = 0; i < numberOfHeroes; i++)
            {
                string firstName = femaleFirstNames[rnd.Next(0, femaleFirstNames.Count)];
                string laseName = lastNames[rnd.Next(0, lastNames.Count)];

                string newHero = firstName + " " + laseName;
                
                if (lbxHeroNames.Items.Contains(newHero))
                {
                    i--;
                }
                else
                {
                    lbxHeroNames.Items.Add(newHero);
                }


            }

        }

        private void btnMaleHeroes_Click(object sender, RoutedEventArgs e)
        {
            numberOfHeroes = byte.Parse(tbxNumberOfHeroes.Text);

            for (byte i = 0; i < numberOfHeroes; i++)
            {
                string firstName = maleFirstNames[rnd.Next(0, femaleFirstNames.Count)];
                string laseName = lastNames[rnd.Next(0, lastNames.Count)];

                string newHero = firstName + " " + laseName;

                if (lbxHeroNames.Items.Contains(newHero))
                {
                    i--;
                }
                else
                {
                    lbxHeroNames.Items.Add(newHero);
                }


            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lbxHeroNames.Items.Clear();
        }
    }
}
