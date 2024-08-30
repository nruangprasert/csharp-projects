namespace BinaryNumbersApp
{
    partial class FrmBinaryNumbersApp
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
            this.lblNumbers = new System.Windows.Forms.Label();
            this.txtBxValue1 = new System.Windows.Forms.TextBox();
            this.txtBxValue2 = new System.Windows.Forms.TextBox();
            this.txtBxValue3 = new System.Windows.Forms.TextBox();
            this.txtBxValue4 = new System.Windows.Forms.TextBox();
            this.txtBxValue5 = new System.Windows.Forms.TextBox();
            this.lstBxNumbers = new System.Windows.Forms.ListBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblForListBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(139, 19);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(73, 20);
            this.lblNumbers.TabIndex = 0;
            this.lblNumbers.Text = "Numbers";
            // 
            // txtBxValue1
            // 
            this.txtBxValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxValue1.Location = new System.Drawing.Point(34, 52);
            this.txtBxValue1.Name = "txtBxValue1";
            this.txtBxValue1.Size = new System.Drawing.Size(49, 26);
            this.txtBxValue1.TabIndex = 1;
            this.txtBxValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxValue2
            // 
            this.txtBxValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxValue2.Location = new System.Drawing.Point(98, 52);
            this.txtBxValue2.Name = "txtBxValue2";
            this.txtBxValue2.Size = new System.Drawing.Size(49, 26);
            this.txtBxValue2.TabIndex = 2;
            this.txtBxValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxValue3
            // 
            this.txtBxValue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxValue3.Location = new System.Drawing.Point(165, 52);
            this.txtBxValue3.Name = "txtBxValue3";
            this.txtBxValue3.Size = new System.Drawing.Size(49, 26);
            this.txtBxValue3.TabIndex = 3;
            this.txtBxValue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxValue4
            // 
            this.txtBxValue4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxValue4.Location = new System.Drawing.Point(230, 52);
            this.txtBxValue4.Name = "txtBxValue4";
            this.txtBxValue4.Size = new System.Drawing.Size(49, 26);
            this.txtBxValue4.TabIndex = 4;
            this.txtBxValue4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxValue5
            // 
            this.txtBxValue5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxValue5.Location = new System.Drawing.Point(296, 52);
            this.txtBxValue5.Name = "txtBxValue5";
            this.txtBxValue5.Size = new System.Drawing.Size(49, 26);
            this.txtBxValue5.TabIndex = 5;
            this.txtBxValue5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstBxNumbers
            // 
            this.lstBxNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxNumbers.FormattingEnabled = true;
            this.lstBxNumbers.Location = new System.Drawing.Point(12, 202);
            this.lstBxNumbers.Name = "lstBxNumbers";
            this.lstBxNumbers.Size = new System.Drawing.Size(355, 108);
            this.lstBxNumbers.TabIndex = 6;
            this.lstBxNumbers.Visible = false;
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Location = new System.Drawing.Point(34, 106);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(126, 62);
            this.btnStore.TabIndex = 7;
            this.btnStore.Text = "Store Values";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.Location = new System.Drawing.Point(219, 106);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(126, 62);
            this.btnRetrieve.TabIndex = 8;
            this.btnRetrieve.Text = "Retrieve Values";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            this.btnRetrieve.Visible = false;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblForListBox
            // 
            this.lblForListBox.AutoSize = true;
            this.lblForListBox.Location = new System.Drawing.Point(92, 182);
            this.lblForListBox.Name = "lblForListBox";
            this.lblForListBox.Size = new System.Drawing.Size(187, 17);
            this.lblForListBox.TabIndex = 9;
            this.lblForListBox.Text = "Current Values in Binary File";
            this.lblForListBox.Visible = false;
            // 
            // FrmBinaryNumbersApp
            // 
            this.AcceptButton = this.btnStore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.lblForListBox);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.lstBxNumbers);
            this.Controls.Add(this.txtBxValue5);
            this.Controls.Add(this.txtBxValue4);
            this.Controls.Add(this.txtBxValue3);
            this.Controls.Add(this.txtBxValue2);
            this.Controls.Add(this.txtBxValue1);
            this.Controls.Add(this.lblNumbers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBinaryNumbersApp";
            this.Text = "Binary Numbers App";
            this.Load += new System.EventHandler(this.FrmBinaryNumbersApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.TextBox txtBxValue1;
        private System.Windows.Forms.TextBox txtBxValue2;
        private System.Windows.Forms.TextBox txtBxValue3;
        private System.Windows.Forms.TextBox txtBxValue4;
        private System.Windows.Forms.TextBox txtBxValue5;
        private System.Windows.Forms.ListBox lstBxNumbers;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblForListBox;
    }
}

