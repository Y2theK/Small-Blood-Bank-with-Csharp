namespace BloodBank
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pBDonate = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.cpbprofile = new BloodBank.CircularPictureBox();
            this.circularButton5 = new BloodBank.CircularButton();
            this.circularButton4 = new BloodBank.CircularButton();
            this.circularButton3 = new BloodBank.CircularButton();
            this.circularButton2 = new BloodBank.CircularButton();
            this.circularButton1 = new BloodBank.CircularButton();
            this.circularButton6 = new BloodBank.CircularButton();
            this.circularButton7 = new BloodBank.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pBDonate
            // 
            this.pBDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBDonate.Image = ((System.Drawing.Image)(resources.GetObject("pBDonate.Image")));
            this.pBDonate.Location = new System.Drawing.Point(19, 357);
            this.pBDonate.Name = "pBDonate";
            this.pBDonate.Size = new System.Drawing.Size(35, 27);
            this.pBDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBDonate.TabIndex = 7;
            this.pBDonate.TabStop = false;
            this.pBDonate.Click += new System.EventHandler(this.pBDonate_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(206, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(206, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 83;
            // 
            // tbFname
            // 
            this.tbFname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFname.ForeColor = System.Drawing.Color.Black;
            this.tbFname.Location = new System.Drawing.Point(280, 250);
            this.tbFname.Multiline = true;
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(196, 32);
            this.tbFname.TabIndex = 82;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(280, 210);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 29);
            this.tbName.TabIndex = 81;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(203, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Passward";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(202, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "UserName";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(206, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 87;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Silver;
            this.tbEmail.Location = new System.Drawing.Point(307, 291);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(169, 32);
            this.tbEmail.TabIndex = 86;
            this.tbEmail.Text = "youremail@gmail.com";
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(203, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 85;
            this.label3.Text = "Email or Phone";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.BackColor = System.Drawing.Color.Red;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(307, 357);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(169, 36);
            this.btnRegister.TabIndex = 88;
            this.btnRegister.Text = "Save";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(206, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(106, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(149, 33);
            this.richTextBox1.TabIndex = 90;
            this.richTextBox1.Text = "";
            // 
            // pbProfile
            // 
            this.pbProfile.Location = new System.Drawing.Point(66, 256);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(100, 67);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 97;
            this.pbProfile.TabStop = false;
            // 
            // cpbprofile
            // 
            this.cpbprofile.Image = ((System.Drawing.Image)(resources.GetObject("cpbprofile.Image")));
            this.cpbprofile.Location = new System.Drawing.Point(280, 65);
            this.cpbprofile.Name = "cpbprofile";
            this.cpbprofile.Size = new System.Drawing.Size(140, 124);
            this.cpbprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpbprofile.TabIndex = 96;
            this.cpbprofile.TabStop = false;
            // 
            // circularButton5
            // 
            this.circularButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton5.BackgroundImage")));
            this.circularButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton5.FlatAppearance.BorderSize = 0;
            this.circularButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton5.Location = new System.Drawing.Point(12, 179);
            this.circularButton5.Name = "circularButton5";
            this.circularButton5.Size = new System.Drawing.Size(42, 34);
            this.circularButton5.TabIndex = 95;
            this.circularButton5.UseVisualStyleBackColor = true;
            this.circularButton5.Click += new System.EventHandler(this.circularButton5_Click);
            // 
            // circularButton4
            // 
            this.circularButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton4.BackgroundImage")));
            this.circularButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton4.FlatAppearance.BorderSize = 0;
            this.circularButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton4.Location = new System.Drawing.Point(101, 1);
            this.circularButton4.Name = "circularButton4";
            this.circularButton4.Size = new System.Drawing.Size(42, 34);
            this.circularButton4.TabIndex = 94;
            this.circularButton4.UseVisualStyleBackColor = true;
            // 
            // circularButton3
            // 
            this.circularButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton3.BackgroundImage")));
            this.circularButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton3.FlatAppearance.BorderSize = 0;
            this.circularButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton3.Location = new System.Drawing.Point(128, 41);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(50, 49);
            this.circularButton3.TabIndex = 93;
            this.circularButton3.UseVisualStyleBackColor = true;
            this.circularButton3.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton2.BackgroundImage")));
            this.circularButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton2.FlatAppearance.BorderSize = 0;
            this.circularButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton2.Location = new System.Drawing.Point(53, 1);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(42, 34);
            this.circularButton2.TabIndex = 92;
            this.circularButton2.UseVisualStyleBackColor = true;
            // 
            // circularButton1
            // 
            this.circularButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton1.BackgroundImage")));
            this.circularButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Location = new System.Drawing.Point(5, 1);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(91, 77);
            this.circularButton1.TabIndex = 91;
            this.circularButton1.UseVisualStyleBackColor = true;
            // 
            // circularButton6
            // 
            this.circularButton6.Location = new System.Drawing.Point(102, 41);
            this.circularButton6.Name = "circularButton6";
            this.circularButton6.Size = new System.Drawing.Size(86, 49);
            this.circularButton6.TabIndex = 98;
            this.circularButton6.Text = "circularButton6";
            this.circularButton6.UseVisualStyleBackColor = true;
            // 
            // circularButton7
            // 
            this.circularButton7.Location = new System.Drawing.Point(198, 53);
            this.circularButton7.Name = "circularButton7";
            this.circularButton7.Size = new System.Drawing.Size(57, 37);
            this.circularButton7.TabIndex = 99;
            this.circularButton7.Text = "circularButton7";
            this.circularButton7.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 477);
            this.Controls.Add(this.circularButton7);
            this.Controls.Add(this.circularButton6);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.cpbprofile);
            this.Controls.Add(this.circularButton5);
            this.Controls.Add(this.circularButton4);
            this.Controls.Add(this.circularButton3);
            this.Controls.Add(this.circularButton2);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBDonate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInForm";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbprofile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pBDonate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox tbFname;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CircularButton circularButton1;
        private CircularButton circularButton2;
        private CircularButton circularButton3;
        private CircularButton circularButton4;
        private CircularButton circularButton5;
        private CircularPictureBox cpbprofile;
        private System.Windows.Forms.PictureBox pbProfile;
        private CircularButton circularButton6;
        private CircularButton circularButton7;
    }
}