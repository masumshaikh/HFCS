namespace _06BeehiveManagement
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
            this.GrpBoxAssignments = new System.Windows.Forms.GroupBox();
            this.BtnAssignJob = new System.Windows.Forms.Button();
            this.NudNumShiftsForJob = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CmboxJobs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnWorkNextShift = new System.Windows.Forms.Button();
            this.TxtBoxReport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GrpBoxAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumShiftsForJob)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxAssignments
            // 
            this.GrpBoxAssignments.Controls.Add(this.BtnAssignJob);
            this.GrpBoxAssignments.Controls.Add(this.NudNumShiftsForJob);
            this.GrpBoxAssignments.Controls.Add(this.label2);
            this.GrpBoxAssignments.Controls.Add(this.CmboxJobs);
            this.GrpBoxAssignments.Controls.Add(this.label1);
            this.GrpBoxAssignments.Location = new System.Drawing.Point(17, 19);
            this.GrpBoxAssignments.Name = "GrpBoxAssignments";
            this.GrpBoxAssignments.Size = new System.Drawing.Size(241, 99);
            this.GrpBoxAssignments.TabIndex = 0;
            this.GrpBoxAssignments.TabStop = false;
            this.GrpBoxAssignments.Text = "Worker Bee Assignments";
            // 
            // BtnAssignJob
            // 
            this.BtnAssignJob.Location = new System.Drawing.Point(9, 68);
            this.BtnAssignJob.Name = "BtnAssignJob";
            this.BtnAssignJob.Size = new System.Drawing.Size(223, 23);
            this.BtnAssignJob.TabIndex = 4;
            this.BtnAssignJob.Text = "Assign this job to a bee";
            this.BtnAssignJob.UseVisualStyleBackColor = true;
            this.BtnAssignJob.Click += new System.EventHandler(this.BtnAssignJob_Click);
            // 
            // NudNumShiftsForJob
            // 
            this.NudNumShiftsForJob.Location = new System.Drawing.Point(138, 39);
            this.NudNumShiftsForJob.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudNumShiftsForJob.Name = "NudNumShiftsForJob";
            this.NudNumShiftsForJob.Size = new System.Drawing.Size(95, 20);
            this.NudNumShiftsForJob.TabIndex = 3;
            this.NudNumShiftsForJob.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "#Shifts job will take";
            // 
            // CmboxJobs
            // 
            this.CmboxJobs.AllowDrop = true;
            this.CmboxJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboxJobs.FormattingEnabled = true;
            this.CmboxJobs.Items.AddRange(new object[] {
            "Nectar Collecting",
            "Egg Care",
            "Hive Maintenance",
            "Baby Bee Tutoring",
            "Honey Manufacturing",
            "Sting Patrol"});
            this.CmboxJobs.Location = new System.Drawing.Point(9, 39);
            this.CmboxJobs.Name = "CmboxJobs";
            this.CmboxJobs.Size = new System.Drawing.Size(121, 21);
            this.CmboxJobs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Bee Job";
            // 
            // BtnWorkNextShift
            // 
            this.BtnWorkNextShift.Location = new System.Drawing.Point(278, 25);
            this.BtnWorkNextShift.Name = "BtnWorkNextShift";
            this.BtnWorkNextShift.Size = new System.Drawing.Size(95, 53);
            this.BtnWorkNextShift.TabIndex = 1;
            this.BtnWorkNextShift.Text = "Work the next shift!";
            this.BtnWorkNextShift.UseVisualStyleBackColor = true;
            this.BtnWorkNextShift.Click += new System.EventHandler(this.BtnWorkNextShift_Click);
            // 
            // TxtBoxReport
            // 
            this.TxtBoxReport.Location = new System.Drawing.Point(21, 157);
            this.TxtBoxReport.Multiline = true;
            this.TxtBoxReport.Name = "TxtBoxReport";
            this.TxtBoxReport.Size = new System.Drawing.Size(351, 208);
            this.TxtBoxReport.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Report";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxReport);
            this.Controls.Add(this.BtnWorkNextShift);
            this.Controls.Add(this.GrpBoxAssignments);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.GrpBoxAssignments.ResumeLayout(false);
            this.GrpBoxAssignments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumShiftsForJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxAssignments;
        private System.Windows.Forms.ComboBox CmboxJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAssignJob;
        private System.Windows.Forms.NumericUpDown NudNumShiftsForJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnWorkNextShift;
        private System.Windows.Forms.TextBox TxtBoxReport;
        private System.Windows.Forms.Label label3;
    }
}

