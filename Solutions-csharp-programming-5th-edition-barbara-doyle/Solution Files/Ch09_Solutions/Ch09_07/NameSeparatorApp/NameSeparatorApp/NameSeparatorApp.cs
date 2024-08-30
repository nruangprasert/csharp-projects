/* NameSeparatorApp.cs
 * This application retrieves a full name
 * from a user. It separates and displays
 * the full name into first, last 
 * and middle (if included) names.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSeparatorApp
{
    public partial class NameSeparatorAppForm : Form
    {
        public NameSeparatorAppForm()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string[] name = new string[5];

            string fullName,
                   first,
                   middle,
                   last;

            name = txtBxFullname.Text.Split(' ');
            if (name.Length < 2)
            {
                txtBxFullname.Text = "Please enter full name!";
                txtBxFullname.Focus();
            }
            else
            {
                btnReset.Visible = true;
                btnRetrieve.Visible = false;
                lblLast.Visible = true;
                lblLastLbl.Visible = true;
                lblFirst.Visible = true;
                lblFirstLbl.Visible = true;
                if (name.Length == 2)
                {
                    lblFirst.Text = name[0];
                    lblLast.Text = name[1];
                    lblMiddle.Visible = false;
                    lblMiddleLbl.Visible = false;
                }
                else
                {
                    lblFirst.Text = name[0];
                    lblMiddle.Text = name[1];
                    lblLast.Text = name[2];
                    lblMiddle.Visible = true;
                    lblMiddleLbl.Visible = true;
                }
            }

         }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblFirst.Visible = false;
            lblFirstLbl.Visible = false;
            lblMiddle.Visible = false;
            lblMiddleLbl.Visible = false;
            lblLast.Visible = false;
            lblLastLbl.Visible = false;
            txtBxFullname.Text = "";
            txtBxFullname.Focus();
            btnReset.Visible = false;
            btnRetrieve.Visible = true;
        }
    }
}
