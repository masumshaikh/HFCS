namespace Ch8_MoreCards
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
            this.LiBoxLeftDeck = new System.Windows.Forms.ListBox();
            this.LiBoxRightDeck = new System.Windows.Forms.ListBox();
            this.BtnMoveLeftToRight = new System.Windows.Forms.Button();
            this.BtnMoveRightToLeft = new System.Windows.Forms.Button();
            this.BtnResetDeck1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnShuffleDeck1 = new System.Windows.Forms.Button();
            this.BtnShuffleDeck2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LiBoxLeftDeck
            // 
            this.LiBoxLeftDeck.FormattingEnabled = true;
            this.LiBoxLeftDeck.Location = new System.Drawing.Point(11, 14);
            this.LiBoxLeftDeck.Name = "LiBoxLeftDeck";
            this.LiBoxLeftDeck.Size = new System.Drawing.Size(150, 225);
            this.LiBoxLeftDeck.TabIndex = 0;
            // 
            // LiBoxRightDeck
            // 
            this.LiBoxRightDeck.FormattingEnabled = true;
            this.LiBoxRightDeck.Location = new System.Drawing.Point(252, 14);
            this.LiBoxRightDeck.Name = "LiBoxRightDeck";
            this.LiBoxRightDeck.Size = new System.Drawing.Size(150, 225);
            this.LiBoxRightDeck.TabIndex = 1;
            // 
            // BtnMoveLeftToRight
            // 
            this.BtnMoveLeftToRight.Location = new System.Drawing.Point(172, 34);
            this.BtnMoveLeftToRight.Name = "BtnMoveLeftToRight";
            this.BtnMoveLeftToRight.Size = new System.Drawing.Size(67, 22);
            this.BtnMoveLeftToRight.TabIndex = 2;
            this.BtnMoveLeftToRight.Text = ">>";
            this.BtnMoveLeftToRight.UseVisualStyleBackColor = true;
            this.BtnMoveLeftToRight.Click += new System.EventHandler(this.BtnMoveLeftToRight_Click);
            // 
            // BtnMoveRightToLeft
            // 
            this.BtnMoveRightToLeft.Location = new System.Drawing.Point(172, 80);
            this.BtnMoveRightToLeft.Name = "BtnMoveRightToLeft";
            this.BtnMoveRightToLeft.Size = new System.Drawing.Size(67, 22);
            this.BtnMoveRightToLeft.TabIndex = 3;
            this.BtnMoveRightToLeft.Text = "<<";
            this.BtnMoveRightToLeft.UseVisualStyleBackColor = true;
            this.BtnMoveRightToLeft.Click += new System.EventHandler(this.BtnMoveRightToLeft_Click);
            // 
            // BtnResetDeck1
            // 
            this.BtnResetDeck1.Location = new System.Drawing.Point(11, 260);
            this.BtnResetDeck1.Name = "BtnResetDeck1";
            this.BtnResetDeck1.Size = new System.Drawing.Size(150, 22);
            this.BtnResetDeck1.TabIndex = 4;
            this.BtnResetDeck1.Text = "Reset Deck 1";
            this.BtnResetDeck1.UseVisualStyleBackColor = true;
            this.BtnResetDeck1.Click += new System.EventHandler(this.BtnResetDeck1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset Deck 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnShuffleDeck1
            // 
            this.BtnShuffleDeck1.Location = new System.Drawing.Point(12, 288);
            this.BtnShuffleDeck1.Name = "BtnShuffleDeck1";
            this.BtnShuffleDeck1.Size = new System.Drawing.Size(150, 22);
            this.BtnShuffleDeck1.TabIndex = 6;
            this.BtnShuffleDeck1.Text = "Shuffle Deck 1";
            this.BtnShuffleDeck1.UseVisualStyleBackColor = true;
            this.BtnShuffleDeck1.Click += new System.EventHandler(this.BtnShuffleDeck1_Click);
            // 
            // BtnShuffleDeck2
            // 
            this.BtnShuffleDeck2.Location = new System.Drawing.Point(252, 288);
            this.BtnShuffleDeck2.Name = "BtnShuffleDeck2";
            this.BtnShuffleDeck2.Size = new System.Drawing.Size(150, 22);
            this.BtnShuffleDeck2.TabIndex = 7;
            this.BtnShuffleDeck2.Text = "Shuffle Deck 2\r\n";
            this.BtnShuffleDeck2.UseVisualStyleBackColor = true;
            this.BtnShuffleDeck2.Click += new System.EventHandler(this.BtnShuffleDeck2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 418);
            this.Controls.Add(this.BtnShuffleDeck2);
            this.Controls.Add(this.BtnShuffleDeck1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnResetDeck1);
            this.Controls.Add(this.BtnMoveRightToLeft);
            this.Controls.Add(this.BtnMoveLeftToRight);
            this.Controls.Add(this.LiBoxRightDeck);
            this.Controls.Add(this.LiBoxLeftDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LiBoxLeftDeck;
        private System.Windows.Forms.ListBox LiBoxRightDeck;
        private System.Windows.Forms.Button BtnMoveLeftToRight;
        private System.Windows.Forms.Button BtnMoveRightToLeft;
        private System.Windows.Forms.Button BtnResetDeck1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnShuffleDeck1;
        private System.Windows.Forms.Button BtnShuffleDeck2;
    }
}

