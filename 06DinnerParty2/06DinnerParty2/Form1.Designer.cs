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
            this.TabPartyType = new System.Windows.Forms.TabControl();
            this.TabPageDinnerParty = new System.Windows.Forms.TabPage();
            this.TabPageBirthdayParty = new System.Windows.Forms.TabPage();
            this.LabelCakeWriting = new System.Windows.Forms.Label();
            this.TextBoxCakeWriting = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumPeople)).BeginInit();
            this.TabPartyType.SuspendLayout();
            this.TabPageDinnerParty.SuspendLayout();
            this.TabPageBirthdayParty.SuspendLayout();
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
            this.ChkBoxHealthy.Location = new System.Drawing.Point(0, 6);
            this.ChkBoxHealthy.Name = "ChkBoxHealthy";
            this.ChkBoxHealthy.Size = new System.Drawing.Size(101, 17);
            this.ChkBoxHealthy.TabIndex = 2;
            this.ChkBoxHealthy.Text = "Healthy Options";
            this.ChkBoxHealthy.UseVisualStyleBackColor = true;
            this.ChkBoxHealthy.CheckedChanged += new System.EventHandler(this.ChkBoxHealthy_CheckedChanged);
            // 
            // ChkBoxFancy
            // 
            this.ChkBoxFancy.AutoSize = true;
            this.ChkBoxFancy.Location = new System.Drawing.Point(15, 63);
            this.ChkBoxFancy.Name = "ChkBoxFancy";
            this.ChkBoxFancy.Size = new System.Drawing.Size(115, 17);
            this.ChkBoxFancy.TabIndex = 3;
            this.ChkBoxFancy.Text = "Fancy Decorations";
            this.ChkBoxFancy.UseVisualStyleBackColor = true;
            this.ChkBoxFancy.CheckedChanged += new System.EventHandler(this.ChkBoxFancy_CheckedChanged);
            // 
            // LabelCostDisplay
            // 
            this.LabelCostDisplay.AutoSize = true;
            this.LabelCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCostDisplay.Location = new System.Drawing.Point(12, 249);
            this.LabelCostDisplay.Name = "LabelCostDisplay";
            this.LabelCostDisplay.Size = new System.Drawing.Size(87, 16);
            this.LabelCostDisplay.TabIndex = 4;
            this.LabelCostDisplay.Text = "Total Cost: ";
            // 
            // TabPartyType
            // 
            this.TabPartyType.Controls.Add(this.TabPageDinnerParty);
            this.TabPartyType.Controls.Add(this.TabPageBirthdayParty);
            this.TabPartyType.Location = new System.Drawing.Point(15, 100);
            this.TabPartyType.Name = "TabPartyType";
            this.TabPartyType.SelectedIndex = 0;
            this.TabPartyType.Size = new System.Drawing.Size(200, 112);
            this.TabPartyType.TabIndex = 5;
            // 
            // TabPageDinnerParty
            // 
            this.TabPageDinnerParty.Controls.Add(this.ChkBoxHealthy);
            this.TabPageDinnerParty.Location = new System.Drawing.Point(4, 22);
            this.TabPageDinnerParty.Name = "TabPageDinnerParty";
            this.TabPageDinnerParty.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDinnerParty.Size = new System.Drawing.Size(192, 86);
            this.TabPageDinnerParty.TabIndex = 0;
            this.TabPageDinnerParty.Text = "Dinner Party";
            this.TabPageDinnerParty.UseVisualStyleBackColor = true;
            // 
            // TabPageBirthdayParty
            // 
            this.TabPageBirthdayParty.Controls.Add(this.LabelCakeWriting);
            this.TabPageBirthdayParty.Controls.Add(this.TextBoxCakeWriting);
            this.TabPageBirthdayParty.Location = new System.Drawing.Point(4, 22);
            this.TabPageBirthdayParty.Name = "TabPageBirthdayParty";
            this.TabPageBirthdayParty.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageBirthdayParty.Size = new System.Drawing.Size(192, 86);
            this.TabPageBirthdayParty.TabIndex = 1;
            this.TabPageBirthdayParty.Text = "Birthday Party";
            this.TabPageBirthdayParty.UseVisualStyleBackColor = true;
            // 
            // LabelCakeWriting
            // 
            this.LabelCakeWriting.AutoSize = true;
            this.LabelCakeWriting.Location = new System.Drawing.Point(-1, 6);
            this.LabelCakeWriting.Name = "LabelCakeWriting";
            this.LabelCakeWriting.Size = new System.Drawing.Size(71, 13);
            this.LabelCakeWriting.TabIndex = 1;
            this.LabelCakeWriting.Text = "Cake Writing:";
            // 
            // TextBoxCakeWriting
            // 
            this.TextBoxCakeWriting.Location = new System.Drawing.Point(0, 22);
            this.TextBoxCakeWriting.Name = "TextBoxCakeWriting";
            this.TextBoxCakeWriting.Size = new System.Drawing.Size(155, 20);
            this.TextBoxCakeWriting.TabIndex = 0;
            this.TextBoxCakeWriting.Text = "Happy Birthday!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.TabPartyType);
            this.Controls.Add(this.LabelCostDisplay);
            this.Controls.Add(this.ChkBoxFancy);
            this.Controls.Add(this.UpDownNumPeople);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumPeople)).EndInit();
            this.TabPartyType.ResumeLayout(false);
            this.TabPageDinnerParty.ResumeLayout(false);
            this.TabPageDinnerParty.PerformLayout();
            this.TabPageBirthdayParty.ResumeLayout(false);
            this.TabPageBirthdayParty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UpDownNumPeople;
        public System.Windows.Forms.CheckBox ChkBoxHealthy;
        public System.Windows.Forms.CheckBox ChkBoxFancy;
        private System.Windows.Forms.Label LabelCostDisplay;
        private System.Windows.Forms.TabControl TabPartyType;
        private System.Windows.Forms.TabPage TabPageDinnerParty;
        private System.Windows.Forms.TabPage TabPageBirthdayParty;
        private System.Windows.Forms.Label LabelCakeWriting;
        private System.Windows.Forms.TextBox TextBoxCakeWriting;
    }
}

