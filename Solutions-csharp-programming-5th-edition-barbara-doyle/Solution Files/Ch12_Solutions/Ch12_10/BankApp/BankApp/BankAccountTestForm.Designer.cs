namespace BankApp
{
    partial class BankAccountTestForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxAmount = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeduct = new System.Windows.Forms.Button();
            this.lblCurrentBudget = new System.Windows.Forms.Label();
            this.lbCurrentBudgetAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 44);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(33, 96);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 18);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Amount:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(83, 41);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(287, 24);
            this.txtBxName.TabIndex = 2;
            // 
            // txtBxAmount
            // 
            this.txtBxAmount.Location = new System.Drawing.Point(93, 93);
            this.txtBxAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxAmount.Name = "txtBxAmount";
            this.txtBxAmount.Size = new System.Drawing.Size(128, 24);
            this.txtBxAmount.TabIndex = 3;
            this.txtBxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(93, 258);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 54);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 195);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Deposit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeduct
            // 
            this.btnDeduct.Location = new System.Drawing.Point(192, 195);
            this.btnDeduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeduct.Name = "btnDeduct";
            this.btnDeduct.Size = new System.Drawing.Size(121, 32);
            this.btnDeduct.TabIndex = 6;
            this.btnDeduct.Text = "Withdrawal";
            this.btnDeduct.UseVisualStyleBackColor = true;
            this.btnDeduct.Click += new System.EventHandler(this.btnDeduct_Click);
            // 
            // lblCurrentBudget
            // 
            this.lblCurrentBudget.AutoSize = true;
            this.lblCurrentBudget.Location = new System.Drawing.Point(33, 144);
            this.lblCurrentBudget.Name = "lblCurrentBudget";
            this.lblCurrentBudget.Size = new System.Drawing.Size(118, 18);
            this.lblCurrentBudget.TabIndex = 7;
            this.lblCurrentBudget.Text = "Current Balance:";
            this.lblCurrentBudget.Visible = false;
            // 
            // lbCurrentBudgetAmount
            // 
            this.lbCurrentBudgetAmount.AutoSize = true;
            this.lbCurrentBudgetAmount.Location = new System.Drawing.Point(157, 144);
            this.lbCurrentBudgetAmount.Name = "lbCurrentBudgetAmount";
            this.lbCurrentBudgetAmount.Size = new System.Drawing.Size(0, 18);
            this.lbCurrentBudgetAmount.TabIndex = 8;
            this.lbCurrentBudgetAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbCurrentBudgetAmount.Visible = false;
            // 
            // BankAccountTestForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(532, 385);
            this.Controls.Add(this.lbCurrentBudgetAmount);
            this.Controls.Add(this.lblCurrentBudget);
            this.Controls.Add(this.btnDeduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBxAmount);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BankAccountTestForm";
            this.Text = "Bank Account Test";
            this.Load += new System.EventHandler(this.BankAccountTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxAmount;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeduct;
        private System.Windows.Forms.Label lblCurrentBudget;
        private System.Windows.Forms.Label lbCurrentBudgetAmount;
    }
}

