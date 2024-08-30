namespace BankRegisterApp
{
    partial class BankRegisterForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxAccountNo = new System.Windows.Forms.TextBox();
            this.txtBxBalance = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtBxDeposit = new System.Windows.Forms.TextBox();
            this.lblWithdrawal = new System.Windows.Forms.Label();
            this.txtBxWithdraw = new System.Windows.Forms.TextBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.ForeColor = System.Drawing.Color.Navy;
            this.btnCreate.Location = new System.Drawing.Point(13, 385);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(127, 65);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdate.Location = new System.Drawing.Point(336, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 67);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Account";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banking Register";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(115, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name: ";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(115, 167);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(100, 23);
            this.lblAccountNo.TabIndex = 4;
            this.lblAccountNo.Text = "Account No:";
            this.lblAccountNo.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(115, 216);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(136, 23);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Original Deposit:\r\n";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(175, 120);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(176, 30);
            this.txtBxName.TabIndex = 0;
            // 
            // txtBxAccountNo
            // 
            this.txtBxAccountNo.Location = new System.Drawing.Point(221, 169);
            this.txtBxAccountNo.Name = "txtBxAccountNo";
            this.txtBxAccountNo.Size = new System.Drawing.Size(130, 30);
            this.txtBxAccountNo.TabIndex = 1;
            this.txtBxAccountNo.Visible = false;
            // 
            // txtBxBalance
            // 
            this.txtBxBalance.Location = new System.Drawing.Point(251, 218);
            this.txtBxBalance.Name = "txtBxBalance";
            this.txtBxBalance.Size = new System.Drawing.Size(100, 30);
            this.txtBxBalance.TabIndex = 2;
            this.txtBxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(117, 289);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(66, 23);
            this.lblDeposit.TabIndex = 9;
            this.lblDeposit.Text = "Deposit";
            this.lblDeposit.Visible = false;
            // 
            // txtBxDeposit
            // 
            this.txtBxDeposit.Location = new System.Drawing.Point(110, 316);
            this.txtBxDeposit.Name = "txtBxDeposit";
            this.txtBxDeposit.Size = new System.Drawing.Size(100, 30);
            this.txtBxDeposit.TabIndex = 4;
            this.txtBxDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxDeposit.Visible = false;
            // 
            // lblWithdrawal
            // 
            this.lblWithdrawal.AutoSize = true;
            this.lblWithdrawal.Location = new System.Drawing.Point(272, 293);
            this.lblWithdrawal.Name = "lblWithdrawal";
            this.lblWithdrawal.Size = new System.Drawing.Size(83, 23);
            this.lblWithdrawal.TabIndex = 11;
            this.lblWithdrawal.Text = "Withdraw";
            this.lblWithdrawal.Visible = false;
            // 
            // txtBxWithdraw
            // 
            this.txtBxWithdraw.Location = new System.Drawing.Point(263, 316);
            this.txtBxWithdraw.Name = "txtBxWithdraw";
            this.txtBxWithdraw.Size = new System.Drawing.Size(100, 30);
            this.txtBxWithdraw.TabIndex = 6;
            this.txtBxWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxWithdraw.Visible = false;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(49, 258);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(288, 23);
            this.lblErrorMsg.TabIndex = 13;
            this.lblErrorMsg.Text = "Data must be a positive numeric value!";
            this.lblErrorMsg.Visible = false;
            // 
            // BankRegisterForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(473, 464);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.txtBxWithdraw);
            this.Controls.Add(this.lblWithdrawal);
            this.Controls.Add(this.txtBxDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtBxBalance);
            this.Controls.Add(this.txtBxAccountNo);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BankRegisterForm";
            this.Text = "Bank Register";
            this.Load += new System.EventHandler(this.BankRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxAccountNo;
        private System.Windows.Forms.TextBox txtBxBalance;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtBxDeposit;
        private System.Windows.Forms.Label lblWithdrawal;
        private System.Windows.Forms.TextBox txtBxWithdraw;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}

