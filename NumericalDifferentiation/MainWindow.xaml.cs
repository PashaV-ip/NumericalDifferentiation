using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NumericalDifferentiation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double H;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            H = double.Parse(TextBoxNumber3.Text) - double.Parse(TextBoxNumber1.Text);
            double First1 = Math.Round(Math.Round(1D / (6D * H), 5) * (-11 * double.Parse(TextBoxNumber2.Text) + 18 * double.Parse(TextBoxNumber4.Text) - 9 * double.Parse(TextBoxNumber6.Text) + 2 * double.Parse(TextBoxNumber8.Text)), 5);
            double First2 = Math.Round(Math.Round(1D / (6D * H), 5) * (-2 * double.Parse(TextBoxNumber2.Text) - 3 * double.Parse(TextBoxNumber4.Text) + 6 * double.Parse(TextBoxNumber6.Text) - double.Parse(TextBoxNumber8.Text)), 5);
            double First3 = Math.Round(Math.Round(1D / (6D * H), 5) * (double.Parse(TextBoxNumber2.Text) - 6 * double.Parse(TextBoxNumber4.Text) + 3 * double.Parse(TextBoxNumber6.Text) + 2 * double.Parse(TextBoxNumber8.Text)), 5);
            double First4 = Math.Round(Math.Round(1D / (6D * H), 5) * (-2 * double.Parse(TextBoxNumber2.Text) + 9 * double.Parse(TextBoxNumber4.Text) - 18 * double.Parse(TextBoxNumber6.Text) + 11 * double.Parse(TextBoxNumber8.Text)), 5);


            double Second1 = Math.Round(1 / Math.Pow(H, 2) * (2 * double.Parse(TextBoxNumber2.Text) - 5 * double.Parse(TextBoxNumber4.Text) + 4 * double.Parse(TextBoxNumber6.Text) - double.Parse(TextBoxNumber8.Text)), 5);
            double Second2 = Math.Round(1 / Math.Pow(H, 2) * (double.Parse(TextBoxNumber2.Text) - 2 * double.Parse(TextBoxNumber4.Text) + double.Parse(TextBoxNumber6.Text)), 5);
            double Second3 = Math.Round(1 / Math.Pow(H, 2) * (double.Parse(TextBoxNumber4.Text) - 2 * double.Parse(TextBoxNumber6.Text) + double.Parse(TextBoxNumber8.Text)), 5);
            double Second4 = Math.Round(1 / Math.Pow(H, 2) * (-double.Parse(TextBoxNumber2.Text) + 4 * double.Parse(TextBoxNumber4.Text) - 5 * double.Parse(TextBoxNumber6.Text) + 2 * double.Parse(TextBoxNumber8.Text)), 5);
            
            
            
            MessageBox.Show($"{First1}\n" +
                $"{First2}\n" +
                $"{First3}\n" +
                $"{First4}\n" +
                $"{Second1}\n" +
                $"{Second2}\n" +
                $"{Second3}\n" +
                $"{Second4}", "Ответ");
        }
    }
}
