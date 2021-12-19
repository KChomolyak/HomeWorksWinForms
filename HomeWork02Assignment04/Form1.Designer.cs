namespace HomeWork02Assignment04
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
            this.tbDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(32, 46);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(54, 39);
            this.tbDay.TabIndex = 0;
            this.tbDay.TextChanged += new System.EventHandler(this.tbDay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(182, 46);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(68, 39);
            this.tbYear.TabIndex = 2;
            this.tbYear.TextChanged += new System.EventHandler(this.tbDay_TextChanged);
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(108, 46);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(54, 39);
            this.tbMonth.TabIndex = 1;
            this.tbMonth.TextChanged += new System.EventHandler(this.tbDay_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = ".";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(294, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbDay;
        private Label label1;
        private TextBox tbYear;
        private TextBox tbMonth;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private Label label3;
    }
}