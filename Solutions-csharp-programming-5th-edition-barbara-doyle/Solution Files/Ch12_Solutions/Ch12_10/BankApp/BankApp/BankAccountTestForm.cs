/* BankAccountTest.cs
 * Program to test the BankAccount class.
 * Allows the user to create an account, and add or remove money from it
 */
using System;
using System.Windows.Forms;

namespace BankApp
{
    public partial class BankAccountTestForm : Form
    {
        private BankAccount newAccount;

        public BankAccountTestForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(txtBxAmount.Text) < 0)
                {
                    throw new NegativeException("Cannot open an account with a negative value");
                }
                newAccount = new BankAccount(txtBxName.Text, decimal.Parse(txtBxAmount.Text));
                lbCurrentBudgetAmount.Text = newAccount.Balance.ToString("C");
                lbCurrentBudgetAmount.Visible = true;
                lblCurrentBudget.Visible = true;
                this.txtBxAmount.Text = string.Empty;
                txtBxName.ReadOnly = true;
                txtBxAmount.Focus();
                this.btnAdd.Visible = true;
                this.btnDeduct.Visible = true;
                this.btnCreate.Visible = false;

            }

            catch (NegativeException c)
            {
                txtBxAmount.Text = "";
                txtBxAmount.Focus();
                MessageBox.Show(c.Message, "Error");
            }

            catch (FormatException c)
            {
                txtBxAmount.Text = "";
                txtBxAmount.Focus();
                MessageBox.Show(c.Message, "Error");
            }

            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(txtBxAmount.Text) < 0)
                {
                    throw new NegativeException("Cannot deposit a negative value");
                }
                newAccount.IncreaseBalance(decimal.Parse(txtBxAmount.Text));
                lbCurrentBudgetAmount.Text = newAccount.Balance.ToString("C");
                this.txtBxAmount.Text = string.Empty;
                txtBxAmount.Focus();
            }

            catch (NegativeException c)
            {
                txtBxAmount.Text = "";
                txtBxAmount.Focus();
                MessageBox.Show(c.Message, "Error");
            }

            catch (FormatException c)
            {
                txtBxAmount.Text = "";
                txtBxAmount.Focus();
                MessageBox.Show(c.Message, "Error");
            }

            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Error");
            }
        }

        private void btnDeduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(txtBxAmount.Text) < 0)
                {
                    throw new NegativeException("Cannot withdraw a negative value");
                }
                newAccount.DecreaseBalance(decimal.Parse(txtBxAmount.Text));
                lbCurrentBudgetAmount.Text = newAccount.Balance.ToString("c");
                this.txtBxAmount.Clear();
                txtBxAmount.Focus();

            }

            catch (NegativeException c)
            {
                txtBxAmount.Text = "";
                txtBxAmount.Focus();
                MessageBox.Show(c.Message, "Error");
            }

            catch (FormatException c)
            {
                txtBxAmount.Text = "";
                txtBxAmount.Focus();
                MessageBox.Show(c.Message, "Error");
            }

            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Error");
            }
        }

        private void BankAccountTestForm_Load(object sender, EventArgs e)
        {
            this.btnAdd.Visible = false;
            this.btnDeduct.Visible = false;
        }


    }
}
