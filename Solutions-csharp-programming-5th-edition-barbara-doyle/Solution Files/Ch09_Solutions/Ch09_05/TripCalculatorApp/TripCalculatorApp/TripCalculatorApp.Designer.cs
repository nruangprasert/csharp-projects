namespace TripCalculatorApp
{
    partial class TripCalculatorApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBxDestination = new System.Windows.Forms.TextBox();
			this.txtBxMiles = new System.Windows.Forms.TextBox();
			this.txtBxGallons = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(91, 44);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(278, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Miles Per Gallon Calculator";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Destination:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Miles Traveled:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Gallons Consumed:";
			// 
			// txtBxDestination
			// 
			this.txtBxDestination.Location = new System.Drawing.Point(129, 105);
			this.txtBxDestination.Name = "txtBxDestination";
			this.txtBxDestination.Size = new System.Drawing.Size(197, 29);
			this.txtBxDestination.TabIndex = 0;
			// 
			// txtBxMiles
			// 
			this.txtBxMiles.Location = new System.Drawing.Point(147, 160);
			this.txtBxMiles.Name = "txtBxMiles";
			this.txtBxMiles.Size = new System.Drawing.Size(52, 29);
			this.txtBxMiles.TabIndex = 1;
			this.txtBxMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtBxGallons
			// 
			this.txtBxGallons.Location = new System.Drawing.Point(174, 213);
			this.txtBxGallons.Name = "txtBxGallons";
			this.txtBxGallons.Size = new System.Drawing.Size(67, 29);
			this.txtBxGallons.TabIndex = 2;
			this.txtBxGallons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Location = new System.Drawing.Point(127, 367);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(0, 23);
			this.lblOutput.TabIndex = 7;
			// 
			// btnCalculate
			// 
			this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalculate.Location = new System.Drawing.Point(54, 271);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(145, 48);
			this.btnCalculate.TabIndex = 3;
			this.btnCalculate.Text = "Calculate MPG";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnReset
			// 
			this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(249, 276);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(84, 38);
			this.btnReset.TabIndex = 9;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// TripCalculatorApp
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.CancelButton = this.btnReset;
			this.ClientSize = new System.Drawing.Size(433, 461);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.txtBxGallons);
			this.Controls.Add(this.txtBxMiles);
			this.Controls.Add(this.txtBxDestination);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Location = new System.Drawing.Point(30, 30);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "TripCalculatorApp";
			this.Text = "Trip Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxDestination;
        private System.Windows.Forms.TextBox txtBxMiles;
        private System.Windows.Forms.TextBox txtBxGallons;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
    }
}

