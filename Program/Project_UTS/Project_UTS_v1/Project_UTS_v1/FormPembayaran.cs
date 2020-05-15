using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UTS_v1
{
    public partial class FormPembayaran : Form
    {
        Form_Film frmfilm = new Form_Film();
        public FormPembayaran(string nama, int jumlahbangku)
        {
            
            InitializeComponent();
            labelnama.Text = nama;
            labelpengunjung.Text = jumlahbangku + " Bangku";
            labelharga.Text = "" + (jumlahbangku * 35000);


        }

        private void BackgroundForm_Load(object sender, EventArgs e)
        {

        }

        private void btnminimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int uang = 0;
            if (textBox1.Text == "")
            {
                uang = 0;
            }
            else
            {
                uang = Int32.Parse(textBox1.Text);
            }
            
            int total = int.Parse(labelharga.Text);

            if (e.KeyCode == Keys.Enter)
            {
                if (uang < total)
                {
                    MessageBox.Show("Uang anda kurang", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if (uang == total)
                {
                    labelkembalian.Text = "Rp. 0";
                    MessageBox.Show("Pembayaran Sukses", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Timer mytimer = new Timer();
                    mytimer.Tick += mytimer_Tick;
                    mytimer.Interval = 1000;
                    mytimer.Start();
                }
                else
                {
                    labelkembalian.Text = "Rp. " + (uang - total);
                    MessageBox.Show("Pembayaran Sukses", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Timer mytimer = new Timer();
                    mytimer.Tick += mytimer_Tick;
                    mytimer.Interval = 1000;
                    mytimer.Start();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;

        }

        void mytimer_Tick(object sender, EventArgs e)
        {
            if (frmSrl == 1)
            {
                frmSrl++;
                this.Dispose();
                
            }
        }
        int frmSrl = 1;

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
