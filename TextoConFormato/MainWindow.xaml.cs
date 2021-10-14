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

namespace TextoConFormato
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
       
            FondoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
          
            FondoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
 
                FondoTextBlock.Foreground = Brushes.Blue;    
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FondoTextBlock.Foreground = Brushes.Red;
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FondoTextBlock.Foreground = Brushes.Green;

        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            FondoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            FondoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void EscribirTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FondoTextBlock.Text = EscribirTextBox.Text;
        }
    }
}
