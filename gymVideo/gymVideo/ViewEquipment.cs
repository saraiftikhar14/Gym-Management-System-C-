using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gymVideo
{
    public partial class ViewEquipment : Form
    {
        public ViewEquipment()
        {
            InitializeComponent();
        }

        private void ViewEquipment_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("data source=LAPTOP-RRPL02LC\\SQLEXPRESS; database=gym; integrated security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Equipment", con))
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
