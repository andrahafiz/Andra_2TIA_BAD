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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //BackgroundForm form = new BackgroundForm();
            //form.Show();
        }



        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label_Jam.Text = DateTime.Now.ToString("hh:mm");
            Label_Second.Text = DateTime.Now.ToString("ss");
            Label_Tanggal.Text = DateTime.Now.ToString("dddd, d MMM yyyy");

            //posis
            Label_Second.Location = new Point(Label_Jam.Location.X + Label_Jam.Width - 5, Label_Second.Location.Y);
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            tbusername.Clear();
        }

        private void tbpass_Click(object sender, EventArgs e)
        {
            tbpass.Clear();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(tbusername.Text=="Username" || tbpass.Text== "Password" || tbpass.Text == "" || tbusername.Text=="")
            {
                MessageBox.Show("Silahkan penuhi data anda");
            }else if(tbusername.Text=="Admin" && tbpass.Text=="Admin") { 
                Form_Film formfilm = new Form_Film();
                formfilm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password anda salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

  
    }
}
