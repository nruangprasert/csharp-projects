namespace DistanceCalculatorApp
{
    partial class DistanceCalculatorForm
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
			this.btnSubmit = new System.Windows.Forms.Button();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.txtBxSpeed = new System.Windows.Forms.TextBox();
			this.txtBxTime = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(119, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(305, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "How far did you travel?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Speed (MPH):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(51, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Time Traveled (Hrs):";
			// 
			// btnSubmit
			// 
			this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnSubmit.Location = new System.Drawing.Point(201, 263);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(118, 37);
			this.btnSubmit.TabIndex = 2;
			this.btnSubmit.Text = "Calculate";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblAnswer.Location = new System.Drawing.Point(51, 393);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(0, 23);
			this.lblAnswer.TabIndex = 4;
			// 
			// txtBxSpeed
			// 
			this.txtBxSpeed.Location = new System.Drawing.Point(219, 115);
			this.txtBxSpeed.Name = "txtBxSpeed";
			this.txtBxSpeed.Size = new System.Drawing.Size(100, 37);
			this.txtBxSpeed.TabIndex = 0;
			this.txtBxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtBxTime
			// 
			this.txtBxTime.Location = new System.Drawing.Point(257, 184);
			this.txtBxTime.Name = "txtBxTime";
			this.txtBxTime.Size = new System.Drawing.Size(100, 37);
			this.txtBxTime.TabIndex = 1;
			this.txtBxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnReset
			// 
			this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnReset.Location = new System.Drawing.Point(201, 318);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(118, 37);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Visible = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// DistanceCalculatorForm
			// 
			this.AcceptButton = this.btnSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(521, 464);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.txtBxTime);
			this.Controls.Add(this.txtBxSpeed);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "DistanceCalculatorForm";
			this.Text = "Distance Calculator App";
			this.Load += new System.EventHandler(this.DistanceCalculatorForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtBxSpeed;
        private System.Windows.Forms.TextBox txtBxTime;
		private System.Windows.Forms.Button btnReset;
	}
}

