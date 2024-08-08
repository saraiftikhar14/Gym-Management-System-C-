using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymVideo
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this member?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection("data source=LAPTOP-RRPL02LC\\SQLEXPRESS; database=gym; integrated security=True"))
                {
                    try
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM NewMember WHERE MID = @MID", con))
                        {
                            cmd.Parameters.AddWithValue("@MID", textBox1.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Member deleted successfully.");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Member not found.");
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

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection("data source=LAPTOP-RRPL02LC\\SQLEXPRESS; database=gym; integrated security=True"))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM NewMember", con))
                    {
                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataSet DS = new DataSet();
                        DA.Fill(DS);
                        dataGridView1.DataSource = DS.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
