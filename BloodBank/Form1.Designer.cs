namespace BloodBank
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
            this.btnDonate = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pBSearch = new System.Windows.Forms.PictureBox();
            this.pBDonate = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRedLine = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDonate
            // 
            this.btnDonate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.ForeColor = System.Drawing.Color.Red;
            this.btnDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonate.Location = new System.Drawing.Point(301, 406);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(175, 67);
            this.btnDonate.TabIndex = 0;
            this.btnDonate.Text = "    Donate Now";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pBSearch);
            this.panelHeader.Controls.Add(this.pBDonate);
            this.panelHeader.Controls.Add(this.lbName);
            this.panelHeader.Controls.Add(this.lbType);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.panelRedLine);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(774, 53);
            this.panelHeader.TabIndex = 3;
            // 
            // pBSearch
            // 
            this.pBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBSearch.Image = global::BloodBank.Properties.Resources.search;
            this.pBSearch.Location = new System.Drawing.Point(727, 9);
            this.pBSearch.Name = "pBSearch";
            this.pBSearch.Size = new System.Drawing.Size(35, 35);
            this.pBSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSearch.TabIndex = 4;
            this.pBSearch.TabStop = false;
            this.pBSearch.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pBDonate
            // 
            this.pBDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBDonate.BackColor = System.Drawing.Color.Transparent;
            this.pBDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBDonate.Image = global::BloodBank.Properties.Resources.plus;
            this.pBDonate.Location = new System.Drawing.Point(660, 9);
            this.pBDonate.Name = "pBDonate";
            this.pBDonate.Size = new System.Drawing.Size(35, 35);
            this.pBDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBDonate.TabIndex = 6;
            this.pBDonate.TabStop = false;
            this.pBDonate.Click += new System.EventHandler(this.pBDonate_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(45, 5);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 16);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Name";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(45, 32);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(32, 16);
            this.lbType.TabIndex = 11;
            this.lbType.Text = "Role";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::BloodBank.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // panelRedLine
            // 
            this.panelRedLine.BackColor = System.Drawing.Color.Red;
            this.panelRedLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRedLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRedLine.Location = new System.Drawing.Point(0, 50);
            this.panelRedLine.Name = "panelRedLine";
            this.panelRedLine.Size = new System.Drawing.Size(774, 3);
            this.panelRedLine.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BloodBank.Properties.Resources.blood_bank;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 506);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnDonate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelRedLine;
        private System.Windows.Forms.PictureBox pBSearch;
        private System.Windows.Forms.PictureBox pBDonate;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbType;
        public System.Windows.Forms.Label lbName;

    }
}

