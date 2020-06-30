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

namespace ContexMenu
{
    /// <summary>
    /// Interaction logic for MenuContext.xaml
    /// </summary>
    public partial class MenuContext : Window
    {
        public MenuContext()
        {
            InitializeComponent();
        }
        private void Tombol_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmTombol") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }
    }
}
