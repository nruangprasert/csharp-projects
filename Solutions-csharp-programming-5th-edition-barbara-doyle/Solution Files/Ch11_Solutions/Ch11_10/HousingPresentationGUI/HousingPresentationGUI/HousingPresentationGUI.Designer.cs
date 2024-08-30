namespace HousingPresentationGUI
{
    partial class HousingPresentationGUI
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
            this.lstBxSingle = new System.Windows.Forms.ListBox();
            this.lstBxMulti = new System.Windows.Forms.ListBox();
            this.cmboTypeOfRental = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblRentalDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBxSingle
            // 
            this.lstBxSingle.FormattingEnabled = true;
            this.lstBxSingle.ItemHeight = 18;
            this.lstBxSingle.Location = new System.Drawing.Point(209, 104);
            this.lstBxSingle.Margin = new System.Windows.Forms.Padding(4);
            this.lstBxSingle.Name = "lstBxSingle";
            this.lstBxSingle.Size = new System.Drawing.Size(181, 76);
            this.lstBxSingle.TabIndex = 0;
            this.lstBxSingle.Visible = false;
            this.lstBxSingle.SelectedIndexChanged += new System.EventHandler(this.lstBxSingle_SelectedIndexChanged);
            // 
            // lstBxMulti
            // 
            this.lstBxMulti.FormattingEnabled = true;
            this.lstBxMulti.ItemHeight = 18;
            this.lstBxMulti.Location = new System.Drawing.Point(209, 104);
            this.lstBxMulti.Name = "lstBxMulti";
            this.lstBxMulti.Size = new System.Drawing.Size(181, 76);
            this.lstBxMulti.TabIndex = 1;
            this.lstBxMulti.Visible = false;
            this.lstBxMulti.SelectedIndexChanged += new System.EventHandler(this.lstBxMulti_SelectedIndexChanged);
            // 
            // cmboTypeOfRental
            // 
            this.cmboTypeOfRental.FormattingEnabled = true;
            this.cmboTypeOfRental.Items.AddRange(new object[] {
            "Single Family",
            "Multi Family"});
            this.cmboTypeOfRental.Location = new System.Drawing.Point(239, 46);
            this.cmboTypeOfRental.Name = "cmboTypeOfRental";
            this.cmboTypeOfRental.Size = new System.Drawing.Size(121, 26);
            this.cmboTypeOfRental.TabIndex = 2;
            this.cmboTypeOfRental.SelectedIndexChanged += new System.EventHandler(this.cmboTypeOfRental_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available Rentals";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(131, 187);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(327, 18);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "To see rental details, make selection from above";
            this.lblInstructions.Visible = false;
            // 
            // lblRentalDetails
            // 
            this.lblRentalDetails.AutoSize = true;
            this.lblRentalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalDetails.Location = new System.Drawing.Point(20, 205);
            this.lblRentalDetails.Name = "lblRentalDetails";
            this.lblRentalDetails.Size = new System.Drawing.Size(0, 24);
            this.lblRentalDetails.TabIndex = 5;
            // 
            // HousingPresentationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(588, 421);
            this.Controls.Add(this.lblRentalDetails);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboTypeOfRental);
            this.Controls.Add(this.lstBxMulti);
            this.Controls.Add(this.lstBxSingle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HousingPresentationGUI";
            this.Text = "Housing Form";
            this.Load += new System.EventHandler(this.HousingPresentationGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxSingle;
        private System.Windows.Forms.ListBox lstBxMulti;
        private System.Windows.Forms.ComboBox cmboTypeOfRental;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblRentalDetails;
    }
}

