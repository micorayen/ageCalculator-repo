namespace Age_Calculator
{
    partial class Enter_dates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter_dates));
            this.dtp_bdate = new System.Windows.Forms.DateTimePicker();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_bdate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_bdate
            // 
            this.dtp_bdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_bdate.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtp_bdate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtp_bdate.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtp_bdate.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtp_bdate.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtp_bdate.Checked = false;
            this.dtp_bdate.CustomFormat = "Month/dd/yyyy";
            this.dtp_bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_bdate.Location = new System.Drawing.Point(104, 74);
            this.dtp_bdate.Margin = new System.Windows.Forms.Padding(0);
            this.dtp_bdate.Name = "dtp_bdate";
            this.dtp_bdate.Size = new System.Drawing.Size(199, 24);
            this.dtp_bdate.TabIndex = 0;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(69)))), ((int)(((byte)(180)))));
            this.btn_calculate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.ForeColor = System.Drawing.Color.White;
            this.btn_calculate.Location = new System.Drawing.Point(17, 121);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(286, 37);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "CALCULATE";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_bdate
            // 
            this.lbl_bdate.AutoSize = true;
            this.lbl_bdate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_bdate.Location = new System.Drawing.Point(14, 77);
            this.lbl_bdate.Name = "lbl_bdate";
            this.lbl_bdate.Size = new System.Drawing.Size(84, 18);
            this.lbl_bdate.TabIndex = 5;
            this.lbl_bdate.Text = "Birth Date:";
            this.lbl_bdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(69)))), ((int)(((byte)(180)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(311, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Enter_dates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(341, 185);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_bdate);
            this.Controls.Add(this.dtp_bdate);
            this.Controls.Add(this.btn_calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Enter_dates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_bdate;
        public System.Windows.Forms.DateTimePicker dtp_bdate;
        private System.Windows.Forms.Button button1;
    }
}