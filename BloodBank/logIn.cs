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
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }
      //  SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void searchData()
        {
            if (tbUsername.Text == "" || tbPassward.Text == "" || cbType.Text == "")
                MessageBox.Show("Make sure you enter all the form");
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from bbAccouts where Username = @user and Passward = @pwd and Type = @type", con);
                cmd.Parameters.AddWithValue("@user", tbUsername.Text);
                cmd.Parameters.AddWithValue("@pwd", tbPassward.Text);
                cmd.Parameters.AddWithValue("@type", cbType.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    //if (cbType.Text == "admin")
                    {
                        Form1 f = new Form1();
                        f.lbType.Text = cbType.Text;
                        f.lbName.Text = tbUsername.Text;
                        f.ShowDialog();
                        this.Close();
                    }
                   

                }
                else
                {
                    MessageBox.Show("Invalid Try Again");
                }
                con.Close();

                

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
