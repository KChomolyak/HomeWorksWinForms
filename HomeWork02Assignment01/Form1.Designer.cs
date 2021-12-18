namespace HomeWork02Assignment01
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
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbSurName = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbFamily = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.cbFamily = new System.Windows.Forms.ComboBox();
            this.tbAdditionalInfo = new System.Windows.Forms.TextBox();
            this.lbAdditionInfo = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(12, 21);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(122, 32);
            this.lbLastName.TabIndex = 0;
            this.lbLastName.Text = "Прізвище";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 66);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(55, 32);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "Ім\'я";
            // 
            // lbSurName
            // 
            this.lbSurName.AutoSize = true;
            this.lbSurName.Location = new System.Drawing.Point(12, 111);
            this.lbSurName.Name = "lbSurName";
            this.lbSurName.Size = new System.Drawing.Size(148, 32);
            this.lbSurName.TabIndex = 2;
            this.lbSurName.Text = "По-батькові";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(12, 156);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(73, 32);
            this.lbSex.TabIndex = 3;
            this.lbSex.Text = "Стать";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(12, 203);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(210, 32);
            this.lbBirthDate.TabIndex = 4;
            this.lbBirthDate.Text = "Дата народження";
            // 
            // lbFamily
            // 
            this.lbFamily.AutoSize = true;
            this.lbFamily.Location = new System.Drawing.Point(12, 246);
            this.lbFamily.Name = "lbFamily";
            this.lbFamily.Size = new System.Drawing.Size(175, 32);
            this.lbFamily.TabIndex = 5;
            this.lbFamily.Text = "Сімейний стан";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(340, 18);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(328, 39);
            this.tbFirstName.TabIndex = 6;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(340, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(328, 39);
            this.tbName.TabIndex = 7;
            this.tbName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbSurName
            // 
            this.tbSurName.Location = new System.Drawing.Point(340, 108);
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(328, 39);
            this.tbSurName.TabIndex = 8;
            this.tbSurName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.cbSex.Location = new System.Drawing.Point(340, 153);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(328, 40);
            this.cbSex.TabIndex = 9;
            this.cbSex.Text = "Виберіть...";
            this.cbSex.SelectedIndexChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(340, 198);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(328, 39);
            this.dtpBirthDay.TabIndex = 10;
            this.dtpBirthDay.ValueChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // cbFamily
            // 
            this.cbFamily.FormattingEnabled = true;
            this.cbFamily.Items.AddRange(new object[] {
            "одружений/заміжня",
            "неодружений/незаміжня"});
            this.cbFamily.Location = new System.Drawing.Point(340, 243);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(328, 40);
            this.cbFamily.TabIndex = 11;
            this.cbFamily.Text = "Виберіть...";
            this.cbFamily.SelectedIndexChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbAdditionalInfo
            // 
            this.tbAdditionalInfo.Location = new System.Drawing.Point(340, 288);
            this.tbAdditionalInfo.Name = "tbAdditionalInfo";
            this.tbAdditionalInfo.Size = new System.Drawing.Size(328, 39);
            this.tbAdditionalInfo.TabIndex = 12;
            // 
            // lbAdditionInfo
            // 
            this.lbAdditionInfo.AutoSize = true;
            this.lbAdditionInfo.Location = new System.Drawing.Point(12, 291);
            this.lbAdditionInfo.Name = "lbAdditionInfo";
            this.lbAdditionInfo.Size = new System.Drawing.Size(263, 32);
            this.lbAdditionInfo.TabIndex = 13;
            this.lbAdditionInfo.Text = "Додаткова інформація";
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(263, 351);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(150, 46);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Зберегти";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 409);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbAdditionInfo);
            this.Controls.Add(this.tbAdditionalInfo);
            this.Controls.Add(this.cbFamily);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbSurName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFamily);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbSurName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbLastName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbLastName;
        private Label lbFirstName;
        private Label lbSurName;
        private Label lbSex;
        private Label lbBirthDate;
        private Label lbFamily;
        private TextBox tbFirstName;
        private TextBox tbName;
        private TextBox tbSurName;
        private ComboBox cbSex;
        private DateTimePicker dtpBirthDay;
        private ComboBox cbFamily;
        private TextBox tbAdditionalInfo;
        private Label lbAdditionInfo;
        private Button btSave;
        private SaveFileDialog saveFileDialog1;
    }
}