using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gymVideo
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("data source=LAPTOP-RRPL02LC\\SQLEXPRESS; database=gym; integrated security=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM newMember WHERE MID = @MID", con))
                        {
                            cmd.Parameters.AddWithValue("@MID", txtSearch.Text.Trim());

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Some ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("data source=LAPTOP-RRPL02LC\\SQLEXPRESS; database=gym; integrated security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM newMember", con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
