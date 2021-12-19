namespace HomeWork03Assignment02
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSaveXML = new System.Windows.Forms.Button();
            this.btSaveText = new System.Windows.Forms.Button();
            this.btAddEdit = new System.Windows.Forms.Button();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialogTXT = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogXML = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btSaveXML);
            this.splitContainer1.Panel2.Controls.Add(this.btSaveText);
            this.splitContainer1.Panel2.Controls.Add(this.btAddEdit);
            this.splitContainer1.Panel2.Controls.Add(this.tbEMail);
            this.splitContainer1.Panel2.Controls.Add(this.mtbPhone);
            this.splitContainer1.Panel2.Controls.Add(this.tbFirstName);
            this.splitContainer1.Panel2.Controls.Add(this.tbName);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1582, 815);
            this.splitContainer1.SplitterDistance = 596;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1582, 596);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(786, 64);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(150, 46);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Видалити";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSaveXML
            // 
            this.btSaveXML.Location = new System.Drawing.Point(1272, 62);
            this.btSaveXML.Name = "btSaveXML";
            this.btSaveXML.Size = new System.Drawing.Size(298, 46);
            this.btSaveXML.TabIndex = 11;
            this.btSaveXML.Text = "Зберегти як XML";
            this.btSaveXML.UseVisualStyleBackColor = true;
            this.btSaveXML.Click += new System.EventHandler(this.btSaveXML_Click);
            // 
            // btSaveText
            // 
            this.btSaveText.Location = new System.Drawing.Point(1272, 9);
            this.btSaveText.Name = "btSaveText";
            this.btSaveText.Size = new System.Drawing.Size(298, 46);
            this.btSaveText.TabIndex = 10;
            this.btSaveText.Text = "Зберегти як текст";
            this.btSaveText.UseVisualStyleBackColor = true;
            this.btSaveText.Click += new System.EventHandler(this.button2_Click);
            // 
            // btAddEdit
            // 
            this.btAddEdit.Enabled = false;
            this.btAddEdit.Location = new System.Drawing.Point(786, 12);
            this.btAddEdit.Name = "btAddEdit";
            this.btAddEdit.Size = new System.Drawing.Size(150, 46);
            this.btAddEdit.TabIndex = 9;
            this.btAddEdit.Text = "Додати";
            this.btAddEdit.UseVisualStyleBackColor = true;
            this.btAddEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEMail
            // 
            this.tbEMail.ForeColor = System.Drawing.Color.Red;
            this.tbEMail.Location = new System.Drawing.Point(223, 109);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(528, 39);
            this.tbEMail.TabIndex = 6;
            this.tbEMail.TextChanged += new System.EventHandler(this.tbEMail_TextChanged);
            // 
            // mtbPhone
            // 
            this.mtbPhone.ForeColor = System.Drawing.Color.Red;
            this.mtbPhone.Location = new System.Drawing.Point(223, 159);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(528, 39);
            this.mtbPhone.TabIndex = 7;
            this.mtbPhone.TextChanged += new System.EventHandler(this.mtbPhone_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(223, 59);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(528, 39);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(223, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(528, 39);
            this.tbName.TabIndex = 4;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "e-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // saveFileDialogTXT
            // 
            this.saveFileDialogTXT.Filter = "Text files|*.txt|All files|*.*";
            // 
            // saveFileDialogXML
            // 
            this.saveFileDialogXML.Filter = "XML files|*.xml|All files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 815);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox listBox1;
        private MaskedTextBox mtbPhone;
        private TextBox tbFirstName;
        private TextBox tbName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btSaveText;
        private Button btAddEdit;
        private TextBox tbEMail;
        private Button btSaveXML;
        private Button btDelete;
        private SaveFileDialog saveFileDialogTXT;
        private SaveFileDialog saveFileDialogXML;
        private SaveFileDialog saveFileDialog1;
    }
}