namespace Assignment02
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
            this.tbMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMyNumber = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btRetry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мінімальне значення:";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(474, 41);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(140, 39);
            this.tbMin.TabIndex = 1;
            this.tbMin.Text = "1";
            this.tbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMin.TextChanged += new System.EventHandler(this.tbMin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Максимальне значення:";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(474, 90);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(140, 39);
            this.tbMax.TabIndex = 3;
            this.tbMax.Text = "2000";
            this.tbMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMax.TextChanged += new System.EventHandler(this.tbMax_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введіть число у вказаному діапазоні";
            // 
            // tbMyNumber
            // 
            this.tbMyNumber.Location = new System.Drawing.Point(474, 198);
            this.tbMyNumber.Name = "tbMyNumber";
            this.tbMyNumber.Size = new System.Drawing.Size(140, 39);
            this.tbMyNumber.TabIndex = 5;
            this.tbMyNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMyNumber.TextChanged += new System.EventHandler(this.tbMyNumber_TextChanged);
            // 
            // btStart
            // 
            this.btStart.Enabled = false;
            this.btStart.Location = new System.Drawing.Point(209, 334);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(150, 46);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Почати";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btRetry
            // 
            this.btRetry.Enabled = false;
            this.btRetry.Location = new System.Drawing.Point(401, 334);
            this.btRetry.Name = "btRetry";
            this.btRetry.Size = new System.Drawing.Size(150, 46);
            this.btRetry.TabIndex = 7;
            this.btRetry.Text = "Ще раз";
            this.btRetry.UseVisualStyleBackColor = true;
            this.btRetry.Click += new System.EventHandler(this.btRetry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRetry);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbMyNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbMin;
        private Label label2;
        private TextBox tbMax;
        private Label label3;
        private TextBox tbMyNumber;
        private Button btStart;
        private Button btRetry;
    }
}