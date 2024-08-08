using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gymVideo
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String fname = txtFname.Text;
                String lname = txtLname.Text;

                String gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;

                DateTime dob = dateTimePickerDOB.Value;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String email = txtEmail.Text;
                String state = txtState.Text;
                String city = txtCity.Text;

                using (SqlConnection con = new SqlConnection("data source=LAPTOP-RRPL02LC\\SQLEXPRESS; database=gym; integrated security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Statee, City) VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @Statee, @City)", con))
                    {
                        cmd.Parameters.AddWithValue("@Fname", fname);
                        cmd.Parameters.AddWithValue("@Lname", lname);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Dob", dob.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Mobile", mobile);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@JoinDate", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Statee", state);
                        cmd.Parameters.AddWithValue("@City", city);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data Saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobile.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtEmail.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJOINDate.Value = DateTime.Now;
        }
    }
}
