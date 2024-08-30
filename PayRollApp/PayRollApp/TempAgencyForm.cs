/* TempAgencyForm.cs
 * This partial class contains program
 * statements written to handle the two
 * button click events.
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace PayRollApp
{
    public partial class TempAgencyForm : Form
    {
        public TempAgencyForm()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            int dep;
            int hours;
            string[] name = new string[2];
            if(int.TryParse(txtBxHours.Text, out hours)==false) 
            {
                MessageBox.Show("numeric value should be entered for hours");
                txtBxHours.Text = "0";
                txtBxHours.Focus();
            }
            if(int.TryParse(txtBxDep.Text, out dep) == false) 
            {
                MessageBox.Show("wrong input, 0 will be saved for num of dep");
                txtBxDep.Text = "0";
                txtBxDep.Focus();
            }
            name = txtBxName.Text.Split(' ');
            if(name.Length < 2 ) 
            {
                txtBxName.Text = "please enter full name";
                txtBxName.Focus();
            }
            else 
            {
                if(hours > 0) 
                {
                    Employee employee = new Employee(name[0], name[1], dep, hours);
                    txtBxGross.Text = employee.DetermineGross().ToString("C2");
                    txtBxAgency.Text = employee.DetermineAgencyFee().ToString("C2");
                    txtBxSoc.Text = employee.DetermineSocSec().ToString("C2");
                    txtBxFed.Text = employee.DetermineFedTax().ToString("C2");
                    txtBxNet.Text = employee.DetermineNet().ToString("C2");

                    
                    string coverage = string.Empty;
                    string status = string.Empty; 
                    if (chkBasicCoverage.Checked == true)
                    {
                        coverage = "Basic Coverage";
                    }

                    if (chkExtendedCoverage.Checked)
                    {
                        coverage = "Extended Coverage";
                    }
                    if (radioButton1.Checked == true) 
                    {
                        status = "Full Time";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        status = "Part Time";
                    }
                    if (radioButton3.Checked == true)
                    {
                        status = "Contract";
                    }



                    txtBxGross.Visible = true;
                    txtBxAgency.Visible = true;
                    txtBxSoc.Visible = true;
                    txtBxFed.Visible = true;
                    txtBxNet.Visible = true;
                    lblGross.Visible = true;
                    lblAgency.Visible = true;
                    lblSoc.Visible = true;
                    lblFed.Visible = true;
                    lblNet.Visible = true;

                    txtBxName.Enabled = false;
                    txtBxDep.Visible = false;
                    txtBxHours.Visible = false;
                    lblHours.Visible = false;
                    lblDep.Visible = false;

                    StreamWriter writer = new StreamWriter("employees.txt");
                    writer.Write(txtBxName.Text + "\t");
                    writer.Write(txtBxHours.Text + "\t");
                    writer.Write(txtBxDep.Text + "\t");
                    writer.Write(txtBxGross.Text + "\t");
                    writer.Write(txtBxAgency.Text + "\t");
                    writer.Write(txtBxSoc.Text + "\t");
                    writer.Write(txtBxFed.Text + "\t");
                    writer.Close();

                    txtBxNet.Text = employee.ToString() + " " + listDept.SelectedItems[0] + " " + coverage + " " + status;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxGross.Visible = false;
            txtBxAgency.Visible = false;
            txtBxSoc.Visible = false;
            txtBxFed.Visible = false;
            txtBxNet.Visible = false;
            lblGross.Visible = false;
            lblAgency.Visible = false;
            lblSoc.Visible = false;
            lblFed.Visible = false;
            lblNet.Visible = false;

            txtBxName.Enabled = true;
            txtBxDep.Visible = true;
            txtBxHours.Visible = true;
            lblHours.Visible = true;
            lblDep.Visible = true;

            txtBxName.Text = string.Empty;
            txtBxDep.Text = string.Empty;
            txtBxHours.Text = string.Empty;
            lblHours.Text = string.Empty;
            lblDep.Text = string.Empty;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TempAgencyForm_Load(object sender, EventArgs e)
        {
            try 
            {
                StreamReader reader = new StreamReader("DepList.txt");
                string line;
                while ((line = reader.ReadLine()) != null)
                { 
                    listDept.Items.Add(line);
                }
                reader.Close();
            }
            catch (IOException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBxNet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
