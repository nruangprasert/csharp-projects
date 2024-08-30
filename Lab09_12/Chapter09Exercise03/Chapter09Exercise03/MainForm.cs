using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chapter09Exercise03
{
    public partial class MainForm : Form
    {
        private Label lblFirstNumber;
        private Label lblSecondNumber;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private Button btnAdd;
        private Button btnMultiply;
        private Button btnReset;
        private Label lblResult;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MainForm";
            this.Text = "Math Operations";
            this.ResumeLayout(false);

        }

        private void InitializeCustomComponents()
        {
            lblFirstNumber = new Label
            {
                Text = "First Number:",
                Location = new Point(20, 20),
                AutoSize = true
            };

            txtFirstNumber = new TextBox
            {
                Location = new Point(120, 20),
                Width = 100,
                TextAlign = HorizontalAlignment.Right
            };

            lblSecondNumber = new Label
            {
                Text = "Second Number:",
                Location = new Point(20, 50),
                AutoSize = true
            };

            txtSecondNumber = new TextBox
            {
                Location = new Point(120, 50),
                Width = 100,
                TextAlign = HorizontalAlignment.Right
            };

            btnAdd = new Button
            {
                Text = "Add",
                Location = new Point(20, 80),
                AutoSize = true
            };
            btnAdd.Click += BtnAdd_Click;

            btnMultiply = new Button
            {
                Text = "Multiply",
                Location = new Point(100, 80),
                AutoSize = true
            };
            btnMultiply.Click += BtnMultiply_Click;

            btnReset = new Button
            {
                Text = "Reset",
                Location = new Point(180, 80),
                AutoSize = true
            };
            btnReset.Click += BtnReset_Click;

            lblResult = new Label
            {
                ForeColor = Color.Yellow,
                Location = new Point(20, 110),
                AutoSize = true,
                Visible = false
            };

            this.Controls.Add(lblFirstNumber);
            this.Controls.Add(txtFirstNumber);
            this.Controls.Add(lblSecondNumber);
            this.Controls.Add(txtSecondNumber);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnMultiply);
            this.Controls.Add(btnReset);
            this.Controls.Add(lblResult);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.Visible = false;
            PerformOperation((a, b) => a + b);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.Visible = false;
            PerformOperation((a, b) => a * b);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            lblResult.Visible = false;
        }

        private void PerformOperation(Func<double, double, double> operation)
        {
            if (double.TryParse(txtFirstNumber.Text, out double firstNumber) &&
                double.TryParse(txtSecondNumber.Text, out double secondNumber) &&
                firstNumber > 0 && secondNumber > 0)
            {
                double result = operation(firstNumber, secondNumber);
                lblResult.Text = $"Result: {result}";
                lblResult.ForeColor = Color.Yellow;
                lblResult.Visible = true;
            }
            else
            {
                lblResult.Text = "Value must be numeric and > 0.";
                lblResult.ForeColor = Color.Red;
                lblResult.Visible = true;
            }
        }
    }
}