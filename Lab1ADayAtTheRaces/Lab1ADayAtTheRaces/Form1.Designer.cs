namespace Lab1ADayAtTheRaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RacetrackPicture = new System.Windows.Forms.PictureBox();
            this.Dog0Picture = new System.Windows.Forms.PictureBox();
            this.Dog1Picture = new System.Windows.Forms.PictureBox();
            this.Dog2Picture = new System.Windows.Forms.PictureBox();
            this.Dog3Picture = new System.Windows.Forms.PictureBox();
            this.BettingParlour = new System.Windows.Forms.GroupBox();
            this.RaceButton = new System.Windows.Forms.Button();
            this.AlanLabel = new System.Windows.Forms.Label();
            this.BobLabel = new System.Windows.Forms.Label();
            this.JoeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DogChooser = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BetButton = new System.Windows.Forms.Button();
            this.BetAmountChooser = new System.Windows.Forms.NumericUpDown();
            this.ActiveBettorLabel = new System.Windows.Forms.Label();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            this.AlanRadioButton = new System.Windows.Forms.RadioButton();
            this.BobRadioButton = new System.Windows.Forms.RadioButton();
            this.JoeRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.RacetrackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog0Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3Picture)).BeginInit();
            this.BettingParlour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmountChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // RacetrackPicture
            // 
            this.RacetrackPicture.Image = ((System.Drawing.Image)(resources.GetObject("RacetrackPicture.Image")));
            this.RacetrackPicture.Location = new System.Drawing.Point(25, 12);
            this.RacetrackPicture.Name = "RacetrackPicture";
            this.RacetrackPicture.Size = new System.Drawing.Size(602, 203);
            this.RacetrackPicture.TabIndex = 0;
            this.RacetrackPicture.TabStop = false;
            // 
            // Dog0Picture
            // 
            this.Dog0Picture.Image = ((System.Drawing.Image)(resources.GetObject("Dog0Picture.Image")));
            this.Dog0Picture.Location = new System.Drawing.Point(491, 25);
            this.Dog0Picture.Name = "Dog0Picture";
            this.Dog0Picture.Size = new System.Drawing.Size(76, 24);
            this.Dog0Picture.TabIndex = 1;
            this.Dog0Picture.TabStop = false;
            // 
            // Dog1Picture
            // 
            this.Dog1Picture.Image = ((System.Drawing.Image)(resources.GetObject("Dog1Picture.Image")));
            this.Dog1Picture.Location = new System.Drawing.Point(37, 70);
            this.Dog1Picture.Name = "Dog1Picture";
            this.Dog1Picture.Size = new System.Drawing.Size(76, 24);
            this.Dog1Picture.TabIndex = 2;
            this.Dog1Picture.TabStop = false;
            // 
            // Dog2Picture
            // 
            this.Dog2Picture.Image = ((System.Drawing.Image)(resources.GetObject("Dog2Picture.Image")));
            this.Dog2Picture.Location = new System.Drawing.Point(37, 124);
            this.Dog2Picture.Name = "Dog2Picture";
            this.Dog2Picture.Size = new System.Drawing.Size(76, 24);
            this.Dog2Picture.TabIndex = 3;
            this.Dog2Picture.TabStop = false;
            // 
            // Dog3Picture
            // 
            this.Dog3Picture.Image = ((System.Drawing.Image)(resources.GetObject("Dog3Picture.Image")));
            this.Dog3Picture.Location = new System.Drawing.Point(37, 176);
            this.Dog3Picture.Name = "Dog3Picture";
            this.Dog3Picture.Size = new System.Drawing.Size(76, 24);
            this.Dog3Picture.TabIndex = 4;
            this.Dog3Picture.TabStop = false;
            // 
            // BettingParlour
            // 
            this.BettingParlour.Controls.Add(this.RaceButton);
            this.BettingParlour.Controls.Add(this.AlanLabel);
            this.BettingParlour.Controls.Add(this.BobLabel);
            this.BettingParlour.Controls.Add(this.JoeLabel);
            this.BettingParlour.Controls.Add(this.label2);
            this.BettingParlour.Controls.Add(this.DogChooser);
            this.BettingParlour.Controls.Add(this.label1);
            this.BettingParlour.Controls.Add(this.BetButton);
            this.BettingParlour.Controls.Add(this.BetAmountChooser);
            this.BettingParlour.Controls.Add(this.ActiveBettorLabel);
            this.BettingParlour.Controls.Add(this.MinimumBetLabel);
            this.BettingParlour.Controls.Add(this.AlanRadioButton);
            this.BettingParlour.Controls.Add(this.BobRadioButton);
            this.BettingParlour.Controls.Add(this.JoeRadioButton);
            this.BettingParlour.Location = new System.Drawing.Point(25, 238);
            this.BettingParlour.Name = "BettingParlour";
            this.BettingParlour.Size = new System.Drawing.Size(602, 236);
            this.BettingParlour.TabIndex = 5;
            this.BettingParlour.TabStop = false;
            this.BettingParlour.Text = "Betting Parlour";
            // 
            // RaceButton
            // 
            this.RaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceButton.Location = new System.Drawing.Point(12, 187);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(132, 43);
            this.RaceButton.TabIndex = 13;
            this.RaceButton.Text = "Race!";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // AlanLabel
            // 
            this.AlanLabel.AutoSize = true;
            this.AlanLabel.Location = new System.Drawing.Point(312, 107);
            this.AlanLabel.Name = "AlanLabel";
            this.AlanLabel.Size = new System.Drawing.Size(57, 13);
            this.AlanLabel.TabIndex = 12;
            this.AlanLabel.Text = "Alan\'s Bet:";
            // 
            // BobLabel
            // 
            this.BobLabel.AutoSize = true;
            this.BobLabel.Location = new System.Drawing.Point(311, 84);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(55, 13);
            this.BobLabel.TabIndex = 11;
            this.BobLabel.Text = "Bob\'s Bet:";
            // 
            // JoeLabel
            // 
            this.JoeLabel.AutoSize = true;
            this.JoeLabel.Location = new System.Drawing.Point(312, 61);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(53, 13);
            this.JoeLabel.TabIndex = 10;
            this.JoeLabel.Text = "Joe\'s Bet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bets:";
            // 
            // DogChooser
            // 
            this.DogChooser.Location = new System.Drawing.Point(315, 150);
            this.DogChooser.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DogChooser.Name = "DogChooser";
            this.DogChooser.Size = new System.Drawing.Size(49, 20);
            this.DogChooser.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "on dog number";
            // 
            // BetButton
            // 
            this.BetButton.Location = new System.Drawing.Point(97, 147);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(75, 23);
            this.BetButton.TabIndex = 6;
            this.BetButton.Text = "bets";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // BetAmountChooser
            // 
            this.BetAmountChooser.Location = new System.Drawing.Point(178, 150);
            this.BetAmountChooser.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.BetAmountChooser.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmountChooser.Name = "BetAmountChooser";
            this.BetAmountChooser.Size = new System.Drawing.Size(49, 20);
            this.BetAmountChooser.TabIndex = 5;
            this.BetAmountChooser.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ActiveBettorLabel
            // 
            this.ActiveBettorLabel.AutoSize = true;
            this.ActiveBettorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveBettorLabel.Location = new System.Drawing.Point(8, 147);
            this.ActiveBettorLabel.Name = "ActiveBettorLabel";
            this.ActiveBettorLabel.Size = new System.Drawing.Size(99, 20);
            this.ActiveBettorLabel.TabIndex = 4;
            this.ActiveBettorLabel.Text = "Bettor Name";
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBetLabel.Location = new System.Drawing.Point(7, 28);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(147, 26);
            this.MinimumBetLabel.TabIndex = 3;
            this.MinimumBetLabel.Text = "Minimum Bet:";
            // 
            // AlanRadioButton
            // 
            this.AlanRadioButton.AutoSize = true;
            this.AlanRadioButton.Location = new System.Drawing.Point(10, 105);
            this.AlanRadioButton.Name = "AlanRadioButton";
            this.AlanRadioButton.Size = new System.Drawing.Size(46, 17);
            this.AlanRadioButton.TabIndex = 2;
            this.AlanRadioButton.Text = "Alan";
            this.AlanRadioButton.UseVisualStyleBackColor = true;
            this.AlanRadioButton.CheckedChanged += new System.EventHandler(this.AlanRadioButton_CheckedChanged);
            // 
            // BobRadioButton
            // 
            this.BobRadioButton.AutoSize = true;
            this.BobRadioButton.Location = new System.Drawing.Point(10, 82);
            this.BobRadioButton.Name = "BobRadioButton";
            this.BobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.BobRadioButton.TabIndex = 1;
            this.BobRadioButton.Text = "Bob";
            this.BobRadioButton.UseVisualStyleBackColor = true;
            this.BobRadioButton.CheckedChanged += new System.EventHandler(this.BobRadioButton_CheckedChanged);
            // 
            // JoeRadioButton
            // 
            this.JoeRadioButton.AutoSize = true;
            this.JoeRadioButton.Checked = true;
            this.JoeRadioButton.Location = new System.Drawing.Point(10, 59);
            this.JoeRadioButton.Name = "JoeRadioButton";
            this.JoeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.JoeRadioButton.TabIndex = 0;
            this.JoeRadioButton.TabStop = true;
            this.JoeRadioButton.Text = "Joe";
            this.JoeRadioButton.UseVisualStyleBackColor = true;
            this.JoeRadioButton.CheckedChanged += new System.EventHandler(this.JoeRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 486);
            this.Controls.Add(this.BettingParlour);
            this.Controls.Add(this.Dog3Picture);
            this.Controls.Add(this.Dog2Picture);
            this.Controls.Add(this.Dog1Picture);
            this.Controls.Add(this.Dog0Picture);
            this.Controls.Add(this.RacetrackPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RacetrackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog0Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3Picture)).EndInit();
            this.BettingParlour.ResumeLayout(false);
            this.BettingParlour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmountChooser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RacetrackPicture;
        private System.Windows.Forms.PictureBox Dog0Picture;
        private System.Windows.Forms.PictureBox Dog1Picture;
        private System.Windows.Forms.PictureBox Dog2Picture;
        private System.Windows.Forms.PictureBox Dog3Picture;
        private System.Windows.Forms.GroupBox BettingParlour;
        private System.Windows.Forms.NumericUpDown DogChooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.NumericUpDown BetAmountChooser;
        private System.Windows.Forms.Label ActiveBettorLabel;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.RadioButton AlanRadioButton;
        private System.Windows.Forms.RadioButton BobRadioButton;
        private System.Windows.Forms.RadioButton JoeRadioButton;
        private System.Windows.Forms.Label AlanLabel;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.Label JoeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RaceButton;
    }
}

