using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleThiTracNghiem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtID.Text != "")
            {
                frmThiTracNghiem frm = new frmThiTracNghiem();

                Candidates.Name = txtName.Text;
                Candidates.ID = txtID.Text;

                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid!!", "Enter information");
            }

        }
    }
}
