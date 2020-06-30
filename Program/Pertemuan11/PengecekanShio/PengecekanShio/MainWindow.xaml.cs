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

namespace PengecekanShio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txttgllahir.Content = tb_tgl.Text+" "+tb_bulan.Text +" "+tb_tahun.Text ;
            cekzodiak(int.Parse(tb_tgl.Text),tb_bulan.Text);
            cekshio(int.Parse(tb_tahun.Text));
        }

        void cekzodiak(int tgl, string bln)
        {
            if ((tgl >= 20 && bln == "Januari") || (tgl <= 18 && bln == "Februari"))
            {
                txtzodiak.Content = "Aquarius";
            }
            else if ((tgl >= 19 && bln == "Februari") || (tgl <= 20 && bln == "Maret"))
            {
                txtzodiak.Content = "Pisces";
            }
            else if ((tgl >= 21 && bln == "Maret") || (tgl <= 19 && bln == "April"))
            {
                txtzodiak.Content = "Aries";
            }
            else if ((tgl >= 20 && bln == "April") || (tgl <= 20 && bln == "Mei"))
            {
                txtzodiak.Content = "Taurus";
            }
            else if ((tgl >= 21 && bln == "Mei") || (tgl <= 22 && bln == "Juni"))
            {
                txtzodiak.Content = "Gemini";
            }
            else if ((tgl >= 23 && bln == "Juni") || (tgl <= 22 && bln == "Juli"))
            {
                txtzodiak.Content = "Cancer";
            }
            else if ((tgl >= 23 && bln == "Juli") || (tgl <= 22 & bln == "Agustus"))
            {
                txtzodiak.Content = "Leo";
            }
            else if ((tgl >= 23 && bln == "Agustus") || (tgl <= 22 && bln == "September"))
            {
                txtzodiak.Content = "Virgo";
            }
            else if ((tgl >= 23 && bln == "September") || (tgl <= 22 && bln == "Oktober"))
            {
                txtzodiak.Content = "Libra";
            }
            else if ((tgl >= 23 && bln == "Oktober") || (tgl <= 21 && bln == "November"))
            {
                txtzodiak.Content = "Scorpio";
            }
            else if ((tgl >= 22 && bln == "November") || (tgl <= 21 & bln == "Desember"))
            {
                txtzodiak.Content = "Sagitarius";
            }
            else if ((tgl >= 22 && bln == "Desember") || (tgl <= 19 && bln == "Januari"))
            {
                txtzodiak.Content = "Capricon";
            }
            else
            {
                txtzodiak.Content = "Error";
            }
        }

        void cekshio(int thn)
        {
            int tahun = thn % 12;
            
            switch (tahun)
            {
                case 0:
                    txtshio.Content= "Monyet";
                    break;
                case 1:
                    txtshio.Content= "Ayam";
                    break;
                case 2:
                    txtshio.Content= "Anjing";
                    break;
                case 3:
                    txtshio.Content= "Babi";
                    break;
                case 4:
                    txtshio.Content= "Tikus";
                    break;
                case 5:
                    txtshio.Content= "Kerbau";
                    break;
                case 6:
                    txtshio.Content= "Macan";
                    break;
                case 7:
                    txtshio.Content= "Kelinci";
                    break;
                case 8:
                    txtshio.Content= "Naga";
                    break;
                case 9:
                    txtshio.Content= "Ular";
                    break;
                case 10:
                    txtshio.Content= "Kuda";
                    break;
                case 11:
                    txtshio.Content= "Kambing";
                    break;
                default:
                    txtshio.Content= "Error";
                    break;
            }
        }
    }

}
