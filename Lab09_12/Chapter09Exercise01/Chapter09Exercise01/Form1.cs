using System;
using System.Windows.Forms;

namespace Chapter09Exercise01
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nameInput = txtName.Text;
            lblResult.Text = $"Congratulation!, {nameInput}, you retrieved the data!";
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
