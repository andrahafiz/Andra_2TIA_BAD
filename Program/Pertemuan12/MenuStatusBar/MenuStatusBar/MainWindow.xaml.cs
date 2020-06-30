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

namespace MenuStatusBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>s
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtOutput_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int baris = txtOutput.GetLineIndexFromCharacterIndex(txtOutput.CaretIndex);
            int kolom = txtOutput.CaretIndex - txtOutput.GetCharacterIndexFromLineIndex(baris);
            lblPosisiCursor.Text = "Line" + (baris + 1) + ", Char " + (kolom + 1);
        }
    }
}
