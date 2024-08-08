using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace gymVideo
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
            private void btnSave_Click(object sender, EventArgs e)
            {
                string fname = txtFirstName.Text;
                string lname = txtLastName.Text;

                string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;

                string dob = dateTimePickerDOB.Text;
                long mobile = Int64.Parse(txtMobile.Text);
                string email = txtEmail.Text;
                string joindate = dateTimePickerJoinDate.Text;
                string gymTime = comboBoxGymTime.Text;
                string address = txtAddress.Text;
                string membership = comboBoxMembership.Text;

                try
                {
                    using (SqlConnection con = new SqlConnection("data source=LAPTOP-RRPL02LC\\SQLEXPRESS; database=gym; integrated security=True"))
                    {
                        con.Open();
                        string sql = "INSERT INTO NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime) " +
                                     "VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @Gymtime, @Maddress, @MembershipTime)";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@Fname", fname);
                        cmd.Parameters.AddWithValue("@Lname", lname);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Dob", dob);
                        cmd.Parameters.AddWithValue("@Mobile", mobile);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@JoinDate", joindate);
                        cmd.Parameters.AddWithValue("@Gymtime", gymTime);
                        cmd.Parameters.AddWithValue("@Maddress", address);
                        cmd.Parameters.AddWithValue("@MembershipTime", membership);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected + " Data Saved.");

                        // Optionally clear fields or perform other actions after successful insert
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }




        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();
            txtAddress.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }
    }
}

