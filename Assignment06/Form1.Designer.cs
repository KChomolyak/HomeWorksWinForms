namespace Assignment06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbYear = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(64, 40);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(45, 32);
            this.lbYear.TabIndex = 0;
            this.lbYear.Text = "Рік";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(64, 90);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(91, 32);
            this.lbMonth.TabIndex = 1;
            this.lbMonth.Text = "Місяць";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(64, 140);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(70, 32);
            this.lbDay.TabIndex = 2;
            this.lbDay.Text = "День";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(64, 240);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 32);
            this.lbResult.TabIndex = 3;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(173, 37);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(136, 40);
            this.cbYear.TabIndex = 4;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cbMonth
            // 
            this.cbMonth.Enabled = false;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(173, 87);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(242, 40);
            this.cbMonth.TabIndex = 5;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // cbDay
            // 
            this.cbDay.Enabled = false;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(173, 137);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(136, 40);
            this.cbDay.TabIndex = 6;
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 309);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbYear;
        private Label lbMonth;
        private Label lbDay;
        private Label lbResult;
        private ComboBox cbYear;
        private ComboBox cbMonth;
        private ComboBox cbDay;
    }
}