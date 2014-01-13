namespace _03Guys
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
            this.FirstPersonLabel = new System.Windows.Forms.Label();
            this.SecondPersonLabel = new System.Windows.Forms.Label();
            this.BankLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstPersonLabel
            // 
            this.FirstPersonLabel.AutoSize = true;
            this.FirstPersonLabel.Location = new System.Drawing.Point(23, 26);
            this.FirstPersonLabel.Name = "FirstPersonLabel";
            this.FirstPersonLabel.Size = new System.Drawing.Size(46, 13);
            this.FirstPersonLabel.TabIndex = 0;
            this.FirstPersonLabel.Text = "Bob has";
            // 
            // SecondPersonLabel
            // 
            this.SecondPersonLabel.AutoSize = true;
            this.SecondPersonLabel.Location = new System.Drawing.Point(23, 58);
            this.SecondPersonLabel.Name = "SecondPersonLabel";
            this.SecondPersonLabel.Size = new System.Drawing.Size(44, 13);
            this.SecondPersonLabel.TabIndex = 1;
            this.SecondPersonLabel.Text = "Joe has";
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Location = new System.Drawing.Point(23, 93);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(52, 13);
            this.BankLabel.TabIndex = 2;
            this.BankLabel.Text = "Bank has";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give £10 to 1st";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive £5 from 2nd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BankLabel);
            this.Controls.Add(this.SecondPersonLabel);
            this.Controls.Add(this.FirstPersonLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstPersonLabel;
        private System.Windows.Forms.Label SecondPersonLabel;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

