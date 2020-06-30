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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        IDictionary<string, int> dict = new Dictionary<string, int>()
                                            {
                                                {"firstnumber",0},{"secondnumber",0}
                                            };
        Boolean operator_status = false;
        string piloperator = "";
        int hasil;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        //fungsi tombol sama dengan
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (piloperator.Contains("+"))
            {
                hasil = dict["firstnumber"] + dict["secondnumber"];
            }else if (piloperator.Contains("-"))
            {
                hasil = dict["firstnumber"]- dict["secondnumber"];
            }
            else if (piloperator.Contains("*"))
            {
                hasil = dict["firstnumber"] * dict["secondnumber"];
            }
            else if (piloperator.Contains("/"))
            {
                hasil = dict["firstnumber"] / dict["secondnumber"];
            }
            display.Text = hasil.ToString();
        }

        //fungsi method ini adalah ketika button nomor di tekan
        public void inputnum(object sender, RoutedEventArgs e)
        {
            Button angka = (Button)sender;
            string a = ""+angka;
            string c = a.Substring(a.Length-2,2);
            string b = c.Trim();
            display.Text += b;

            if (operator_status == true)
            {
                dict["secondnumber"] = int.Parse(display.Text);
            }
            else
            {
                dict["firstnumber"] = int.Parse(display.Text);
            }
            
        }

        //fungsi ketika button sama dengan  di tekan
        private void actionoperator(object sender, RoutedEventArgs e)
        {
            operator_status = true;
            display.Text = "";
            Button operan = (Button)sender;
            string a = "" + operan;
            string c = a.Substring(a.Length - 2, 2);
             piloperator = c.Trim();
        }


        //fungsi tombol CE ketika di tekan
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            operator_status = false;
            piloperator = "";
            display.Text = "";
            dict["firstnumber"] = 0;
            dict["secondnumber"] = 0;
        }
    }
}
