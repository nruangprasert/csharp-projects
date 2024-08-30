namespace Chapter09Exrcise06
{
    partial class Form1
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblReenterPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtReenterPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReenter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(69, 27);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblReenterPassword
            // 
            this.lblReenterPassword.AutoSize = true;
            this.lblReenterPassword.Location = new System.Drawing.Point(72, 96);
            this.lblReenterPassword.Name = "lblReenterPassword";
            this.lblReenterPassword.Size = new System.Drawing.Size(97, 13);
            this.lblReenterPassword.TabIndex = 1;
            this.lblReenterPassword.Text = "Re-enter Password";
            this.lblReenterPassword.Visible = false;
            this.lblReenterPassword.Click += new System.EventHandler(this.lblReenterPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(182, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtReenterPassword
            // 
            this.txtReenterPassword.Location = new System.Drawing.Point(182, 96);
            this.txtReenterPassword.Name = "txtReenterPassword";
            this.txtReenterPassword.Size = new System.Drawing.Size(100, 20);
            this.txtReenterPassword.TabIndex = 3;
            this.txtReenterPassword.UseSystemPasswordChar = true;
            this.txtReenterPassword.Visible = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(182, 55);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReenter
            // 
            this.btnReenter.Location = new System.Drawing.Point(182, 138);
            this.btnReenter.Name = "btnReenter";
            this.btnReenter.Size = new System.Drawing.Size(75, 23);
            this.btnReenter.TabIndex = 5;
            this.btnReenter.Text = "Re-enter";
            this.btnReenter.UseVisualStyleBackColor = true;
            this.btnReenter.Visible = false;
            this.btnReenter.Click += new System.EventHandler(this.btnReenter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(182, 199);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReenter);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtReenterPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblReenterPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblReenterPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtReenterPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReenter;
        private System.Windows.Forms.Button btnReset;
    }
}

