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

namespace Blutalkohol
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ende_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        CLSBlutalkohol ba= new CLSBlutalkohol();
        private void btnBerechnen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double result = 0.0;
                ba.Masse = double.Parse(txtGewicht.Text.Replace(".",","));
                ba.Volumen = double.Parse(txtMenge.Text.Replace(".", ","));
                ba.Prozent = double.Parse(txtProzent.Text.Replace(".", ","));
                if (rbMann.IsChecked == true) ba.Geschlecht = "m";
                else if (rbFrau.IsChecked == true) ba.Geschlecht = "f";
                else ba.Geschlecht = "k";
                result = Math.Round(ba.Berechnen(),2); 
                txtBlutwert.Text= result.ToString();
            }
            catch
            {
                txtBlutwert.Text = "---Error---";
                MessageBox.Show("Die Eingabeparrameter überprüfen!!!!!!!","Eingabefehler",
                    MessageBoxButton.OK,MessageBoxImage.Error);
             


            }
            
               

            
            
        }
    }
}
