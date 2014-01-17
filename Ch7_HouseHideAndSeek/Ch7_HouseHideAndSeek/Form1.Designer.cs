namespace Ch7_HouseHideAndSeek
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
            this.LblCurrentLocation = new System.Windows.Forms.Label();
            this.TxtBoxCurrLocDescription = new System.Windows.Forms.TextBox();
            this.BtnGoToLocation = new System.Windows.Forms.Button();
            this.CboxExits = new System.Windows.Forms.ComboBox();
            this.BtnGoThroughDoor = new System.Windows.Forms.Button();
            this.BtnCheckHidingPlace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBoxGameStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCurrentLocation
            // 
            this.LblCurrentLocation.AutoSize = true;
            this.LblCurrentLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentLocation.Location = new System.Drawing.Point(23, 17);
            this.LblCurrentLocation.Name = "LblCurrentLocation";
            this.LblCurrentLocation.Size = new System.Drawing.Size(101, 16);
            this.LblCurrentLocation.TabIndex = 0;
            this.LblCurrentLocation.Text = "You are in the ...";
            // 
            // TxtBoxCurrLocDescription
            // 
            this.TxtBoxCurrLocDescription.Location = new System.Drawing.Point(26, 46);
            this.TxtBoxCurrLocDescription.Multiline = true;
            this.TxtBoxCurrLocDescription.Name = "TxtBoxCurrLocDescription";
            this.TxtBoxCurrLocDescription.Size = new System.Drawing.Size(225, 117);
            this.TxtBoxCurrLocDescription.TabIndex = 1;
            // 
            // BtnGoToLocation
            // 
            this.BtnGoToLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGoToLocation.Location = new System.Drawing.Point(26, 189);
            this.BtnGoToLocation.Name = "BtnGoToLocation";
            this.BtnGoToLocation.Size = new System.Drawing.Size(79, 21);
            this.BtnGoToLocation.TabIndex = 2;
            this.BtnGoToLocation.Text = "Go here ...";
            this.BtnGoToLocation.UseVisualStyleBackColor = true;
            this.BtnGoToLocation.Click += new System.EventHandler(this.BtnGoToLocation_Click);
            // 
            // CboxExits
            // 
            this.CboxExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxExits.FormattingEnabled = true;
            this.CboxExits.Location = new System.Drawing.Point(127, 189);
            this.CboxExits.Name = "CboxExits";
            this.CboxExits.Size = new System.Drawing.Size(391, 21);
            this.CboxExits.TabIndex = 3;
            // 
            // BtnGoThroughDoor
            // 
            this.BtnGoThroughDoor.Location = new System.Drawing.Point(26, 222);
            this.BtnGoThroughDoor.Name = "BtnGoThroughDoor";
            this.BtnGoThroughDoor.Size = new System.Drawing.Size(492, 21);
            this.BtnGoThroughDoor.TabIndex = 4;
            this.BtnGoThroughDoor.Text = "Go through the door";
            this.BtnGoThroughDoor.UseVisualStyleBackColor = true;
            this.BtnGoThroughDoor.Click += new System.EventHandler(this.BtnGoThroughDoor_Click);
            // 
            // BtnCheckHidingPlace
            // 
            this.BtnCheckHidingPlace.Location = new System.Drawing.Point(26, 275);
            this.BtnCheckHidingPlace.Name = "BtnCheckHidingPlace";
            this.BtnCheckHidingPlace.Size = new System.Drawing.Size(492, 21);
            this.BtnCheckHidingPlace.TabIndex = 5;
            this.BtnCheckHidingPlace.Text = "Check hiding place ...";
            this.BtnCheckHidingPlace.UseVisualStyleBackColor = true;
            this.BtnCheckHidingPlace.Click += new System.EventHandler(this.BtnCheckHidingPlace_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(492, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "HIDE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBoxGameStatus
            // 
            this.TxtBoxGameStatus.Location = new System.Drawing.Point(293, 46);
            this.TxtBoxGameStatus.Multiline = true;
            this.TxtBoxGameStatus.Name = "TxtBoxGameStatus";
            this.TxtBoxGameStatus.Size = new System.Drawing.Size(225, 117);
            this.TxtBoxGameStatus.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 402);
            this.Controls.Add(this.TxtBoxGameStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCheckHidingPlace);
            this.Controls.Add(this.BtnGoThroughDoor);
            this.Controls.Add(this.CboxExits);
            this.Controls.Add(this.BtnGoToLocation);
            this.Controls.Add(this.TxtBoxCurrLocDescription);
            this.Controls.Add(this.LblCurrentLocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCurrentLocation;
        private System.Windows.Forms.TextBox TxtBoxCurrLocDescription;
        private System.Windows.Forms.Button BtnGoToLocation;
        private System.Windows.Forms.ComboBox CboxExits;
        private System.Windows.Forms.Button BtnGoThroughDoor;
        private System.Windows.Forms.Button BtnCheckHidingPlace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtBoxGameStatus;
    }
}

