using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andra_2TIA_Latihan1_Pertemuan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            string angkatan = cbAngkatan.Text;
            string prodi = tbProdi.Text;
            int nilaialpro = int.Parse(tbNilaiAlpro.Text);
            string Huruf;
            string MatkulLain;
            if (checkMatkulLain.Checked)
            {
                MatkulLain = "Basis Data Dasar";
            }
            else
            {
                MatkulLain = "-";
            }

            if (nilaialpro > 80)
            {
                Huruf = "A";
            }
            else if (nilaialpro > 75)
            {
                Huruf = "AB";
            }
            else if (nilaialpro > 65)
            {
                Huruf = "B";
            }
            else if (nilaialpro > 60)
            {
                Huruf = "BC";
            }
            else if (nilaialpro > 50)
            {
                Huruf = "C";
            }
            else if (nilaialpro < 51)
            {
                Huruf = "F";
            }
            else
            {
                Huruf = "-";
            }


            MessageBox.Show("Hallo!! \n Namaku " + nama + "\nAku anak prodi " + prodi
                + "angkatan " + angkatan + "\nNilai Alpro ku " + Huruf +
                "\nMatakuliah lainnya :" + MatkulLain);
        }

        private void tbNilaiAlpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
