﻿namespace Assignment04
{
    partial class Assignment04Form
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
            this.SuspendLayout();
            // 
            // Assignment04Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Assignment04Form";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Assignment04Form_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Assignment04Form_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Assignment04Form_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Assignment04Form_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}