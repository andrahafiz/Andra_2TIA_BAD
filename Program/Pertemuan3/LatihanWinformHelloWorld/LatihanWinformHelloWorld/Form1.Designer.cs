namespace LatihanWinformHelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNdepan = new System.Windows.Forms.TextBox();
            this.txtNbel = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lokasiAlamat = new System.Windows.Forms.ListBox();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLelaki = new System.Windows.Forms.RadioButton();
            this.bKlik = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(160, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hallo Dunia!!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlamat);
            this.groupBox1.Controls.Add(this.txtNbel);
            this.groupBox1.Controls.Add(this.txtNdepan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perkenalan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Belakang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Depan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alamat";
            // 
            // txtNdepan
            // 
            this.txtNdepan.Location = new System.Drawing.Point(139, 30);
            this.txtNdepan.Name = "txtNdepan";
            this.txtNdepan.Size = new System.Drawing.Size(216, 22);
            this.txtNdepan.TabIndex = 3;
            // 
            // txtNbel
            // 
            this.txtNbel.Location = new System.Drawing.Point(139, 86);
            this.txtNbel.Name = "txtNbel";
            this.txtNbel.Size = new System.Drawing.Size(216, 22);
            this.txtNbel.TabIndex = 4;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(139, 140);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(216, 22);
            this.txtAlamat.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Daerah Rumah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Jenis Kelamin";
            // 
            // lokasiAlamat
            // 
            this.lokasiAlamat.FormattingEnabled = true;
            this.lokasiAlamat.ItemHeight = 16;
            this.lokasiAlamat.Items.AddRange(new object[] {
            "Rumbai",
            "Panam",
            "Pandau",
            "Marpoyan"});
            this.lokasiAlamat.Location = new System.Drawing.Point(38, 307);
            this.lokasiAlamat.Name = "lokasiAlamat";
            this.lokasiAlamat.Size = new System.Drawing.Size(120, 84);
            this.lokasiAlamat.TabIndex = 8;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(286, 307);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(102, 21);
            this.rbPerempuan.TabIndex = 9;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLelaki
            // 
            this.rbLelaki.AutoSize = true;
            this.rbLelaki.Location = new System.Drawing.Point(286, 334);
            this.rbLelaki.Name = "rbLelaki";
            this.rbLelaki.Size = new System.Drawing.Size(81, 21);
            this.rbLelaki.TabIndex = 10;
            this.rbLelaki.TabStop = true;
            this.rbLelaki.Text = "Laki-laki";
            this.rbLelaki.UseVisualStyleBackColor = true;
            // 
            // bKlik
            // 
            this.bKlik.Location = new System.Drawing.Point(286, 385);
            this.bKlik.Name = "bKlik";
            this.bKlik.Size = new System.Drawing.Size(107, 32);
            this.bKlik.TabIndex = 11;
            this.bKlik.Text = "Klik";
            this.bKlik.UseVisualStyleBackColor = true;
            this.bKlik.Click += new System.EventHandler(this.bKlik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.bKlik);
            this.Controls.Add(this.rbLelaki);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.lokasiAlamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNbel;
        private System.Windows.Forms.TextBox txtNdepan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lokasiAlamat;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLelaki;
        private System.Windows.Forms.Button bKlik;
    }
}

