using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter09Exrcise06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblReenterPassword.Visible = true;
            txtReenterPassword.Visible = true;
            txtReenterPassword.Focus();
            btnReenter.Visible = true;
        }



        private void lblReenterPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnReenter_Click(object sender, EventArgs e)
        {
            string passwordFirst = txtPassword.Text;
            string passwordSecond = txtReenterPassword.Text;
            btnReset.Visible = true;
            if (passwordFirst==passwordSecond) 
            {
                MessageBox.Show("Passwords match", "Matching Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Passwords do not match", "Matching Result",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.Focus();
            txtReenterPassword.Clear();
            lblReenterPassword.Visible=false;
            txtReenterPassword.Visible = false;
            btnReenter.Visible=false;
            btnReset.Visible=false;
        }
    }
}
