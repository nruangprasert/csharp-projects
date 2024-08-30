using System;
using System.Drawing;
using System.Windows.Forms;

namespace TripCalculatorApp
{
    public partial class TripCalculatorForm : Form
    {
        private Label lblDestination;
        private TextBox txtDestination;
        private Label lblMilesTraveled;
        private TextBox txtMilesTraveled;
        private Label lblGallonsConsumed;
        private TextBox txtGallonsConsumed;
        private Button btnCalculate;
        private Button btnReset;
        private Label lblResult;

        public TripCalculatorForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeComponent()
        {
            this.Name = "TripCalculatorForm";
            this.ForeColor = Color.Black;
            this.BackColor = Color.LightGray;
            this.Size = new Size(300, 250);
            this.Location = new Point(100, 100);
            this.Text = "Trip Calculator";
            this.AcceptButton = btnCalculate;
            this.ResumeLayout(false);
        }

        private void InitializeCustomComponents()
        {
            lblDestination = new Label
            {
                Text = "Destination:",
                Location = new Point(20, 20),
                AutoSize = true
            };

            txtDestination = new TextBox
            {
                Location = new Point(120, 20),
                Width = 150,
                TextAlign = HorizontalAlignment.Left
            };

            lblMilesTraveled = new Label
            {
                Text = "Miles Traveled:",
                Location = new Point(20, 50),
                AutoSize = true
            };

            txtMilesTraveled = new TextBox
            {
                Location = new Point(120, 50),
                Width = 100,
                TextAlign = HorizontalAlignment.Right
            };

            lblGallonsConsumed = new Label
            {
                Text = "Gallons Consumed:",
                Location = new Point(20, 80),
                AutoSize = true
            };

            txtGallonsConsumed = new TextBox
            {
                Location = new Point(120, 80),
                Width = 100,
                TextAlign = HorizontalAlignment.Right
            };

            btnCalculate = new Button
            {
                Text = "Calculate",
                Location = new Point(50, 120),
                AutoSize = true
            };
            btnCalculate.Click += BtnCalculate_Click;

            btnReset = new Button
            {
                Text = "Reset",
                Location = new Point(150, 120),
                AutoSize = true
            };
            btnReset.Click += BtnReset_Click;

            lblResult = new Label
            {
                Location = new Point(20, 150),
                AutoSize = true
            };

            this.Controls.Add(lblDestination);
            this.Controls.Add(txtDestination);
            this.Controls.Add(lblMilesTraveled);
            this.Controls.Add(txtMilesTraveled);
            this.Controls.Add(lblGallonsConsumed);
            this.Controls.Add(txtGallonsConsumed);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(btnReset);
            this.Controls.Add(lblResult);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMilesTraveled.Text, out double miles) &&
                double.TryParse(txtGallonsConsumed.Text, out double gallons) &&
                gallons > 0)
            {
                double mpg = miles / gallons;
                lblResult.Text = $"Miles per gallon: {mpg}";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "Please enter valid numeric values.";
                lblResult.ForeColor = Color.Red;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtDestination.Clear();
            txtMilesTraveled.Clear();
            txtGallonsConsumed.Clear();
            lblResult.Text = string.Empty;
        }

    }
}
