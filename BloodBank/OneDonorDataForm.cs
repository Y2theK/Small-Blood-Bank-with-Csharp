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
    public partial class OneDonorDataForm : Form
    {
        public OneDonorDataForm()
        {
            InitializeComponent();
            //tbName.BackColor = Color.Transparent;
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from donorsLists where No = '" +lbNo.Text+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Sucessfully...");
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update donorsLists set Name='" + tbName.Text + "',FatherName='" + tbFname.Text + "',BloodType='" + cbBloodType.Text + "',Age='" + tbAge.Text + "',Address ='" + tbAddress.Text + "',Height ='" + tbHeight.Text + "',BodyWeight ='" + tbWeight.Text + "',BloodPressure='" + tbBloodPressure.Text + "', PhoneNo ='" + tbPhNo.Text + "' where No  = '" + lbNo.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Sucessfully...");
            this.Close();
        }
        
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBloodPressure_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBloodType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

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
            searchDonors searchDonor = new searchDonors();
            searchDonor.dataGridView1.DataSource = dt;
                      //dataGridView1.DataSource = dt;
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
                String sql = "insert into donorsLists(Name,PhoneNo,Gender,BloodType,FatherName,Age,Address,BodyWeight,BloodPressure,Height) Values(@Name,@PhoneNo,@Gender,@bloodType,@FatherName,@Age,@Address,@Weight,@BloodPressure,@Height)";
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
                //getDonorList();
                clearAll();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }
        
    }
}
