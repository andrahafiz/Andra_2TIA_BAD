using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanWinformHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bKlik_Click(object sender, EventArgs e)
        {
            string nDepan = txtNdepan.Text;
            string nBelakang = txtNbel.Text;
            string alamat = txtAlamat.Text;
            string lokasi = lokasiAlamat.GetItemText(lokasiAlamat.SelectedItem);
            string jk;
            if (rbLelaki.Checked)
            {
                jk = "Laki-laki";
            }
            else
            {
                jk = "Perempuan";
            }

            MessageBox.Show("Hallo!\n" +
                "Perkenalkan, nama saya " + nDepan + " " +
                nBelakang + ".\nAlamat saya di " + alamat + ", " + lokasi + ".\n" +
                "Saya adalah seorang " + jk + ".");

        }
    }
}
