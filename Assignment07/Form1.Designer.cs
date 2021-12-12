namespace Assignment07
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSeconds = new System.Windows.Forms.RadioButton();
            this.rbMinutes = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть дату:";
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(200, 36);
            this.mtbDate.Mask = "00/00/0000 90:00";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(200, 39);
            this.mtbDate.TabIndex = 1;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            this.mtbDate.TextChanged += new System.EventHandler(this.mtbDate_TextChanged);
            this.mtbDate.Leave += new System.EventHandler(this.mtbDate_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSeconds);
            this.groupBox1.Controls.Add(this.rbMinutes);
            this.groupBox1.Controls.Add(this.rbDay);
            this.groupBox1.Controls.Add(this.rbMonth);
            this.groupBox1.Controls.Add(this.rbYear);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(50, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вивести результат в ";
            // 
            // rbSeconds
            // 
            this.rbSeconds.AutoSize = true;
            this.rbSeconds.Location = new System.Drawing.Point(33, 200);
            this.rbSeconds.Name = "rbSeconds";
            this.rbSeconds.Size = new System.Drawing.Size(143, 36);
            this.rbSeconds.TabIndex = 4;
            this.rbSeconds.TabStop = true;
            this.rbSeconds.Text = "секундах";
            this.rbSeconds.UseVisualStyleBackColor = true;
            this.rbSeconds.CheckedChanged += new System.EventHandler(this.rbSeconds_CheckedChanged);
            // 
            // rbMinutes
            // 
            this.rbMinutes.AutoSize = true;
            this.rbMinutes.Location = new System.Drawing.Point(33, 160);
            this.rbMinutes.Name = "rbMinutes";
            this.rbMinutes.Size = new System.Drawing.Size(147, 36);
            this.rbMinutes.TabIndex = 3;
            this.rbMinutes.TabStop = true;
            this.rbMinutes.Text = "хвилинах";
            this.rbMinutes.UseVisualStyleBackColor = true;
            this.rbMinutes.CheckedChanged += new System.EventHandler(this.rbMinutes_CheckedChanged);
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(33, 120);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(95, 36);
            this.rbDay.TabIndex = 2;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "днях";
            this.rbDay.UseVisualStyleBackColor = true;
            this.rbDay.CheckedChanged += new System.EventHandler(this.rbDay_CheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(33, 80);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(128, 36);
            this.rbMonth.TabIndex = 1;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "місяцях";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(33, 40);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(108, 36);
            this.rbYear.TabIndex = 0;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "роках";
            this.rbYear.UseVisualStyleBackColor = true;
            this.rbYear.CheckedChanged += new System.EventHandler(this.rbYear_CheckedChanged);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(40, 369);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 32);
            this.lbResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox mtbDate;
        private GroupBox groupBox1;
        private RadioButton rbSeconds;
        private RadioButton rbMinutes;
        private RadioButton rbDay;
        private RadioButton rbMonth;
        private RadioButton rbYear;
        private Label lbResult;
    }
}