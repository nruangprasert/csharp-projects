/*EmployeeData.cs
 * Takes an Employee name, number, pay rate, and hours worked
 * and figures out total pay (with overtime calculations) then stores 
 * Employee number and total pay in a text file
 * Then retrieves the data from a text file and displays it
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
using System.IO;

namespace EmployeePayApp
{
    public partial class FrmEmployeePayApp : Form
    {
        private bool firstRecord = true;

        public FrmEmployeePayApp()
        {
            InitializeComponent();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            string employeeLastName,
                    employeeFirstName,
                    employeeNum;
            double rate,
                    hours,
                    pay;
            try
            {

                if (firstRecord)
                {
                    saveFileDialog1.ShowDialog();
                    File.Delete(saveFileDialog1.FileName);
                    firstRecord = false;
                }
                using (StreamWriter storeInfo = new StreamWriter(saveFileDialog1.FileName, true)) // true appends data onto file
                {
                    employeeNum = txtBxEmpNo.Text;
                    employeeLastName = txtBxLast.Text;
                    employeeFirstName = txtBxFirst.Text;
                    rate = double.Parse(txtBxRate.Text);
                    hours = double.Parse(txtBxHours.Text);

                    if (hours > 40)
                    {
                        pay = 40 * rate + (hours - 40) * 1.5 * rate;
                    }
                    else
                        pay = hours * rate;

                    storeInfo.WriteLine(employeeLastName + ", " +
                        employeeFirstName +                        
                        "|" + employeeNum + "|" + pay.ToString());
                    this.btnRetrieve.Visible = true;
                    txtBxEmpNo.Text = string.Empty;
                    txtBxLast.Text = string.Empty;
                    txtBxFirst.Text = string.Empty;
                    txtBxRate.Text = string.Empty;
                    txtBxHours.Text = string.Empty;
                    txtBxFirst.Focus();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Problem...\n" + exc.Message);
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string info;
            string [ ] recordData = new string [3];
            string empName = string.Empty;
            string empNum = string.Empty;
            string totalPay = string.Empty;
            string outInfo  = string.Empty;;
          
            try
            {
                openFileDialog1.ShowDialog();
                using (StreamReader getInfo = new StreamReader(openFileDialog1.FileName))
                {
                    lstBxResults.Items.Clear();
                    DisableOtherControls();
                    while ((info = getInfo.ReadLine()) != null)
                    {
                        recordData = info.Split('|');
                        outInfo = recordData[0] + "     " +
                            String.Format("{0:c}", double.Parse(recordData[2]));
                        lstBxResults.Items.Add(outInfo);
                        lstBxResults.Visible = true;
                   }
                }
            }
            catch (Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        public void DisableOtherControls()
        {
            txtBxFirst.Enabled = false;
            txtBxLast.Enabled = false;
            txtBxRate.Enabled = false;
            txtBxHours.Enabled = false;
            txtBxEmpNo.Enabled = false;
            btnStore.Visible = false;
        }
    }
}
