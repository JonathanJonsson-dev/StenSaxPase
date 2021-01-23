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

namespace StenSaxPåse
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

        GameEngine gameEngine = new GameEngine();
        int computerScore = 0;
        int playerScore = 0;

        private void btnSpela_Click(object sender, RoutedEventArgs e)
        {
            Computer computer = new Computer();
            Player player = new Player();
            
            if (radioBtnPase.IsChecked == true)
            {
                player.Choice = "Påse";
            }
            if (radioBtnSax.IsChecked == true)
            {
                player.Choice = "Sax";
            }
            if (radioBtnSten.IsChecked == true)
            {
                player.Choice = "Sten";
            }

            if (gameEngine.SelectWinner(player, computer) == "Dator")
            {
                computerScore += 1;
            }
            else if (gameEngine.SelectWinner(player, computer) == "Spelare")
            {
                playerScore += 1;
            }
            
            lblValDator.Content = $"Datorn valde {computer.Choice}";
            lblResultat.Content = $"Datorn har {computerScore} poäng och du har {playerScore} poäng";
        }
    }
}
