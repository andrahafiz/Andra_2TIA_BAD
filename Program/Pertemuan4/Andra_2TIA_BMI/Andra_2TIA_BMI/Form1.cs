using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andra_2TIA_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            double berat = double.Parse(textBox2.Text);
            double tinggi = double.Parse(textBox3.Text) / 100;
            string kategori;

            double rumus = berat / (tinggi * tinggi);

            if (rumus > 40)
            {
                kategori = "Obesity 3";
            }
            else if (rumus > 35)
            {
                kategori = "Obesity 2";
            }
            else if (rumus > 29)
            {
                kategori = "Obesity 1";
            }
            else if (rumus > 25)
            {
                kategori = "Over weight";
            }
            else if (rumus > 18.5)
            {
                kategori = "Normal weight";
            }
            else
            {
                kategori = "Underweight";
            }



                MessageBox.Show("Nama : " + nama + "" +
                     "\nBerat : " + berat + " Kg" +
                     "\nTinggi : " + tinggi + " M" +
                     "\nHasil BMI : " + rumus +
                     "\nKeterangan : " + kategori);
        }
    }
}
