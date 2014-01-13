namespace _05DinnerParty
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
            this.label1 = new System.Windows.Forms.Label();
            this.UpDownNumPeople = new System.Windows.Forms.NumericUpDown();
            this.ChkBoxHealthy = new System.Windows.Forms.CheckBox();
            this.ChkBoxFancy = new System.Windows.Forms.CheckBox();
            this.LabelCostDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // UpDownNumPeople
            // 
            this.UpDownNumPeople.Location = new System.Drawing.Point(15, 26);
            this.UpDownNumPeople.Name = "UpDownNumPeople";
            this.UpDownNumPeople.Size = new System.Drawing.Size(120, 20);
            this.UpDownNumPeople.TabIndex = 1;
            this.UpDownNumPeople.ValueChanged += new System.EventHandler(this.UpDownNumPeople_ValueChanged);
            // 
            // ChkBoxHealthy
            // 
            this.ChkBoxHealthy.AutoSize = true;
            this.ChkBoxHealthy.Location = new System.Drawing.Point(15, 53);
            this.ChkBoxHealthy.Name = "ChkBoxHealthy";
            this.ChkBoxHealthy.Size = new System.Drawing.Size(62, 17);
            this.ChkBoxHealthy.TabIndex = 2;
            this.ChkBoxHealthy.Text = "Healthy";
            this.ChkBoxHealthy.UseVisualStyleBackColor = true;
            this.ChkBoxHealthy.CheckedChanged += new System.EventHandler(this.ChkBoxHealthy_CheckedChanged);
            // 
            // ChkBoxFancy
            // 
            this.ChkBoxFancy.AutoSize = true;
            this.ChkBoxFancy.Location = new System.Drawing.Point(15, 77);
            this.ChkBoxFancy.Name = "ChkBoxFancy";
            this.ChkBoxFancy.Size = new System.Drawing.Size(55, 17);
            this.ChkBoxFancy.TabIndex = 3;
            this.ChkBoxFancy.Text = "Fancy";
            this.ChkBoxFancy.UseVisualStyleBackColor = true;
            this.ChkBoxFancy.CheckedChanged += new System.EventHandler(this.ChkBoxFancy_CheckedChanged);
            // 
            // LabelCostDisplay
            // 
            this.LabelCostDisplay.AutoSize = true;
            this.LabelCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCostDisplay.Location = new System.Drawing.Point(12, 124);
            this.LabelCostDisplay.Name = "LabelCostDisplay";
            this.LabelCostDisplay.Size = new System.Drawing.Size(87, 16);
            this.LabelCostDisplay.TabIndex = 4;
            this.LabelCostDisplay.Text = "Total Cost: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LabelCostDisplay);
            this.Controls.Add(this.ChkBoxFancy);
            this.Controls.Add(this.ChkBoxHealthy);
            this.Controls.Add(this.UpDownNumPeople);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UpDownNumPeople;
        private System.Windows.Forms.CheckBox ChkBoxHealthy;
        private System.Windows.Forms.CheckBox ChkBoxFancy;
        private System.Windows.Forms.Label LabelCostDisplay;
    }
}

