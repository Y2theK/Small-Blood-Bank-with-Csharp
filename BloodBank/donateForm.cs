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
    public partial class donateForm : Form
    {
        public donateForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void donateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBBMSDataSet5.donorLists' table. You can move, or remove it, as needed.
            this.donorListsTableAdapter4.Fill(this.dbBBMSDataSet5.donorLists);
            // TODO: This line of code loads data into the 'dbBBMSDataSet4.donorLists' table. You can move, or remove it, as needed.
            this.donorListsTableAdapter3.Fill(this.dbBBMSDataSet4.donorLists);
            // TODO: This line of code loads data into the 'dbBBMSDataSet3.donorLists' table. You can move, or remove it, as needed.
            this.donorListsTableAdapter2.Fill(this.dbBBMSDataSet3.donorLists);
            // TODO: This line of code loads data into the 'dbBBMSDataSet2.donorLists' table. You can move, or remove it, as needed.
            this.donorListsTableAdapter1.Fill(this.dbBBMSDataSet2.donorLists);
            // TODO: This line of code loads data into the 'dbBBMSDataSet1.donorLists' table. You can move, or remove it, as needed.
            this.donorListsTableAdapter.Fill(this.dbBBMSDataSet1.donorLists);
            // TODO: This line of code loads data into the 'dbBBMSDataSet.donorList' table. You can move, or remove it, as needed.
           // this.donorListTableAdapter.Fill(this.dbBBMSDataSet.donorList);
            getDonorList();
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
        }

        private void getDonorList()
        {
           // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from donorLists", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void clearAll()
        {
            tbName.Text = "";
            tbFname.Text = "";
            tbPhNo.Text = "";
            tbAge.Text = "";
            tbAddress.Text = "";
            tbBloodPressure.Text = "";
            tbWeight.Text = "";
            tbHeight.Text = "";
            cbBloodType.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //if(isValid())
            {
               /*SqlCommand cmd = new SqlCommand("INSERT INTO donorLists VALUES(@Name,@PhoneNo,@FatherName,@Age,@Address)",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", tbName.Text);
                cmd.Parameters.AddWithValue("@gender", rbMale.Text);
                cmd.Parameters.AddWithValue("@bloodType", cbBloodType.SelectedItem);
                cmd.Parameters.AddWithValue("@PhoneNo", tbPhNo.Text);
                cmd.Parameters.AddWithValue("@FatherName", tbFname.Text);
                cmd.Parameters.AddWithValue("@Age", tbAge.Text);
                cmd.Parameters.AddWithValue("@Address", tbAddress.Text);*/
                
                con.Open();
                String sql = "insert into donorLists(Name,PhoneNo,Gender,BloodType,FatherName,Age,Address,BodyWeight,BloodPressure,Height) Values(@Name,@PhoneNo,@Gender,@bloodType,@FatherName,@Age,@Address,@Weight,@BloodPressure,@Height)";
                SqlCommand cmd = new SqlCommand(sql, con);
              //  cmd.Parameters.AddWithValue("@no", tbName.Text);
                cmd.Parameters.AddWithValue("@Name", tbName.Text);
                if (rbMale.Checked)
                    cmd.Parameters.AddWithValue("@Gender", rbMale.Text);
                else if (rbFemale.Checked)
                    cmd.Parameters.AddWithValue("@Gender", rbFemale.Text);
                    

                
                
                cmd.Parameters.AddWithValue("@bloodType", cbBloodType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PhoneNo", tbPhNo.Text);
                cmd.Parameters.AddWithValue("@FatherName", tbFname.Text);
                cmd.Parameters.AddWithValue("@Age", tbAge.Text);
                cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                cmd.Parameters.AddWithValue("@Weight", tbWeight.Text);
                cmd.Parameters.AddWithValue("@BloodPressure", tbBloodPressure.Text);
                cmd.Parameters.AddWithValue("@Height", tbHeight.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Donor Registered Sucessfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getDonorList();
                clearAll();
            }
        }

        private bool isValid()
        {
            if(tbName.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbFname.Text == string.Empty)
            {
                MessageBox.Show("Father Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbPhNo.Text == string.Empty)
            {
                MessageBox.Show("Phone No is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbAge.Text == string.Empty)
            {
                MessageBox.Show("Age is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbAddress.Text == string.Empty)
            {
                MessageBox.Show("Address is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void cbBloodType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pBBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        
    }
}
