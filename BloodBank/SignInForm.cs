using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
            tbEmail.BackColor = Color.Violet;
            
        }

        private void pBDonate_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|* .jpg";
           // openFileDialog1.Filter = "jpg files(*.jpg)|*.jpg| Png files(*.png)|*.png| All files(*.*)|*.*|"; //for all files
            DialogResult res = openFileDialog1.ShowDialog();
            if(res == DialogResult.OK)
            {
                
                pbProfile.Image = Image.FromFile(openFileDialog1.FileName);
                cpbprofile.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "youremail@gmail.com")
                tbEmail.Text = "";
            tbEmail.ForeColor = Color.Black;
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
                tbEmail.Text = "";
            tbEmail.ForeColor = Color.Silver;
        }

        private void circularButton5_Click(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
