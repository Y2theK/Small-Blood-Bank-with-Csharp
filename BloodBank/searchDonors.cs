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
    public partial class searchDonors : Form
    {
        public searchDonors()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
        private void searchDonors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBBMSDataSet6.donorLists' table. You can move, or remove it, as needed.
            //this.donorListsTableAdapter.Fill(this.dbBBMSDataSet6.donorsLists);
            getDonorList();
        }
        private void getDonorList()
        {
            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from donorsLists", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void pBBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void pBBloodSearch_Click(object sender, EventArgs e)
        {
            con.Open();
           // SqlDataAdapter adr = new SqlDataAdapter("select * from donorLists where Name like '"+ tbSearch.Text + "'",con);
            SqlDataAdapter adr = new SqlDataAdapter("select * from donorsLists where BloodType = '" + cbBloodType.Text + "'", con);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OneDonorDataForm k = new OneDonorDataForm();
          
           // this.Hide();
           
            test t = new test();
            t.tbName.Text = "Lee Pl";
            k.lbNo.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            k.tbName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            k.tbFname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            k.cbBloodType.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            k.tbAge.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            k.tbPhNo.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            k.tbAddress.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            k.tbWeight.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            k.tbHeight.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            k.tbBloodPressure.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            k.btnRegister.Visible = false;
            k.ShowDialog();
            
           
           
        }

        private void pBrefresh_Click(object sender, EventArgs e)
        {
            getDonorList();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OneDonorDataForm d = new OneDonorDataForm();
            d.btnUpdate.Visible = false;
            d.btnDelete.Visible = false;
            d.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
