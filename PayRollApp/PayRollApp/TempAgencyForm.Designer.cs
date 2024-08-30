﻿/* TempAgencyForm.Designer.cs 
 * This partial class includes code
 * generated by Visual Studio when the GUI
 * was created.
 */
namespace PayRollApp
{
    public partial class TempAgencyForm
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblFed = new System.Windows.Forms.Label();
            this.lblSoc = new System.Windows.Forms.Label();
            this.lblAgency = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxHours = new System.Windows.Forms.TextBox();
            this.txtBxDep = new System.Windows.Forms.TextBox();
            this.txtBxGross = new System.Windows.Forms.TextBox();
            this.txtBxFed = new System.Windows.Forms.TextBox();
            this.txtBxSoc = new System.Windows.Forms.TextBox();
            this.txtBxAgency = new System.Windows.Forms.TextBox();
            this.txtBxNet = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.listDept = new System.Windows.Forms.ListBox();
            this.chkBasicCoverage = new System.Windows.Forms.CheckBox();
            this.chkExtendedCoverage = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(231, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XYZ JobSource";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(150, 76);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(150, 122);
            this.lblHours.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(152, 23);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "No. Hours Worked:";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(150, 172);
            this.lblDep.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(150, 23);
            this.lblDep.TabIndex = 3;
            this.lblDep.Text = "No. of Dependents:";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(189, 315);
            this.lblGross.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(86, 23);
            this.lblGross.TabIndex = 4;
            this.lblGross.Text = "Gross Pay:";
            this.lblGross.Visible = false;
            // 
            // lblFed
            // 
            this.lblFed.AutoSize = true;
            this.lblFed.Location = new System.Drawing.Point(189, 364);
            this.lblFed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(109, 23);
            this.lblFed.TabIndex = 5;
            this.lblFed.Text = "Federal Ded.:";
            this.lblFed.Visible = false;
            // 
            // lblSoc
            // 
            this.lblSoc.AutoSize = true;
            this.lblSoc.Location = new System.Drawing.Point(189, 414);
            this.lblSoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoc.Name = "lblSoc";
            this.lblSoc.Size = new System.Drawing.Size(112, 23);
            this.lblSoc.TabIndex = 6;
            this.lblSoc.Text = "Soc Sec Ded.:";
            this.lblSoc.Visible = false;
            // 
            // lblAgency
            // 
            this.lblAgency.AutoSize = true;
            this.lblAgency.Location = new System.Drawing.Point(189, 464);
            this.lblAgency.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.Size = new System.Drawing.Size(99, 23);
            this.lblAgency.TabIndex = 7;
            this.lblAgency.Text = "Agency Fee:";
            this.lblAgency.Visible = false;
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Location = new System.Drawing.Point(189, 513);
            this.lblNet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(73, 23);
            this.lblNet.TabIndex = 8;
            this.lblNet.Text = "Net Pay:";
            this.lblNet.Visible = false;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(214, 69);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(273, 30);
            this.txtBxName.TabIndex = 0;
            // 
            // txtBxHours
            // 
            this.txtBxHours.AcceptsReturn = true;
            this.txtBxHours.Location = new System.Drawing.Point(342, 115);
            this.txtBxHours.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxHours.Name = "txtBxHours";
            this.txtBxHours.Size = new System.Drawing.Size(145, 30);
            this.txtBxHours.TabIndex = 1;
            this.txtBxHours.Text = "0";
            this.txtBxHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxDep
            // 
            this.txtBxDep.AcceptsReturn = true;
            this.txtBxDep.Location = new System.Drawing.Point(342, 165);
            this.txtBxDep.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxDep.Name = "txtBxDep";
            this.txtBxDep.Size = new System.Drawing.Size(145, 30);
            this.txtBxDep.TabIndex = 2;
            this.txtBxDep.Text = "0";
            this.txtBxDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxGross
            // 
            this.txtBxGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBxGross.Location = new System.Drawing.Point(322, 308);
            this.txtBxGross.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxGross.Name = "txtBxGross";
            this.txtBxGross.Size = new System.Drawing.Size(131, 30);
            this.txtBxGross.TabIndex = 12;
            this.txtBxGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxGross.Visible = false;
            // 
            // txtBxFed
            // 
            this.txtBxFed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBxFed.Location = new System.Drawing.Point(322, 357);
            this.txtBxFed.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxFed.Name = "txtBxFed";
            this.txtBxFed.Size = new System.Drawing.Size(131, 30);
            this.txtBxFed.TabIndex = 13;
            this.txtBxFed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxFed.Visible = false;
            // 
            // txtBxSoc
            // 
            this.txtBxSoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBxSoc.Location = new System.Drawing.Point(322, 407);
            this.txtBxSoc.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxSoc.Name = "txtBxSoc";
            this.txtBxSoc.Size = new System.Drawing.Size(131, 30);
            this.txtBxSoc.TabIndex = 14;
            this.txtBxSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxSoc.Visible = false;
            // 
            // txtBxAgency
            // 
            this.txtBxAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBxAgency.Location = new System.Drawing.Point(322, 456);
            this.txtBxAgency.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxAgency.Name = "txtBxAgency";
            this.txtBxAgency.Size = new System.Drawing.Size(131, 30);
            this.txtBxAgency.TabIndex = 15;
            this.txtBxAgency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxAgency.Visible = false;
            // 
            // txtBxNet
            // 
            this.txtBxNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBxNet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNet.Location = new System.Drawing.Point(322, 506);
            this.txtBxNet.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxNet.Multiline = true;
            this.txtBxNet.Name = "txtBxNet";
            this.txtBxNet.Size = new System.Drawing.Size(331, 35);
            this.txtBxNet.TabIndex = 16;
            this.txtBxNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxNet.Visible = false;
            this.txtBxNet.TextChanged += new System.EventHandler(this.txtBxNet_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalculate.Location = new System.Drawing.Point(167, 217);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 72);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Take Home Pay";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(351, 228);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 41);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listDept
            // 
            this.listDept.FormattingEnabled = true;
            this.listDept.ItemHeight = 23;
            this.listDept.Location = new System.Drawing.Point(510, 69);
            this.listDept.Name = "listDept";
            this.listDept.Size = new System.Drawing.Size(120, 96);
            this.listDept.Sorted = true;
            this.listDept.TabIndex = 19;
            this.listDept.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chkBasicCoverage
            // 
            this.chkBasicCoverage.AutoSize = true;
            this.chkBasicCoverage.Checked = true;
            this.chkBasicCoverage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBasicCoverage.Location = new System.Drawing.Point(510, 177);
            this.chkBasicCoverage.Name = "chkBasicCoverage";
            this.chkBasicCoverage.Size = new System.Drawing.Size(138, 27);
            this.chkBasicCoverage.TabIndex = 20;
            this.chkBasicCoverage.Text = "Basic Coverage";
            this.chkBasicCoverage.UseVisualStyleBackColor = true;
            // 
            // chkExtendedCoverage
            // 
            this.chkExtendedCoverage.AutoSize = true;
            this.chkExtendedCoverage.Location = new System.Drawing.Point(510, 211);
            this.chkExtendedCoverage.Name = "chkExtendedCoverage";
            this.chkExtendedCoverage.Size = new System.Drawing.Size(168, 27);
            this.chkExtendedCoverage.TabIndex = 21;
            this.chkExtendedCoverage.Text = "Extended Coverage";
            this.chkExtendedCoverage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(510, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 140);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 98);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(124, 27);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // TempAgencyForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(842, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkExtendedCoverage);
            this.Controls.Add(this.chkBasicCoverage);
            this.Controls.Add(this.listDept);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBxNet);
            this.Controls.Add(this.txtBxAgency);
            this.Controls.Add(this.txtBxSoc);
            this.Controls.Add(this.txtBxFed);
            this.Controls.Add(this.txtBxGross);
            this.Controls.Add(this.txtBxDep);
            this.Controls.Add(this.txtBxHours);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblAgency);
            this.Controls.Add(this.lblSoc);
            this.Controls.Add(this.lblFed);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TempAgencyForm";
            this.Text = "Payroll App";
            this.Load += new System.EventHandler(this.TempAgencyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblFed;
        private System.Windows.Forms.Label lblSoc;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxHours;
        private System.Windows.Forms.TextBox txtBxDep;
        private System.Windows.Forms.TextBox txtBxGross;
        private System.Windows.Forms.TextBox txtBxFed;
        private System.Windows.Forms.TextBox txtBxSoc;
        private System.Windows.Forms.TextBox txtBxAgency;
        private System.Windows.Forms.TextBox txtBxNet;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox listDept;
        private System.Windows.Forms.CheckBox chkBasicCoverage;
        private System.Windows.Forms.CheckBox chkExtendedCoverage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

