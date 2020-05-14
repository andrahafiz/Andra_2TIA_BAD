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
    /// Interaction logic for latihan4.xaml
    /// </summary>
    public partial class latihan4 : Window
    {
        public latihan4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (btnHalo.IsChecked == true)
            {
                MessageBox.Show("Halo yang kamu klik.");

            }
            else if (btnWelcome.IsChecked == true)
            {
                MessageBox.Show("Welcome yang kamu klik.");

            }
        }

    }
}
