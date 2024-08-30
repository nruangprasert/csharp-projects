namespace Week14Project
{
    partial class PracticeApp
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBxOutput = new System.Windows.Forms.TextBox();
            this.listEvents = new System.Windows.Forms.ListBox();
            this.listNames = new System.Windows.Forms.ListBox();
            this.txtNewEvent = new System.Windows.Forms.TextBox();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.chBxSwim = new System.Windows.Forms.CheckBox();
            this.chBxSnorkal = new System.Windows.Forms.CheckBox();
            this.chBxDive = new System.Windows.Forms.CheckBox();
            this.lblLesson = new System.Windows.Forms.Label();
            this.groupSkill = new System.Windows.Forms.GroupBox();
            this.rdBtnBeg = new System.Windows.Forms.RadioButton();
            this.rdBtnInterm = new System.Windows.Forms.RadioButton();
            this.rdBtnAdvance = new System.Windows.Forms.RadioButton();
            this.groupSkill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(159, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter your name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(182, 72);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Enter your ID";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(304, 40);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(247, 20);
            this.txtBxName.TabIndex = 0;
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(304, 74);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(247, 20);
            this.txtBxID.TabIndex = 1;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(104, 369);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(88, 38);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write to the File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(230, 369);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(88, 38);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read from the File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(339, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 38);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(451, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Location = new System.Drawing.Point(96, 311);
            this.txtBxOutput.Multiline = true;
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.Size = new System.Drawing.Size(455, 39);
            this.txtBxOutput.TabIndex = 8;
//            this.txtBxOutput.TextChanged += new System.EventHandler(this.txtBxOutput_TextChanged);
            // 
            // listEvents
            // 
            this.listEvents.FormattingEnabled = true;
            this.listEvents.Items.AddRange(new object[] {
            "Dance",
            "Dinner",
            "Games",
            "Park",
            "Sports"});
            this.listEvents.Location = new System.Drawing.Point(63, 131);
            this.listEvents.Name = "listEvents";
            this.listEvents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listEvents.Size = new System.Drawing.Size(81, 56);
            this.listEvents.Sorted = true;
            this.listEvents.TabIndex = 9;
            this.listEvents.SelectedIndexChanged += new System.EventHandler(this.listEvents_SelectedIndexChanged);
            // 
            // listNames
            // 
            this.listNames.FormattingEnabled = true;
            this.listNames.Location = new System.Drawing.Point(163, 131);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(96, 95);
            this.listNames.TabIndex = 10;
            // 
            // txtNewEvent
            // 
            this.txtNewEvent.Location = new System.Drawing.Point(41, 206);
            this.txtNewEvent.Name = "txtNewEvent";
            this.txtNewEvent.Size = new System.Drawing.Size(116, 20);
            this.txtNewEvent.TabIndex = 11;
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Location = new System.Drawing.Point(63, 232);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(81, 36);
            this.btnNewEvent.TabIndex = 12;
            this.btnNewEvent.Text = "Add a new Event";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // chBxSwim
            // 
            this.chBxSwim.AutoSize = true;
            this.chBxSwim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxSwim.Location = new System.Drawing.Point(304, 147);
            this.chBxSwim.Name = "chBxSwim";
            this.chBxSwim.Size = new System.Drawing.Size(118, 20);
            this.chBxSwim.TabIndex = 13;
            this.chBxSwim.Text = "Swimming - $50";
            this.chBxSwim.UseVisualStyleBackColor = true;
            this.chBxSwim.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // chBxSnorkal
            // 
            this.chBxSnorkal.AutoSize = true;
            this.chBxSnorkal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxSnorkal.Location = new System.Drawing.Point(304, 170);
            this.chBxSnorkal.Name = "chBxSnorkal";
            this.chBxSnorkal.Size = new System.Drawing.Size(100, 20);
            this.chBxSnorkal.TabIndex = 14;
            this.chBxSnorkal.Text = "Snorkal -$25";
            this.chBxSnorkal.UseVisualStyleBackColor = true;
            this.chBxSnorkal.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // chBxDive
            // 
            this.chBxDive.AutoSize = true;
            this.chBxDive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxDive.Location = new System.Drawing.Point(304, 193);
            this.chBxDive.Name = "chBxDive";
            this.chBxDive.Size = new System.Drawing.Size(92, 20);
            this.chBxDive.TabIndex = 15;
            this.chBxDive.Text = "Dive - $100";
            this.chBxDive.UseVisualStyleBackColor = true;
            this.chBxDive.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesson.Location = new System.Drawing.Point(301, 115);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(117, 20);
            this.lblLesson.TabIndex = 16;
            this.lblLesson.Text = "Select a lesson";
            // 
            // groupSkill
            // 
            this.groupSkill.Controls.Add(this.rdBtnAdvance);
            this.groupSkill.Controls.Add(this.rdBtnInterm);
            this.groupSkill.Controls.Add(this.rdBtnBeg);
            this.groupSkill.Location = new System.Drawing.Point(451, 115);
            this.groupSkill.Name = "groupSkill";
            this.groupSkill.Size = new System.Drawing.Size(201, 111);
            this.groupSkill.TabIndex = 17;
            this.groupSkill.TabStop = false;
            this.groupSkill.Text = "Skill Level";
            // 
            // rdBtnBeg
            // 
            this.rdBtnBeg.AutoSize = true;
            this.rdBtnBeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnBeg.Location = new System.Drawing.Point(18, 20);
            this.rdBtnBeg.Name = "rdBtnBeg";
            this.rdBtnBeg.Size = new System.Drawing.Size(142, 20);
            this.rdBtnBeg.TabIndex = 0;
            this.rdBtnBeg.Text = "Beginner - $20 extra";
            this.rdBtnBeg.UseVisualStyleBackColor = true;
            this.rdBtnBeg.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // rdBtnInterm
            // 
            this.rdBtnInterm.AutoSize = true;
            this.rdBtnInterm.Checked = true;
            this.rdBtnInterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnInterm.Location = new System.Drawing.Point(18, 44);
            this.rdBtnInterm.Name = "rdBtnInterm";
            this.rdBtnInterm.Size = new System.Drawing.Size(99, 20);
            this.rdBtnInterm.TabIndex = 1;
            this.rdBtnInterm.TabStop = true;
            this.rdBtnInterm.Text = "Intermediate";
            this.rdBtnInterm.UseVisualStyleBackColor = true;
            this.rdBtnInterm.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // rdBtnAdvance
            // 
            this.rdBtnAdvance.AutoSize = true;
            this.rdBtnAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnAdvance.Location = new System.Drawing.Point(18, 68);
            this.rdBtnAdvance.Name = "rdBtnAdvance";
            this.rdBtnAdvance.Size = new System.Drawing.Size(163, 20);
            this.rdBtnAdvance.TabIndex = 2;
            this.rdBtnAdvance.Text = "Advance - $10 discount";
            this.rdBtnAdvance.UseVisualStyleBackColor = true;
            this.rdBtnAdvance.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // PracticeApp
            // 
            this.AcceptButton = this.btnWrite;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.groupSkill);
            this.Controls.Add(this.lblLesson);
            this.Controls.Add(this.chBxDive);
            this.Controls.Add(this.chBxSnorkal);
            this.Controls.Add(this.chBxSwim);
            this.Controls.Add(this.btnNewEvent);
            this.Controls.Add(this.txtNewEvent);
            this.Controls.Add(this.listNames);
            this.Controls.Add(this.listEvents);
            this.Controls.Add(this.txtBxOutput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Name = "PracticeApp";
            this.Text = "Chapter 13 and Ch 10";
            this.groupSkill.ResumeLayout(false);
            this.groupSkill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBxOutput;
        private System.Windows.Forms.ListBox listEvents;
        private System.Windows.Forms.ListBox listNames;
        private System.Windows.Forms.TextBox txtNewEvent;
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.CheckBox chBxSwim;
        private System.Windows.Forms.CheckBox chBxSnorkal;
        private System.Windows.Forms.CheckBox chBxDive;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.GroupBox groupSkill;
        private System.Windows.Forms.RadioButton rdBtnAdvance;
        private System.Windows.Forms.RadioButton rdBtnInterm;
        private System.Windows.Forms.RadioButton rdBtnBeg;
    }
}

