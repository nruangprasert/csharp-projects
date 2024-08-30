namespace EmployeePayApp
{
    partial class FrmEmployeePayApp
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblLEmpNo = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtBxFirst = new System.Windows.Forms.TextBox();
            this.txtBxLast = new System.Windows.Forms.TextBox();
            this.txtBxEmpNo = new System.Windows.Forms.TextBox();
            this.txtBxRate = new System.Windows.Forms.TextBox();
            this.txtBxHours = new System.Windows.Forms.TextBox();
            this.lstBxResults = new System.Windows.Forms.ListBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(17, 16);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(96, 18);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(17, 53);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(94, 18);
            this.lblLast.TabIndex = 1;
            this.lblLast.Text = "Last Name:";
            // 
            // lblLEmpNo
            // 
            this.lblLEmpNo.AutoSize = true;
            this.lblLEmpNo.Location = new System.Drawing.Point(17, 90);
            this.lblLEmpNo.Name = "lblLEmpNo";
            this.lblLEmpNo.Size = new System.Drawing.Size(151, 18);
            this.lblLEmpNo.TabIndex = 2;
            this.lblLEmpNo.Text = "Employee Number:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(17, 127);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(76, 18);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Pay Rate";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(17, 164);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(59, 18);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Hours:";
            // 
            // txtBxFirst
            // 
            this.txtBxFirst.Location = new System.Drawing.Point(119, 13);
            this.txtBxFirst.Name = "txtBxFirst";
            this.txtBxFirst.Size = new System.Drawing.Size(301, 24);
            this.txtBxFirst.TabIndex = 5;
            // 
            // txtBxLast
            // 
            this.txtBxLast.Location = new System.Drawing.Point(119, 51);
            this.txtBxLast.Name = "txtBxLast";
            this.txtBxLast.Size = new System.Drawing.Size(301, 24);
            this.txtBxLast.TabIndex = 6;
            // 
            // txtBxEmpNo
            // 
            this.txtBxEmpNo.Location = new System.Drawing.Point(174, 89);
            this.txtBxEmpNo.Name = "txtBxEmpNo";
            this.txtBxEmpNo.Size = new System.Drawing.Size(171, 24);
            this.txtBxEmpNo.TabIndex = 7;
            // 
            // txtBxRate
            // 
            this.txtBxRate.Location = new System.Drawing.Point(101, 127);
            this.txtBxRate.Name = "txtBxRate";
            this.txtBxRate.Size = new System.Drawing.Size(88, 24);
            this.txtBxRate.TabIndex = 8;
            // 
            // txtBxHours
            // 
            this.txtBxHours.Location = new System.Drawing.Point(82, 165);
            this.txtBxHours.Name = "txtBxHours";
            this.txtBxHours.Size = new System.Drawing.Size(86, 24);
            this.txtBxHours.TabIndex = 9;
            // 
            // lstBxResults
            // 
            this.lstBxResults.FormattingEnabled = true;
            this.lstBxResults.ItemHeight = 18;
            this.lstBxResults.Location = new System.Drawing.Point(226, 145);
            this.lstBxResults.Name = "lstBxResults";
            this.lstBxResults.Size = new System.Drawing.Size(235, 184);
            this.lstBxResults.TabIndex = 10;
            this.lstBxResults.Visible = false;
            // 
            // btnStore
            // 
            this.btnStore.ForeColor = System.Drawing.Color.Black;
            this.btnStore.Location = new System.Drawing.Point(20, 212);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(158, 51);
            this.btnStore.TabIndex = 11;
            this.btnStore.Text = "Store Record";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.ForeColor = System.Drawing.Color.Black;
            this.btnRetrieve.Location = new System.Drawing.Point(20, 278);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(158, 51);
            this.btnRetrieve.TabIndex = 12;
            this.btnRetrieve.Text = "Retrieve Records";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Visible = false;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMessage.Location = new System.Drawing.Point(13, 348);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmEmployeePayApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(485, 387);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.lstBxResults);
            this.Controls.Add(this.txtBxHours);
            this.Controls.Add(this.txtBxRate);
            this.Controls.Add(this.txtBxEmpNo);
            this.Controls.Add(this.txtBxLast);
            this.Controls.Add(this.txtBxFirst);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblLEmpNo);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmployeePayApp";
            this.Text = "Employee Pay App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblLEmpNo;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtBxFirst;
        private System.Windows.Forms.TextBox txtBxLast;
        private System.Windows.Forms.TextBox txtBxEmpNo;
        private System.Windows.Forms.TextBox txtBxRate;
        private System.Windows.Forms.TextBox txtBxHours;
        private System.Windows.Forms.ListBox lstBxResults;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

