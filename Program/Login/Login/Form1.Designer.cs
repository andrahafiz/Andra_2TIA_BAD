namespace Login
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.Katasandi = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Katasandi);
            this.groupBox1.Controls.Add(this.User);
            this.groupBox1.Controls.Add(this.Pass);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Location = new System.Drawing.Point(335, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Katasandi
            // 
            this.Katasandi.Location = new System.Drawing.Point(29, 111);
            this.Katasandi.Name = "Katasandi";
            this.Katasandi.Size = new System.Drawing.Size(182, 20);
            this.Katasandi.TabIndex = 3;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(29, 51);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(182, 20);
            this.User.TabIndex = 2;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(29, 89);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(66, 14);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(28, 32);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(67, 14);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(597, 228);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Katasandi;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button button1;
    }
}

