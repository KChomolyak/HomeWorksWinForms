namespace Assignment01
{
    partial class Assignment01Form
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
            this.btResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btResume
            // 
            this.btResume.Location = new System.Drawing.Point(293, 166);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(255, 46);
            this.btResume.TabIndex = 0;
            this.btResume.Text = "Вывести резюме";
            this.btResume.UseVisualStyleBackColor = true;
            this.btResume.Click += new System.EventHandler(this.btResume_Click);
            // 
            // Assignment01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btResume);
            this.Name = "Assignment01Form";
            this.Text = "Задание 1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btResume;
    }
}