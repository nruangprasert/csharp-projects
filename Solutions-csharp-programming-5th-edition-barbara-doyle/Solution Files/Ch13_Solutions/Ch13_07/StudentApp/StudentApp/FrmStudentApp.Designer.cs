namespace StudentApp
{
    partial class FrmStudentApp
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
            this.lstBxStudents = new System.Windows.Forms.ListBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBxStudents
            // 
            this.lstBxStudents.FormattingEnabled = true;
            this.lstBxStudents.ItemHeight = 18;
            this.lstBxStudents.Location = new System.Drawing.Point(77, 48);
            this.lstBxStudents.Name = "lstBxStudents";
            this.lstBxStudents.Size = new System.Drawing.Size(273, 112);
            this.lstBxStudents.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(100, 27);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(256, 18);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Student Records (Raw data in the file)";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRetrieve.Location = new System.Drawing.Point(77, 178);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(111, 72);
            this.btnRetrieve.TabIndex = 2;
            this.btnRetrieve.Text = "Retrieve Data from File";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStore.Enabled = false;
            this.btnStore.Location = new System.Drawing.Point(239, 178);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(111, 72);
            this.btnStore.TabIndex = 3;
            this.btnStore.Text = "Create New File";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(48, 292);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 4;
            // 
            // FrmStudentApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lstBxStudents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudentApp";
            this.Text = "Student App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStudentApp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxStudents;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Label lblMessage;
    }
}

