namespace Assignment08
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTotalOil = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalCafe = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.pTotal = new System.Windows.Forms.Panel();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.lbTotalPay = new System.Windows.Forms.Label();
            this.pOil = new System.Windows.Forms.Panel();
            this.gbOil = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbOilPay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGrn = new System.Windows.Forms.TextBox();
            this.tbLitr = new System.Windows.Forms.TextBox();
            this.rbGrn = new System.Windows.Forms.RadioButton();
            this.rbLitr = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOilPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOilType = new System.Windows.Forms.ComboBox();
            this.lbOilType = new System.Windows.Forms.Label();
            this.pCafe = new System.Windows.Forms.Panel();
            this.gbCafe = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbCafePay = new System.Windows.Forms.Label();
            this.tbCocaColaCount = new System.Windows.Forms.TextBox();
            this.tbCocaColaPrice = new System.Windows.Forms.TextBox();
            this.cbCocaCola = new System.Windows.Forms.CheckBox();
            this.tbFreeCount = new System.Windows.Forms.TextBox();
            this.tbFreePrice = new System.Windows.Forms.TextBox();
            this.cbFree = new System.Windows.Forms.CheckBox();
            this.tbGamburgerCount = new System.Windows.Forms.TextBox();
            this.tbGamburgerPrice = new System.Windows.Forms.TextBox();
            this.cbGamburger = new System.Windows.Forms.CheckBox();
            this.tbHotDogCount = new System.Windows.Forms.TextBox();
            this.tbHodDogPrice = new System.Windows.Forms.TextBox();
            this.cbHotDog = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.pTotal.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.pOil.SuspendLayout();
            this.gbOil.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pCafe.SuspendLayout();
            this.gbCafe.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalOil,
            this.tsslTotalCafe,
            this.tsslTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 774);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1340, 42);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTotalOil
            // 
            this.tsslTotalOil.Name = "tsslTotalOil";
            this.tsslTotalOil.Size = new System.Drawing.Size(237, 32);
            this.tsslTotalOil.Text = "toolStripStatusLabel1";
            // 
            // tsslTotalCafe
            // 
            this.tsslTotalCafe.Name = "tsslTotalCafe";
            this.tsslTotalCafe.Size = new System.Drawing.Size(237, 32);
            this.tsslTotalCafe.Text = "toolStripStatusLabel2";
            // 
            // tsslTotal
            // 
            this.tsslTotal.Name = "tsslTotal";
            this.tsslTotal.Size = new System.Drawing.Size(237, 32);
            this.tsslTotal.Text = "toolStripStatusLabel3";
            // 
            // pTotal
            // 
            this.pTotal.Controls.Add(this.gbTotal);
            this.pTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pTotal.Location = new System.Drawing.Point(0, 574);
            this.pTotal.Name = "pTotal";
            this.pTotal.Size = new System.Drawing.Size(1340, 200);
            this.pTotal.TabIndex = 1;
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.lbTotalPay);
            this.gbTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTotal.Location = new System.Drawing.Point(0, 0);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(1340, 200);
            this.gbTotal.TabIndex = 0;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Всього до оплати";
            // 
            // lbTotalPay
            // 
            this.lbTotalPay.AutoSize = true;
            this.lbTotalPay.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPay.ForeColor = System.Drawing.Color.Green;
            this.lbTotalPay.Location = new System.Drawing.Point(574, 82);
            this.lbTotalPay.Name = "lbTotalPay";
            this.lbTotalPay.Size = new System.Drawing.Size(0, 59);
            this.lbTotalPay.TabIndex = 0;
            // 
            // pOil
            // 
            this.pOil.Controls.Add(this.gbOil);
            this.pOil.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOil.Location = new System.Drawing.Point(0, 0);
            this.pOil.Name = "pOil";
            this.pOil.Size = new System.Drawing.Size(667, 574);
            this.pOil.TabIndex = 2;
            // 
            // gbOil
            // 
            this.gbOil.Controls.Add(this.groupBox2);
            this.gbOil.Controls.Add(this.groupBox1);
            this.gbOil.Controls.Add(this.label2);
            this.gbOil.Controls.Add(this.tbOilPrice);
            this.gbOil.Controls.Add(this.label1);
            this.gbOil.Controls.Add(this.cbOilType);
            this.gbOil.Controls.Add(this.lbOilType);
            this.gbOil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOil.Location = new System.Drawing.Point(0, 0);
            this.gbOil.Name = "gbOil";
            this.gbOil.Size = new System.Drawing.Size(667, 574);
            this.gbOil.TabIndex = 0;
            this.gbOil.TabStop = false;
            this.gbOil.Text = "Автозаправка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbOilPay);
            this.groupBox2.Location = new System.Drawing.Point(33, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "До оплати";
            // 
            // lbOilPay
            // 
            this.lbOilPay.AutoSize = true;
            this.lbOilPay.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOilPay.ForeColor = System.Drawing.Color.Green;
            this.lbOilPay.Location = new System.Drawing.Point(218, 35);
            this.lbOilPay.Name = "lbOilPay";
            this.lbOilPay.Size = new System.Drawing.Size(0, 50);
            this.lbOilPay.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbGrn);
            this.groupBox1.Controls.Add(this.tbLitr);
            this.groupBox1.Controls.Add(this.rbGrn);
            this.groupBox1.Controls.Add(this.rbLitr);
            this.groupBox1.Location = new System.Drawing.Point(33, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "грн.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "л.";
            // 
            // tbGrn
            // 
            this.tbGrn.Enabled = false;
            this.tbGrn.Location = new System.Drawing.Point(218, 89);
            this.tbGrn.Name = "tbGrn";
            this.tbGrn.Size = new System.Drawing.Size(200, 39);
            this.tbGrn.TabIndex = 3;
            this.tbGrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGrn.TextChanged += new System.EventHandler(this.tbGrn_TextChanged);
            // 
            // tbLitr
            // 
            this.tbLitr.Location = new System.Drawing.Point(218, 36);
            this.tbLitr.Name = "tbLitr";
            this.tbLitr.Size = new System.Drawing.Size(200, 39);
            this.tbLitr.TabIndex = 2;
            this.tbLitr.Text = "0";
            this.tbLitr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLitr.TextChanged += new System.EventHandler(this.tbLitr_TextChanged);
            // 
            // rbGrn
            // 
            this.rbGrn.AutoSize = true;
            this.rbGrn.Location = new System.Drawing.Point(25, 90);
            this.rbGrn.Name = "rbGrn";
            this.rbGrn.Size = new System.Drawing.Size(101, 36);
            this.rbGrn.TabIndex = 1;
            this.rbGrn.TabStop = true;
            this.rbGrn.Text = "Сума";
            this.rbGrn.UseVisualStyleBackColor = true;
            this.rbGrn.CheckedChanged += new System.EventHandler(this.rbGrn_CheckedChanged);
            // 
            // rbLitr
            // 
            this.rbLitr.AutoSize = true;
            this.rbLitr.Checked = true;
            this.rbLitr.Location = new System.Drawing.Point(25, 38);
            this.rbLitr.Name = "rbLitr";
            this.rbLitr.Size = new System.Drawing.Size(141, 36);
            this.rbLitr.TabIndex = 0;
            this.rbLitr.TabStop = true;
            this.rbLitr.Text = "Кількість";
            this.rbLitr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "грн.";
            // 
            // tbOilPrice
            // 
            this.tbOilPrice.Location = new System.Drawing.Point(251, 181);
            this.tbOilPrice.Name = "tbOilPrice";
            this.tbOilPrice.Size = new System.Drawing.Size(200, 39);
            this.tbOilPrice.TabIndex = 3;
            this.tbOilPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ціна за літр";
            // 
            // cbOilType
            // 
            this.cbOilType.FormattingEnabled = true;
            this.cbOilType.Items.AddRange(new object[] {
            "Бензин 76",
            "Бензин 92",
            "Бензин 95",
            "Бензин 98",
            "Дизель",
            "Дизель плюс"});
            this.cbOilType.Location = new System.Drawing.Point(251, 74);
            this.cbOilType.Name = "cbOilType";
            this.cbOilType.Size = new System.Drawing.Size(242, 40);
            this.cbOilType.TabIndex = 1;
            this.cbOilType.Text = "Бензин 95";
            this.cbOilType.SelectedIndexChanged += new System.EventHandler(this.cbOilType_SelectedIndexChanged);
            // 
            // lbOilType
            // 
            this.lbOilType.AutoSize = true;
            this.lbOilType.Location = new System.Drawing.Point(58, 77);
            this.lbOilType.Name = "lbOilType";
            this.lbOilType.Size = new System.Drawing.Size(164, 32);
            this.lbOilType.TabIndex = 0;
            this.lbOilType.Text = "Тип пального";
            // 
            // pCafe
            // 
            this.pCafe.Controls.Add(this.gbCafe);
            this.pCafe.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCafe.Location = new System.Drawing.Point(673, 0);
            this.pCafe.Name = "pCafe";
            this.pCafe.Size = new System.Drawing.Size(667, 574);
            this.pCafe.TabIndex = 3;
            // 
            // gbCafe
            // 
            this.gbCafe.Controls.Add(this.groupBox3);
            this.gbCafe.Controls.Add(this.tbCocaColaCount);
            this.gbCafe.Controls.Add(this.tbCocaColaPrice);
            this.gbCafe.Controls.Add(this.cbCocaCola);
            this.gbCafe.Controls.Add(this.tbFreeCount);
            this.gbCafe.Controls.Add(this.tbFreePrice);
            this.gbCafe.Controls.Add(this.cbFree);
            this.gbCafe.Controls.Add(this.tbGamburgerCount);
            this.gbCafe.Controls.Add(this.tbGamburgerPrice);
            this.gbCafe.Controls.Add(this.cbGamburger);
            this.gbCafe.Controls.Add(this.tbHotDogCount);
            this.gbCafe.Controls.Add(this.tbHodDogPrice);
            this.gbCafe.Controls.Add(this.cbHotDog);
            this.gbCafe.Controls.Add(this.label7);
            this.gbCafe.Controls.Add(this.label6);
            this.gbCafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCafe.Location = new System.Drawing.Point(0, 0);
            this.gbCafe.Name = "gbCafe";
            this.gbCafe.Size = new System.Drawing.Size(667, 574);
            this.gbCafe.TabIndex = 0;
            this.gbCafe.TabStop = false;
            this.gbCafe.Text = "Міні-кафе";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbCafePay);
            this.groupBox3.Location = new System.Drawing.Point(27, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 105);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "До оплати";
            // 
            // lbCafePay
            // 
            this.lbCafePay.AutoSize = true;
            this.lbCafePay.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCafePay.ForeColor = System.Drawing.Color.Green;
            this.lbCafePay.Location = new System.Drawing.Point(249, 35);
            this.lbCafePay.Name = "lbCafePay";
            this.lbCafePay.Size = new System.Drawing.Size(0, 50);
            this.lbCafePay.TabIndex = 0;
            // 
            // tbCocaColaCount
            // 
            this.tbCocaColaCount.Enabled = false;
            this.tbCocaColaCount.Location = new System.Drawing.Point(487, 302);
            this.tbCocaColaCount.Name = "tbCocaColaCount";
            this.tbCocaColaCount.Size = new System.Drawing.Size(154, 39);
            this.tbCocaColaCount.TabIndex = 13;
            this.tbCocaColaCount.Text = "0";
            this.tbCocaColaCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCocaColaCount.TextChanged += new System.EventHandler(this.tbHotDogCount_TextChanged);
            // 
            // tbCocaColaPrice
            // 
            this.tbCocaColaPrice.Enabled = false;
            this.tbCocaColaPrice.Location = new System.Drawing.Point(315, 301);
            this.tbCocaColaPrice.Name = "tbCocaColaPrice";
            this.tbCocaColaPrice.Size = new System.Drawing.Size(126, 39);
            this.tbCocaColaPrice.TabIndex = 12;
            this.tbCocaColaPrice.Text = "4,40";
            this.tbCocaColaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbCocaCola
            // 
            this.cbCocaCola.AutoSize = true;
            this.cbCocaCola.Location = new System.Drawing.Point(55, 302);
            this.cbCocaCola.Name = "cbCocaCola";
            this.cbCocaCola.Size = new System.Drawing.Size(159, 36);
            this.cbCocaCola.TabIndex = 11;
            this.cbCocaCola.Text = "Кока-кола";
            this.cbCocaCola.UseVisualStyleBackColor = true;
            this.cbCocaCola.CheckedChanged += new System.EventHandler(this.cbCocaCola_CheckedChanged);
            // 
            // tbFreeCount
            // 
            this.tbFreeCount.Enabled = false;
            this.tbFreeCount.Location = new System.Drawing.Point(487, 239);
            this.tbFreeCount.Name = "tbFreeCount";
            this.tbFreeCount.Size = new System.Drawing.Size(154, 39);
            this.tbFreeCount.TabIndex = 10;
            this.tbFreeCount.Text = "0";
            this.tbFreeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFreeCount.TextChanged += new System.EventHandler(this.tbHotDogCount_TextChanged);
            // 
            // tbFreePrice
            // 
            this.tbFreePrice.Enabled = false;
            this.tbFreePrice.Location = new System.Drawing.Point(315, 240);
            this.tbFreePrice.Name = "tbFreePrice";
            this.tbFreePrice.Size = new System.Drawing.Size(126, 39);
            this.tbFreePrice.TabIndex = 9;
            this.tbFreePrice.Text = "7,20";
            this.tbFreePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbFree
            // 
            this.cbFree.AutoSize = true;
            this.cbFree.Location = new System.Drawing.Point(55, 242);
            this.cbFree.Name = "cbFree";
            this.cbFree.Size = new System.Drawing.Size(221, 36);
            this.cbFree.TabIndex = 8;
            this.cbFree.Text = "Картопопля Фрі";
            this.cbFree.UseVisualStyleBackColor = true;
            this.cbFree.CheckedChanged += new System.EventHandler(this.cbFree_CheckedChanged);
            // 
            // tbGamburgerCount
            // 
            this.tbGamburgerCount.Enabled = false;
            this.tbGamburgerCount.Location = new System.Drawing.Point(487, 179);
            this.tbGamburgerCount.Name = "tbGamburgerCount";
            this.tbGamburgerCount.Size = new System.Drawing.Size(154, 39);
            this.tbGamburgerCount.TabIndex = 7;
            this.tbGamburgerCount.Text = "0";
            this.tbGamburgerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGamburgerCount.TextChanged += new System.EventHandler(this.tbHotDogCount_TextChanged);
            // 
            // tbGamburgerPrice
            // 
            this.tbGamburgerPrice.Enabled = false;
            this.tbGamburgerPrice.Location = new System.Drawing.Point(315, 179);
            this.tbGamburgerPrice.Name = "tbGamburgerPrice";
            this.tbGamburgerPrice.Size = new System.Drawing.Size(126, 39);
            this.tbGamburgerPrice.TabIndex = 6;
            this.tbGamburgerPrice.Text = "5,40";
            this.tbGamburgerPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbGamburger
            // 
            this.cbGamburger.AutoSize = true;
            this.cbGamburger.Location = new System.Drawing.Point(55, 182);
            this.cbGamburger.Name = "cbGamburger";
            this.cbGamburger.Size = new System.Drawing.Size(162, 36);
            this.cbGamburger.TabIndex = 5;
            this.cbGamburger.Text = "Гамбургер";
            this.cbGamburger.UseVisualStyleBackColor = true;
            this.cbGamburger.CheckedChanged += new System.EventHandler(this.cbGamburger_CheckedChanged);
            // 
            // tbHotDogCount
            // 
            this.tbHotDogCount.Enabled = false;
            this.tbHotDogCount.Location = new System.Drawing.Point(487, 120);
            this.tbHotDogCount.Name = "tbHotDogCount";
            this.tbHotDogCount.Size = new System.Drawing.Size(154, 39);
            this.tbHotDogCount.TabIndex = 4;
            this.tbHotDogCount.Text = "0";
            this.tbHotDogCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHotDogCount.TextChanged += new System.EventHandler(this.tbHotDogCount_TextChanged);
            // 
            // tbHodDogPrice
            // 
            this.tbHodDogPrice.Enabled = false;
            this.tbHodDogPrice.Location = new System.Drawing.Point(315, 120);
            this.tbHodDogPrice.Name = "tbHodDogPrice";
            this.tbHodDogPrice.Size = new System.Drawing.Size(126, 39);
            this.tbHodDogPrice.TabIndex = 3;
            this.tbHodDogPrice.Text = "4,00";
            this.tbHodDogPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbHotDog
            // 
            this.cbHotDog.AutoSize = true;
            this.cbHotDog.Location = new System.Drawing.Point(55, 122);
            this.cbHotDog.Name = "cbHotDog";
            this.cbHotDog.Size = new System.Drawing.Size(130, 36);
            this.cbHotDog.TabIndex = 2;
            this.cbHotDog.Text = "Хот-дог";
            this.cbHotDog.UseVisualStyleBackColor = true;
            this.cbHotDog.CheckedChanged += new System.EventHandler(this.cbHotDog_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Кількість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ціна";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 816);
            this.Controls.Add(this.pCafe);
            this.Controls.Add(this.pOil);
            this.Controls.Add(this.pTotal);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "BestOil";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pTotal.ResumeLayout(false);
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.pOil.ResumeLayout(false);
            this.gbOil.ResumeLayout(false);
            this.gbOil.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pCafe.ResumeLayout(false);
            this.gbCafe.ResumeLayout(false);
            this.gbCafe.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslTotalOil;
        private ToolStripStatusLabel tsslTotalCafe;
        private ToolStripStatusLabel tsslTotal;
        private Panel pTotal;
        private Panel pOil;
        private Panel pCafe;
        private GroupBox gbOil;
        private GroupBox gbCafe;
        private GroupBox gbTotal;
        private Label lbOilType;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox tbOilPrice;
        private Label label1;
        private ComboBox cbOilType;
        private TextBox tbGrn;
        private TextBox tbLitr;
        private RadioButton rbGrn;
        private RadioButton rbLitr;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Label lbOilPay;
        private TextBox tbFreeCount;
        private TextBox tbFreePrice;
        private CheckBox cbFree;
        private TextBox tbGamburgerCount;
        private TextBox tbGamburgerPrice;
        private CheckBox cbGamburger;
        private TextBox tbHotDogCount;
        private TextBox tbHodDogPrice;
        private CheckBox cbHotDog;
        private Label label7;
        private Label label6;
        private TextBox tbCocaColaCount;
        private TextBox tbCocaColaPrice;
        private CheckBox cbCocaCola;
        private Label lbTotalPay;
        private GroupBox groupBox3;
        private Label lbCafePay;
        private System.Windows.Forms.Timer timer1;
    }
}