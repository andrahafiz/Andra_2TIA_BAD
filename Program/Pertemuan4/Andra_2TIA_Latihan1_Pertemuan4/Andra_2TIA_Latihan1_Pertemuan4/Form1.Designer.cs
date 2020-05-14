namespace Andra_2TIA_Latihan1_Pertemuan4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbProdi = new System.Windows.Forms.TextBox();
            this.cbAngkatan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNilaiAlpro = new System.Windows.Forms.TextBox();
            this.checkMatkulLain = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAngkatan);
            this.groupBox1.Controls.Add(this.tbProdi);
            this.groupBox1.Controls.Add(this.tbNama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identitas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkMatkulLain);
            this.groupBox2.Controls.Add(this.tbNilaiAlpro);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(44, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mata Kuliah";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prodi";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(120, 34);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(201, 22);
            this.tbNama.TabIndex = 6;
            // 
            // tbProdi
            // 
            this.tbProdi.Location = new System.Drawing.Point(120, 106);
            this.tbProdi.Name = "tbProdi";
            this.tbProdi.Size = new System.Drawing.Size(201, 22);
            this.tbProdi.TabIndex = 7;
            // 
            // cbAngkatan
            // 
            this.cbAngkatan.FormattingEnabled = true;
            this.cbAngkatan.Location = new System.Drawing.Point(120, 68);
            this.cbAngkatan.Name = "cbAngkatan";
            this.cbAngkatan.Size = new System.Drawing.Size(121, 24);
            this.cbAngkatan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nilai Alpro";
            // 
            // tbNilaiAlpro
            // 
            this.tbNilaiAlpro.Location = new System.Drawing.Point(120, 55);
            this.tbNilaiAlpro.Name = "tbNilaiAlpro";
            this.tbNilaiAlpro.Size = new System.Drawing.Size(62, 22);
            this.tbNilaiAlpro.TabIndex = 9;
            this.tbNilaiAlpro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNilaiAlpro_KeyPress);
            // 
            // checkMatkulLain
            // 
            this.checkMatkulLain.AutoSize = true;
            this.checkMatkulLain.Location = new System.Drawing.Point(223, 56);
            this.checkMatkulLain.Name = "checkMatkulLain";
            this.checkMatkulLain.Size = new System.Drawing.Size(59, 21);
            this.checkMatkulLain.TabIndex = 10;
            this.checkMatkulLain.Text = "BDD";
            this.checkMatkulLain.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mata Kuliah Lainnya";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAngkatan;
        private System.Windows.Forms.TextBox tbProdi;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkMatkulLain;
        private System.Windows.Forms.TextBox tbNilaiAlpro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

