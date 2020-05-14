namespace Project_UTS_v1
{
    partial class Form_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.toolbar = new System.Windows.Forms.Panel();
            this.garisputih = new System.Windows.Forms.Panel();
            this.garisputih1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.content = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnminimiza = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.Panel();
            this.Label_Tanggal = new System.Windows.Forms.Label();
            this.Label_Second = new System.Windows.Forms.Label();
            this.Label_Jam = new System.Windows.Forms.Label();
            this.toolbar.SuspendLayout();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.toolbar.Controls.Add(this.garisputih);
            this.toolbar.Controls.Add(this.btnminimiza);
            this.toolbar.Controls.Add(this.btnclose);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(852, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(420, 38);
            this.toolbar.TabIndex = 1;
            // 
            // garisputih
            // 
            this.garisputih.BackColor = System.Drawing.Color.White;
            this.garisputih.Dock = System.Windows.Forms.DockStyle.Left;
            this.garisputih.Location = new System.Drawing.Point(0, 0);
            this.garisputih.Name = "garisputih";
            this.garisputih.Size = new System.Drawing.Size(5, 38);
            this.garisputih.TabIndex = 5;
            // 
            // garisputih1
            // 
            this.garisputih1.BackColor = System.Drawing.Color.White;
            this.garisputih1.Dock = System.Windows.Forms.DockStyle.Left;
            this.garisputih1.Location = new System.Drawing.Point(852, 38);
            this.garisputih1.Name = "garisputih1";
            this.garisputih1.Size = new System.Drawing.Size(5, 520);
            this.garisputih1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.content.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("content.BackgroundImage")));
            this.content.Controls.Add(this.btnlogin);
            this.content.Controls.Add(this.label1);
            this.content.Controls.Add(this.panel3);
            this.content.Controls.Add(this.panel2);
            this.content.Controls.Add(this.tbpass);
            this.content.Controls.Add(this.panel1);
            this.content.Controls.Add(this.tbusername);
            this.content.Controls.Add(this.pictureBox2);
            this.content.Controls.Add(this.pictureBox1);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(852, 38);
            this.content.Margin = new System.Windows.Forms.Padding(0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(420, 520);
            this.content.TabIndex = 2;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.Location = new System.Drawing.Point(107, 309);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnlogin.Size = new System.Drawing.Size(214, 66);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = " Login";
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.panel3.Location = new System.Drawing.Point(169, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 2);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.panel2.Location = new System.Drawing.Point(59, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 2);
            this.panel2.TabIndex = 6;
            // 
            // tbpass
            // 
            this.tbpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(185)))), ((int)(((byte)(149)))));
            this.tbpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpass.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(1)))));
            this.tbpass.Location = new System.Drawing.Point(99, 235);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(246, 27);
            this.tbpass.TabIndex = 5;
            this.tbpass.Text = "Password";
            this.tbpass.Click += new System.EventHandler(this.tbpass_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.panel1.Location = new System.Drawing.Point(59, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 2);
            this.panel1.TabIndex = 4;
            // 
            // tbusername
            // 
            this.tbusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(191)))), ((int)(((byte)(160)))));
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(1)))));
            this.tbusername.Location = new System.Drawing.Point(99, 159);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(246, 27);
            this.tbusername.TabIndex = 3;
            this.tbusername.Text = "Username";
            this.tbusername.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(59, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(128, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(59, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnminimiza
            // 
            this.btnminimiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimiza.FlatAppearance.BorderSize = 0;
            this.btnminimiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimiza.Image = ((System.Drawing.Image)(resources.GetObject("btnminimiza.Image")));
            this.btnminimiza.Location = new System.Drawing.Point(361, 9);
            this.btnminimiza.Margin = new System.Windows.Forms.Padding(0);
            this.btnminimiza.Name = "btnminimiza";
            this.btnminimiza.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnminimiza.Size = new System.Drawing.Size(25, 25);
            this.btnminimiza.TabIndex = 4;
            this.btnminimiza.UseVisualStyleBackColor = true;
            this.btnminimiza.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(386, 9);
            this.btnclose.Margin = new System.Windows.Forms.Padding(0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnclose.Size = new System.Drawing.Size(25, 25);
            this.btnclose.TabIndex = 0;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebar.BackgroundImage")));
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidebar.Controls.Add(this.Label_Tanggal);
            this.sidebar.Controls.Add(this.Label_Second);
            this.sidebar.Controls.Add(this.Label_Jam);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(852, 558);
            this.sidebar.TabIndex = 0;
            // 
            // Label_Tanggal
            // 
            this.Label_Tanggal.AutoSize = true;
            this.Label_Tanggal.BackColor = System.Drawing.Color.Transparent;
            this.Label_Tanggal.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Tanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.Label_Tanggal.Location = new System.Drawing.Point(40, 510);
            this.Label_Tanggal.Name = "Label_Tanggal";
            this.Label_Tanggal.Size = new System.Drawing.Size(67, 25);
            this.Label_Tanggal.TabIndex = 2;
            this.Label_Tanggal.Text = "label1";
            // 
            // Label_Second
            // 
            this.Label_Second.AutoSize = true;
            this.Label_Second.BackColor = System.Drawing.Color.Transparent;
            this.Label_Second.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Second.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.Label_Second.Location = new System.Drawing.Point(184, 44);
            this.Label_Second.Name = "Label_Second";
            this.Label_Second.Size = new System.Drawing.Size(57, 40);
            this.Label_Second.TabIndex = 1;
            this.Label_Second.Text = "00";
            this.Label_Second.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Jam
            // 
            this.Label_Jam.AutoSize = true;
            this.Label_Jam.BackColor = System.Drawing.Color.Transparent;
            this.Label_Jam.Font = new System.Drawing.Font("DS-Digital", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Jam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.Label_Jam.Location = new System.Drawing.Point(34, 25);
            this.Label_Jam.Name = "Label_Jam";
            this.Label_Jam.Size = new System.Drawing.Size(165, 63);
            this.Label_Jam.TabIndex = 0;
            this.Label_Jam.Text = "00:00";
            this.Label_Jam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 558);
            this.Controls.Add(this.garisputih1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolbar.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel garisputih1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnminimiza;
        private System.Windows.Forms.Panel garisputih;
        private System.Windows.Forms.Label Label_Jam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Label_Second;
        private System.Windows.Forms.Label Label_Tanggal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnlogin;
    }
}

