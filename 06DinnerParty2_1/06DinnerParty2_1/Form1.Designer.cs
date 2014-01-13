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
            this.LabelDPCostDisplay = new System.Windows.Forms.Label();
            this.TabPartyType = new System.Windows.Forms.TabControl();
            this.TabPageDinnerParty = new System.Windows.Forms.TabPage();
            this.TabPageBirthdayParty = new System.Windows.Forms.TabPage();
            this.LabelBPCostDisplay = new System.Windows.Forms.Label();
            this.CheckBoxBPFancy = new System.Windows.Forms.CheckBox();
            this.NumUpDnBPNumPeople = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelCakeWriting = new System.Windows.Forms.Label();
            this.TextBoxCakeWriting = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumPeople)).BeginInit();
            this.TabPartyType.SuspendLayout();
            this.TabPageDinnerParty.SuspendLayout();
            this.TabPageBirthdayParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDnBPNumPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // UpDownNumPeople
            // 
            this.UpDownNumPeople.Location = new System.Drawing.Point(0, 31);
            this.UpDownNumPeople.Name = "UpDownNumPeople";
            this.UpDownNumPeople.Size = new System.Drawing.Size(120, 20);
            this.UpDownNumPeople.TabIndex = 1;
            this.UpDownNumPeople.ValueChanged += new System.EventHandler(this.UpDownNumPeople_ValueChanged);
            // 
            // ChkBoxHealthy
            // 
            this.ChkBoxHealthy.AutoSize = true;
            this.ChkBoxHealthy.Location = new System.Drawing.Point(0, 57);
            this.ChkBoxHealthy.Name = "ChkBoxHealthy";
            this.ChkBoxHealthy.Size = new System.Drawing.Size(96, 17);
            this.ChkBoxHealthy.TabIndex = 2;
            this.ChkBoxHealthy.Text = "Healthy Option";
            this.ChkBoxHealthy.UseVisualStyleBackColor = true;
            this.ChkBoxHealthy.CheckedChanged += new System.EventHandler(this.ChkBoxHealthy_CheckedChanged);
            // 
            // ChkBoxFancy
            // 
            this.ChkBoxFancy.AutoSize = true;
            this.ChkBoxFancy.Location = new System.Drawing.Point(0, 80);
            this.ChkBoxFancy.Name = "ChkBoxFancy";
            this.ChkBoxFancy.Size = new System.Drawing.Size(115, 17);
            this.ChkBoxFancy.TabIndex = 3;
            this.ChkBoxFancy.Text = "Fancy Decorations";
            this.ChkBoxFancy.UseVisualStyleBackColor = true;
            this.ChkBoxFancy.CheckedChanged += new System.EventHandler(this.ChkBoxFancy_CheckedChanged);
            // 
            // LabelDPCostDisplay
            // 
            this.LabelDPCostDisplay.AutoSize = true;
            this.LabelDPCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDPCostDisplay.Location = new System.Drawing.Point(-2, 120);
            this.LabelDPCostDisplay.Name = "LabelDPCostDisplay";
            this.LabelDPCostDisplay.Size = new System.Drawing.Size(87, 16);
            this.LabelDPCostDisplay.TabIndex = 4;
            this.LabelDPCostDisplay.Text = "Total Cost: ";
            // 
            // TabPartyType
            // 
            this.TabPartyType.Controls.Add(this.TabPageDinnerParty);
            this.TabPartyType.Controls.Add(this.TabPageBirthdayParty);
            this.TabPartyType.Location = new System.Drawing.Point(15, 12);
            this.TabPartyType.Name = "TabPartyType";
            this.TabPartyType.SelectedIndex = 0;
            this.TabPartyType.Size = new System.Drawing.Size(257, 179);
            this.TabPartyType.TabIndex = 5;
            // 
            // TabPageDinnerParty
            // 
            this.TabPageDinnerParty.Controls.Add(this.ChkBoxHealthy);
            this.TabPageDinnerParty.Controls.Add(this.UpDownNumPeople);
            this.TabPageDinnerParty.Controls.Add(this.label1);
            this.TabPageDinnerParty.Controls.Add(this.LabelDPCostDisplay);
            this.TabPageDinnerParty.Controls.Add(this.ChkBoxFancy);
            this.TabPageDinnerParty.Location = new System.Drawing.Point(4, 22);
            this.TabPageDinnerParty.Name = "TabPageDinnerParty";
            this.TabPageDinnerParty.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDinnerParty.Size = new System.Drawing.Size(249, 153);
            this.TabPageDinnerParty.TabIndex = 0;
            this.TabPageDinnerParty.Text = "Dinner Party";
            this.TabPageDinnerParty.UseVisualStyleBackColor = true;
            // 
            // TabPageBirthdayParty
            // 
            this.TabPageBirthdayParty.Controls.Add(this.LabelBPCostDisplay);
            this.TabPageBirthdayParty.Controls.Add(this.CheckBoxBPFancy);
            this.TabPageBirthdayParty.Controls.Add(this.NumUpDnBPNumPeople);
            this.TabPageBirthdayParty.Controls.Add(this.label2);
            this.TabPageBirthdayParty.Controls.Add(this.LabelCakeWriting);
            this.TabPageBirthdayParty.Controls.Add(this.TextBoxCakeWriting);
            this.TabPageBirthdayParty.Location = new System.Drawing.Point(4, 22);
            this.TabPageBirthdayParty.Name = "TabPageBirthdayParty";
            this.TabPageBirthdayParty.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageBirthdayParty.Size = new System.Drawing.Size(249, 153);
            this.TabPageBirthdayParty.TabIndex = 1;
            this.TabPageBirthdayParty.Text = "Birthday Party";
            this.TabPageBirthdayParty.UseVisualStyleBackColor = true;
            // 
            // LabelBPCostDisplay
            // 
            this.LabelBPCostDisplay.AutoSize = true;
            this.LabelBPCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBPCostDisplay.Location = new System.Drawing.Point(-1, 122);
            this.LabelBPCostDisplay.Name = "LabelBPCostDisplay";
            this.LabelBPCostDisplay.Size = new System.Drawing.Size(87, 16);
            this.LabelBPCostDisplay.TabIndex = 5;
            this.LabelBPCostDisplay.Text = "Total Cost: ";
            // 
            // CheckBoxBPFancy
            // 
            this.CheckBoxBPFancy.AutoSize = true;
            this.CheckBoxBPFancy.Location = new System.Drawing.Point(0, 56);
            this.CheckBoxBPFancy.Name = "CheckBoxBPFancy";
            this.CheckBoxBPFancy.Size = new System.Drawing.Size(115, 17);
            this.CheckBoxBPFancy.TabIndex = 4;
            this.CheckBoxBPFancy.Text = "Fancy Decorations";
            this.CheckBoxBPFancy.UseVisualStyleBackColor = true;
            this.CheckBoxBPFancy.CheckedChanged += new System.EventHandler(this.CheckBoxBPFancy_CheckedChanged);
            // 
            // NumUpDnBPNumPeople
            // 
            this.NumUpDnBPNumPeople.Location = new System.Drawing.Point(0, 30);
            this.NumUpDnBPNumPeople.Name = "NumUpDnBPNumPeople";
            this.NumUpDnBPNumPeople.Size = new System.Drawing.Size(120, 20);
            this.NumUpDnBPNumPeople.TabIndex = 3;
            this.NumUpDnBPNumPeople.ValueChanged += new System.EventHandler(this.NumUpDnBPNumPeople_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of People";
            // 
            // LabelCakeWriting
            // 
            this.LabelCakeWriting.AutoSize = true;
            this.LabelCakeWriting.Location = new System.Drawing.Point(-1, 80);
            this.LabelCakeWriting.Name = "LabelCakeWriting";
            this.LabelCakeWriting.Size = new System.Drawing.Size(71, 13);
            this.LabelCakeWriting.TabIndex = 1;
            this.LabelCakeWriting.Text = "Cake Writing:";
            // 
            // TextBoxCakeWriting
            // 
            this.TextBoxCakeWriting.Location = new System.Drawing.Point(0, 96);
            this.TextBoxCakeWriting.Name = "TextBoxCakeWriting";
            this.TextBoxCakeWriting.Size = new System.Drawing.Size(155, 20);
            this.TextBoxCakeWriting.TabIndex = 0;
            this.TextBoxCakeWriting.Text = "Happy Birthday!";
            this.TextBoxCakeWriting.TextChanged += new System.EventHandler(this.TextBoxCakeWriting_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.TabPartyType);
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumPeople)).EndInit();
            this.TabPartyType.ResumeLayout(false);
            this.TabPageDinnerParty.ResumeLayout(false);
            this.TabPageDinnerParty.PerformLayout();
            this.TabPageBirthdayParty.ResumeLayout(false);
            this.TabPageBirthdayParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDnBPNumPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UpDownNumPeople;
        public System.Windows.Forms.CheckBox ChkBoxHealthy;
        public System.Windows.Forms.CheckBox ChkBoxFancy;
        private System.Windows.Forms.Label LabelDPCostDisplay;
        private System.Windows.Forms.TabControl TabPartyType;
        private System.Windows.Forms.TabPage TabPageDinnerParty;
        private System.Windows.Forms.TabPage TabPageBirthdayParty;
        private System.Windows.Forms.Label LabelCakeWriting;
        private System.Windows.Forms.TextBox TextBoxCakeWriting;
        public System.Windows.Forms.CheckBox CheckBoxBPFancy;
        private System.Windows.Forms.NumericUpDown NumUpDnBPNumPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelBPCostDisplay;
    }
}

