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
using Microsoft.VisualBasic;

namespace Pertemuan_6
{
       public partial class Latihan_Pertemuan6 : Window
    {
        public Latihan_Pertemuan6()
        {
            InitializeComponent();
        }        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string hobi = "";                      
            if (cbBerenang.IsChecked == true)
            {
                hobi += " Badminton,";
            }
            if (cbFutsal.IsChecked == true)
            {
                hobi += " Sepak Bola,";
            }
            if (cbBacaNovel.IsChecked == true)
            {
                hobi += " Baca Buku,";
            }
            if (cbAgama.IsChecked == true)
            {
                hobi += " Masak,";
            }
            string minuman = "";
            //Minuman
            if (cbPokat.IsChecked == true)
            {
                minuman += " Jus Jeruk,";
            }
            if (cbMangga.IsChecked == true)
            {
                minuman += " Jus Pokat,";
            }
            if (cbSusu.IsChecked == true)
            {
                minuman += " Susu,";
            }
            if (cbSkoteng.IsChecked == true)
            {
                minuman += " Bandrek,";
            }
            string makanan = "";
            //MAKANAN
            if (cbSoto.IsChecked == true)
            {
                makanan += " Mie Nasi Goreng,";
            }
            if (cbayam.IsChecked == true)
            {
                makanan += " Indomie,";
            }
            if (cbBurger.IsChecked == true)
            {
                makanan += " Bakso,";
            }
            if (cbGorengan.IsChecked == true)
            {
                makanan += " Sate,";
            }
            MessageBox.Show("Hobi anda : " + hobi.Substring(1,hobi.Length-2) 
                             + "\nMinuman kesukaan anda : " + minuman.Substring(1, minuman.Length - 2)
                             + "\nMakanan kesukaan anda : " + makanan.Substring(1, makanan.Length - 2));
        }}}
