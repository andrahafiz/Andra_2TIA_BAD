using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelajarTimer
{
    public partial class Form1 : Form
    {
        frm1 frm1 = new frm1();
        frm2 frm2 = new frm2();
        frm3 frm3 = new frm3();
        frm4 frm4 = new frm4();
        frm5 frm5 = new frm5();
        public Form1()
        {
            InitializeComponent();
        }

        private void HideAllForms()
        {
            frm1.Hide();
            frm2.Hide();
            frm3.Hide();
            frm4.Hide();
        }
        void mytimer_Tick(object sender, EventArgs e)
        {
            if (frmSrl == 1)
            {
                frmSrl++;
                HideAllForms();
                frm1.Show();
            }
            else if (frmSrl == 2)
            {
                frmSrl++;
                HideAllForms();
                frm2.Show();
            }
            else if (frmSrl == 3)
            {
                frmSrl++;
                HideAllForms();
                frm3.Show();
            }
            else if (frmSrl == 4)
            {
                frmSrl = 1;
                HideAllForms();
                frm4.Show();
            }
            else
                frmSrl = 1;
        }
        int frmSrl = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer mytimer = new Timer();
            mytimer.Tick += mytimer_Tick;
            mytimer.Interval = 100;
            mytimer.Start();
        }
    }
}
