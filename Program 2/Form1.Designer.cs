namespace Program_2
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
            this.guests = new System.Windows.Forms.Label();
            this.nights = new System.Windows.Forms.Label();
            this.stars = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.nightsTxt = new System.Windows.Forms.TextBox();
            this.guestsTxt = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.Label();
            this.costLbL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guests
            // 
            this.guests.AutoSize = true;
            this.guests.Location = new System.Drawing.Point(124, 66);
            this.guests.Name = "guests";
            this.guests.Size = new System.Drawing.Size(95, 13);
            this.guests.TabIndex = 0;
            this.guests.Text = "Number of Guests:";
            // 
            // nights
            // 
            this.nights.AutoSize = true;
            this.nights.Location = new System.Drawing.Point(127, 91);
            this.nights.Name = "nights";
            this.nights.Size = new System.Drawing.Size(92, 13);
            this.nights.TabIndex = 1;
            this.nights.Text = "Number of Nights:";
            // 
            // stars
            // 
            this.stars.AutoSize = true;
            this.stars.Location = new System.Drawing.Point(157, 118);
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(62, 13);
            this.stars.TabIndex = 2;
            this.stars.Text = "Hotel Stars:";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxName.Location = new System.Drawing.Point(225, 115);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(83, 21);
            this.comboBoxName.TabIndex = 3;
            // 
            // nightsTxt
            // 
            this.nightsTxt.Location = new System.Drawing.Point(225, 88);
            this.nightsTxt.Name = "nightsTxt";
            this.nightsTxt.Size = new System.Drawing.Size(83, 20);
            this.nightsTxt.TabIndex = 4;
            // 
            // guestsTxt
            // 
            this.guestsTxt.Location = new System.Drawing.Point(225, 62);
            this.guestsTxt.Name = "guestsTxt";
            this.guestsTxt.Size = new System.Drawing.Size(83, 20);
            this.guestsTxt.TabIndex = 5;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(192, 157);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(160, 211);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(59, 13);
            this.cost.TabIndex = 7;
            this.cost.Text = "Hotel Cost:";
            // 
            // costLbL
            // 
            this.costLbL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLbL.Location = new System.Drawing.Point(225, 210);
            this.costLbL.Name = "costLbL";
            this.costLbL.Size = new System.Drawing.Size(83, 20);
            this.costLbL.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 302);
            this.Controls.Add(this.costLbL);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.guestsTxt);
            this.Controls.Add(this.nightsTxt);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.stars);
            this.Controls.Add(this.nights);
            this.Controls.Add(this.guests);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guests;
        private System.Windows.Forms.Label nights;
        private System.Windows.Forms.Label stars;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.TextBox nightsTxt;
        private System.Windows.Forms.TextBox guestsTxt;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label costLbL;
    }
}

