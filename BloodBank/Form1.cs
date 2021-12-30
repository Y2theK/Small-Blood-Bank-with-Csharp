using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BloodBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getDonorList();
        }
        private void getDonorList()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            searchDonors s = new searchDonors();
            this.Hide();
            s.ShowDialog();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            /*donateForm d = new donateForm();
            this.Hide();
            d.ShowDialog();*/
            OneDonorDataForm one = new OneDonorDataForm();
            one.btnDelete.Visible = false;
            one.btnUpdate.Visible = false;
            one.ShowDialog();
        }

        private void pBDonate_Click(object sender, EventArgs e)
        {
            OneDonorDataForm one = new OneDonorDataForm();
            one.btnDelete.Visible = false;
            one.btnUpdate.Visible = false;
            one.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            logIn l = new logIn();
            l.ShowDialog();
        }

 
    }
}
