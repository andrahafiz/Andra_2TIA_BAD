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

namespace Pertemuan10_DockPanel
{
    /// <summary>
    /// Interaction logic for DockPanel2.xaml
    /// </summary>
    public partial class DockPanel2 : Window
    {
        public DockPanel2()
        {
            InitializeComponent();
        }

        private void Click_Me(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string str = btn.Content.ToString() + " tombol ditekan";
            MessageBox.Show(str);
        }
    }
}
