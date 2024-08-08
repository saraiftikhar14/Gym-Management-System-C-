using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gymVideo
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            ViewEquipment ve= new ViewEquipment();
            ve.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String EquipName = txtEquipName.Text;
                String Description = txtDescription.Text;
                String MUsed = txtMusclesUsed.Text;
                String DDate = dateTimePickerDeliveryDate.Value.ToString("yyyy-MM-dd");
                Int64 cost = Int64.Parse(txtCost.Text);

                using (SqlConnection con = new SqlConnection("data source=LAPTOP-RRPL02LC\\SQLEXPRESS; database=gym; integrated security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Equipment (EquipName, EDescription, MUsed, DDate, Cost) VALUES (@EquipName, @EDescription, @MUsed, @DDate, @Cost)", con))
                    {
                        cmd.Parameters.AddWithValue("@EquipName", EquipName);
                        cmd.Parameters.AddWithValue("@EDescription", Description);
                        cmd.Parameters.AddWithValue("@MUsed", MUsed);
                        cmd.Parameters.AddWithValue("@DDate", DDate);
                        cmd.Parameters.AddWithValue("@Cost", cost);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data Saved.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
