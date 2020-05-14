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
using System.Windows.Shapes;

namespace Pertemuan8
{
    /// <summary>
    /// Interaction logic for Latihan4_Pertemuan7.xaml
    /// </summary>
    public partial class Latihan4_Pertemuan7 : Window
    {
        public Latihan4_Pertemuan7()
        {
            InitializeComponent();
        }
               
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            A.Background = Brushes.Red;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            A.Background = Brushes.Yellow;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            A.Background = Brushes.DarkBlue;
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            A.Background = Brushes.DarkGray;
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            A.Background = Brushes.LawnGreen;
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            A.Background = Brushes.WhiteSmoke;
        }

        private void BtnMerah_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
