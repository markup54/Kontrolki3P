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

namespace Kontrolki3P
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

        private void bok_TextChanged(object sender, TextChangedEventArgs e)
        {
            double boczek;
            if(double.TryParse(bok.Text,out boczek) && boczek>0)
            {
                obwod.Text = (boczek * 4).ToString();
                pole.Text = Math.Pow(boczek, 2).ToString();
                komunikat.Content = String.Empty;

            }
            else
            {
                komunikat.Content = "Podaj wartość dodatnią";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bok.Text = String.Empty;
            pole.Text = String.Empty;
            obwod.Text = String.Empty;
            komunikat.Content = "Wpisz wymiar boku";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double boczek;
            if (double.TryParse(bok.Text, out boczek))
            {
                kwadrat.Width = boczek;
                kwadrat.Height = boczek;
                SolidColorBrush kolorek 
                    = (SolidColorBrush)new BrushConverter()
                    .ConvertFromString(kolorCb.Text);
                kwadrat.Fill = kolorek;
                kwadrat.Stroke = kolorek;
                kwadrat.Opacity = (przezChk.IsChecked.Value) ? 0.5 : 1;

            }
        }
    }
}
