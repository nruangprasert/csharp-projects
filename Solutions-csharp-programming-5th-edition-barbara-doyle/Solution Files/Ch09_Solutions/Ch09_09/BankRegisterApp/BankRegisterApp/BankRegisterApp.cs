/* BankRegisterApp.cs
 * This application enables a user to
 * create a new banking account. It asks the
 * user for name and original deposit amount.
 * Account number is assigned. Once the
 * account is set up, the user can
 * either withdraw or deposit money into 
 * the account. 
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

namespace BankRegisterApp
{
    public partial class BankRegisterForm : Form
    {
        private Customer aCustomer;
        private long accountNumber;
        public BankRegisterForm()
        {
            InitializeComponent();
        }

        private void BankRegisterForm_Load(object sender, EventArgs e)
        {
            aCustomer = new Customer( );
            accountNumber = 1000001;
            txtBxName.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            decimal balance;
            string[] name = new string[3];
            name = txtBxName.Text.Split(' ');
            if (name.Length < 2)
            {
                txtBxName.Text = "Enter Full Name!";
                txtBxName.Focus();
            }
            else
            {
                aCustomer.FirstName = name[0];
                if (name.Length == 3)
                {
                    aCustomer.LastName = name[2];
                }
                else
                {
                    aCustomer.LastName = name[1];
                }

                while (decimal.TryParse(txtBxBalance.Text, out balance) == false)
                {
                    lblErrorMsg.Visible = true;
                    txtBxBalance.Text = "0";
                    txtBxBalance.Focus();
                }

                if (balance > 0)
                {
                    aCustomer.AccountBalance = balance;
                    aCustomer.AccountNumber = accountNumber;
                    lblAccountNo.Visible = true;
                    txtBxAccountNo.Visible = true;
                    btnCreate.Visible = false;
                    btnUpdate.Visible = true;
                    lblDeposit.Visible = true;
                    lblWithdrawal.Visible = true;
                    txtBxDeposit.Visible = true;
                    txtBxWithdraw.Visible = true;
                    txtBxName.Text = aCustomer.FirstName
                            + " " + aCustomer.LastName;
                    txtBxAccountNo.Text = aCustomer.AccountNumber.ToString();
                    txtBxBalance.Text = aCustomer.AccountBalance.ToString("C");
                    txtBxName.Enabled = false;
                    txtBxAccountNo.Enabled = false;
                    txtBxBalance.Enabled = false;
                    txtBxDeposit.Focus();
                    AcceptButton = btnUpdate;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal amount = 0m;

            if (txtBxDeposit.Text != "")
            {
                while (decimal.TryParse(txtBxDeposit.Text, out amount) == false)
                {
                    lblErrorMsg.Visible = true;
                    txtBxDeposit.Text = "0";
                    txtBxDeposit.Focus();
                }
                aCustomer.AccountBalance += amount;
                txtBxDeposit.Text = aCustomer.AccountBalance.ToString("C");
                txtBxDeposit.Clear();
            }

            if (txtBxWithdraw.Text != "")
            {
                while (decimal.TryParse(txtBxWithdraw.Text, out amount) == false)
                {
                    lblErrorMsg.Visible = true;
                    txtBxWithdraw.Text = "0";
                    txtBxWithdraw.Focus();
                }
                aCustomer.AccountBalance -= amount;
                if (aCustomer.AccountBalance < 0)
                {
                    lblErrorMsg.Text = "Account overdrawn - no more withdrawals possible";
                    txtBxWithdraw.Enabled = false;
                }

            }
            txtBxDeposit.Clear();
            txtBxWithdraw.Clear();
            txtBxDeposit.Focus();
            txtBxBalance.Text = aCustomer.AccountBalance.ToString("C");
            if (aCustomer.AccountBalance < 0)
            {
                lblErrorMsg.Text = "Account overdrawn - no more withdrawals possible";
                txtBxWithdraw.Enabled = false;
                lblErrorMsg.Visible = true;
            }
            else
            {
                lblErrorMsg.Visible = false;
                txtBxWithdraw.Enabled = true;
            }
        }
    }
}
