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

namespace ITVitaeOefening
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

        private void Berekenen(object sender, RoutedEventArgs e)
        {   int x;
            if (int.TryParse(Getal1.Text, out x))
                return;
            int getal1 = int.Parse(Getal1.Text);
            if (int.TryParse(Getal1.Text, out x))
                return;
            int getal2 = int.Parse(Getal2.Text);

            int antwoord = 0;
            
            if((bool)Optellen.IsChecked)
            {
                antwoord = Int32.Parse(Getal1.Text) + Int32.Parse(Getal2.Text);
                Veld.Content = $"{getal1} + {getal2} = {antwoord}";
                History.Items.Add($"{getal1} + {getal2} = {antwoord}");
            }
            else if((bool)Aftrekken.IsChecked)
            {
                antwoord = Int32.Parse(Getal1.Text) - Int32.Parse(Getal2.Text);
                Veld.Content = $"{getal1} - {getal2} = {antwoord}";
                History.Items.Add($"{getal1} - {getal2} = {antwoord}");
            }
            else if((bool)Vermenigvuldigen.IsChecked)
            {
                antwoord = Int32.Parse(Getal1.Text) * Int32.Parse(Getal2.Text);
                Veld.Content = $"{getal1} * {getal2} = {antwoord}";
                History.Items.Add($"{getal1} * {getal2} = {antwoord}");
            }
            else if((bool)Delen.IsChecked)
            {
                antwoord = Int32.Parse(Getal1.Text) / Int32.Parse(Getal2.Text);
                Veld.Content = $"{getal1} / {getal2} = {antwoord}";
                History.Items.Add($"{getal1} / {getal2} = {antwoord}");
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            History.Items.Clear();
        }
    }
}
