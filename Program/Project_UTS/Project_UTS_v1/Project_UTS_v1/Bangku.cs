using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UTS_v1
{
    class Bangku
    {

        private string bangku;
        private string name;
        private string film;

        public Bangku(string a, string b, string c)
        {
            bangku = a;
            name = b;
            film = c;
        }

        public string Name
        {
            get{return this.name;}
            set{this.name = value;}
        }

        public string Seat
        {
            get{return this.bangku;}
            set{this.bangku = value;}
        }

        public string Film
        {
            get { return this.film; }
            set { this.film = value; }
        }


        public void change(Button btn)
        {
            btn.Image = Image.FromFile("D:\\2 TI A\\Andra_2TIA_BAD\\Program\\Project_UTS\\Project_UTS_v1\\Project_UTS_v1\\img\\bangku-on.png");
        }

        public string pesan()
        {
            return "Judul Film :"+film+"\nNo Bangku : " + bangku + "\nNama : "+name;
        }
    }
}
