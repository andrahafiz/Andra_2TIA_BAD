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


namespace Pertemuan10_Latihan
{
    /// <summary>
    /// Interaction logic for Latihan4.xaml
    /// </summary>
    /// 

    public partial class Latihan4 : Window
    {
        public Latihan4()
        {
            InitializeComponent();
        }

        public void Show(object sender,RoutedEventArgs e)
        {
           
                MessageBox.Show("Nama : " + nama.Text + "\nEmail : " + email.Text + "\nKomentar : " + comment.Text);
            
            
        }

     

    }
}
