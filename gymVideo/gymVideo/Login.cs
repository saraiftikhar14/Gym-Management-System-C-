using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymVideo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtBoxUserName.Text=="Admin" &&  txtBoxPassword.Text=="12345")
            { 
                Form1 fm= new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User ID & Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
