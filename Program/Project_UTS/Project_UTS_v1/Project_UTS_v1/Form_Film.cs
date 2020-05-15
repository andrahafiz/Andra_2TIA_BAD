using Project_UTS_v1.Properties;
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
    public partial class Form_Film : Form
    {
        Dictionary<string, Bangku> Film_EndGame = new Dictionary<string, Bangku>();
        Dictionary<string, Bangku> Film_BP = new Dictionary<string, Bangku>();
        Dictionary<string, Bangku> Film_FF = new Dictionary<string, Bangku>();
        Bangku a;
        string judulfilm = null;
        int i = 0;

        public Form_Film()
        {
            InitializeComponent();
            cb_jmlorang.Text = "1";
           
            kontentfilm.Show();   
        }


        //Untuk minimize       
        private void btnminimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Untuk close program 
        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah anda ingin keluar?", "Keluar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            //if(MessageBox.Show("Apakah anda ingin keluar?","Keluar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
        }
        
        //untuk menghidupkan kotak coklat kiri pada bagian menu
        void navigasi(Boolean tabfilm, Boolean tabbangku)
        {
            panel1.Visible = tabfilm;
            panel4.Visible = tabbangku;
        }

        //untuk kembali ke kontent film 
        private void btnfilm_Click(object sender, EventArgs e)
        {
            backtofilm();
        }

        //untuk menu bangku
        private void btnbangku_Click(object sender, EventArgs e)
        {
            navigasi(false, true);
            kontentbangku_eg.Show();
            kontentfilm.Hide();
        }



        private void btnA1_Click(object sender, EventArgs e)
        {}

        //untuk melihat data yang menempati bangku
        private string cekdetail(string nobangku, string judul)
        {
            string str = judul;
            switch (str)
            {

                case "Avengers - End Game":
                    foreach (KeyValuePair<string, Bangku> user in Film_EndGame)
                    {
                        if (user.Key.Equals(nobangku))
                        {
                            MessageBox.Show(user.Value.pesan());
                            return "true";
                        }
                    }
                    break;

                case "Black Pather":
                    foreach (KeyValuePair<string, Bangku> user in Film_BP)
                    {
                        if (user.Key.Equals(nobangku))
                        {
                            MessageBox.Show(user.Value.pesan());
                            return "true";
                        }
                    }
                    break;
                case "Fast and Furious 8":
                    foreach (KeyValuePair<string, Bangku> user in Film_FF)
                    {
                        if (user.Key.Equals(nobangku))
                        {
                            MessageBox.Show(user.Value.pesan());
                            return "true";
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Nothing");
                    break;
            }
            
            return "false";
        }


        //untuk menginput data pengunjung
        int totalbangku_eg;
        int totalbangku_ff;
        int totalbangku_bp;
        private void cekbangku(object sender, EventArgs e) 
        {
            Button button = (Button)sender;
            string nobangku = button.Name.Substring(button.Name.Length - 2);
            string status = cekdetail(nobangku,judulfilm);
            
           
            
            
            if (status.Equals("true"))
            {
                a.pesan();
            }
            else if (status.Equals("false"))
            {
                //int jumlahbangku = int.Parse(cb_jmlorang.Text);

                //if (totalbangku_eg >=54 )
                //{
                //    MessageBox.Show("Studo Film \"Avengers - End Game\" Sudah Penuh", "Film Penuh", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}else if ( totalbangku_bp >= 54)
                //{
                //    MessageBox.Show("Studo Film \"Black Pather\" Sudah Penuh", "Film Penuh", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}
                //else if (totalbangku_ff >= 54)
                //{
                //    MessageBox.Show("Studo Film \"Fast and Furious 8\" Sudah Penuh", "Film Penuh", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}
                //else
                //{
                    Console.WriteLine(i--);
                    if (i >= 0)
                    {
                      
                        a = new Bangku(nobangku, tbPengunjung.Text, judulfilm);
                        if(judulfilm.Equals("Avengers - End Game")){
                            totalbangku_eg += 1;
                            Film_EndGame.Add(a.Seat, a);
                            Console.WriteLine("Total Bangku EG " + totalbangku_eg + "A");
                        }else if(judulfilm.Equals("Black Pather")){
                            totalbangku_bp += 1;
                            Film_BP.Add(a.Seat, a);
                            Console.WriteLine("Total Bangku BP" + totalbangku_bp + "A");
                        }else if (judulfilm.Equals("Fast and Furious 8")){
                            totalbangku_ff += 1;
                            Film_FF.Add(a.Seat, a);
                            Console.WriteLine("Total Bangku FF" + totalbangku_ff + "A");
                        }else{
                            MessageBox.Show("Fatal Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        a.change(button);
                    }else{
                        if (MessageBox.Show("Jumlah bangku berlebih, Kembali ke halaman pilih Film?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            backtofilm();
                        }
                    }
                }
            //}else {}
        }

        void backtofilm()
        {
            kontentfilm.Show();
            kontentbangku_ff.Hide();
            kontentbangku_eg.Hide();
            kontentbangku_bp.Hide();
            tbPengunjung.Text = "";
            cb_jmlorang.Text = "1";
            i = 0;
            navigasi(true, false);
            if(Film_EndGame.Count == 54)
            {
                pictureBox1.Image = Image.FromFile("D:\\2 TI A\\Andra_2TIA_BAD\\Program\\Project_UTS\\Project_UTS_v1\\Project_UTS_v1\\img\\poster_endgame_full.jpg");
                btnEG.Enabled = false;
            }
            if (Film_BP.Count == 54)
            {
                pictureBox2.Image = Image.FromFile("D:\\2 TI A\\Andra_2TIA_BAD\\Program\\Project_UTS\\Project_UTS_v1\\Project_UTS_v1\\img\\poster_blackpanther_full.jpg");
                btnBP.Enabled = false;
            }
            if (Film_FF.Count == 54)
            {
                pictureBox3.Image = Image.FromFile("D:\\2 TI A\\Andra_2TIA_BAD\\Program\\Project_UTS\\Project_UTS_v1\\Project_UTS_v1\\img\\poster_ff8_full.jpg");
                btnFF.Enabled = false;
            }
        }

        private void getjudulfilm(object sender, EventArgs e)
        {

            //if (Film_EndGame.Count == 54 || Film_BP.Count == 54)
            //{
            //    MessageBox.Show("Studo Film Sudah Penuh", "Film Penuh", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            //else {
                i = int.Parse(cb_jmlorang.Text);
                Button inibutton = (Button)sender;
                judulfilm = inibutton.Text;
                string namabutton = inibutton.Name;
               

                if (namabutton == "btnFF"){

                   
                        if (totalbangku_ff + int.Parse(cb_jmlorang.Text) > 54)
                        {
                            MessageBox.Show("Jumlah pengungjung memenuhi kapastia", "Film Penuh", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }else {
                            MessageBox.Show(judulfilm);
                            kontentfilm.Hide();
                            kontentbangku_eg.Hide();
                            kontentbangku_bp.Hide();
                            kontentbangku_ff.Show();
                        }
                    
                }
                else if(namabutton == "btnEG"){
                    
                        if (totalbangku_eg + int.Parse(cb_jmlorang.Text) > 54){
                            MessageBox.Show("Jumlah pengungjung memenuhi kapastia", "Film Penuh", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }else {
                            MessageBox.Show(judulfilm);
                            kontentfilm.Hide();
                            kontentbangku_eg.Show();
                            kontentbangku_bp.Hide();
                            kontentbangku_ff.Hide();
                        }
                    

                }else{
                   
                   
                        if (totalbangku_bp + int.Parse(cb_jmlorang.Text) > 54)
                        {
                            MessageBox.Show("Jumlah pengungjung memenuhi kapastia", "Film Penuh", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }else{
                            MessageBox.Show(judulfilm);
                            kontentfilm.Hide();
                            kontentbangku_eg.Hide();
                            kontentbangku_bp.Show();
                            kontentbangku_ff.Hide();
                        }
                    
                }

                
            }
        //}

      


        private void panel6_Click_1(object sender, EventArgs e)
        {

            foreach (KeyValuePair<string, Bangku> item in Film_BP)
            {
                Console.WriteLine("-------------------------------------------------\n" +
                    "Key: {0}, Value: {1}", item.Key, item.Value.pesan());
            }

           
        }

        private void my_timer_Tick(object sender, EventArgs e)
        {
            if (frmSrl == 1)
            {
                frmSrl++;
                kontentfilm.Show();
            }
            else
                frmSrl = 1;
        }
        int frmSrl = 1;

        private void backtofilm(object sender, EventArgs e)
        {
            backtofilm();
        }

        private void b(object sender, PaintEventArgs e)
        {

        }
    }
}
