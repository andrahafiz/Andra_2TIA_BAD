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
using System.Text.RegularExpressions;
namespace Pertemuan10_Latihan
{
    /// <summary>
    /// Interaction logic for Latihan5.xaml
    /// </summary>
    public partial class Latihan5 : Window
    {
        public Latihan5()
        {
            InitializeComponent();
        }
        public void Show(object sender, RoutedEventArgs e)
        {
            string vemail = email.Text;
            if (EmailIsValid(vemail))
            {
                MessageBox.Show("Nama : " + nama.Text + "\nEmail : " + email.Text + "\nKomentar : " + comment.Text);
            }
            else
            {
                MessageBox.Show("EMAIL TIDAK SESUAI FORMAT");
            }

        }

        public static bool EmailIsValid(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
