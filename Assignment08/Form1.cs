namespace Assignment08
{
    public partial class MainForm : Form
    {
        private string[] oilPrice = new string[6] { "25,49", "28,49", "29,49", "32,49", "27,99", "29,79" };
        private decimal OilPay = 0;
        private decimal CafePay = 0;
        private decimal AllOilPay = 0;
        private decimal AllCafePay = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            cbOilType.SelectedIndex = 2;
            tbOilPrice.Text = oilPrice[2];
            rbLitr.Checked = true;
            tbLitr.Text = "0";
            tbGrn.Text = "";
            OilPay = 0;
            lbOilPay.Text = $"{OilPay} грн.";
            cbHotDog.Checked = false;
            cbGamburger.Checked = false;
            cbFree.Checked = false;
            cbCocaCola.Checked = false;
            CafePay = 0;    
            lbCafePay.Text = $"{CafePay} грн.";
            lbTotalPay.Text = $"{OilPay + CafePay} грн.";
            tsslTotalOil.Text = $"По заправці: {AllOilPay} грн.";
            tsslTotalCafe.Text = $"По кафе: {AllCafePay} грн.";
            tsslTotal.Text = $"Всього: {AllOilPay + AllCafePay} грн.";
            cbOilType.Focus();
            timer1.Enabled = false;
        }

        private void cbOilType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbOilPrice.Text = oilPrice[cbOilType.SelectedIndex];
        }

        private void rbGrn_CheckedChanged(object sender, EventArgs e)
        {
            tbLitr.TextChanged -= tbLitr_TextChanged;
            tbGrn.TextChanged -= tbGrn_TextChanged;
            if (rbGrn.Checked)
            {
                tbGrn.Enabled = true;
                tbGrn.Text = "0.00";
                tbLitr.Enabled = false;
                tbLitr.Text = "";
                tbGrn.Focus();
            }
            else
            {
                tbGrn.Enabled = false;
                tbGrn.Text = "";
                tbLitr.Enabled = true;
                tbLitr.Text = "0";
                tbLitr.Focus();
            }
            OilPay = 0;
            lbOilPay.Text = $"{OilPay} грн.";
            lbTotalPay.Text = $"{OilPay + CafePay} грн.";
            tbLitr.TextChanged += tbLitr_TextChanged;
            tbGrn.TextChanged += tbGrn_TextChanged;
        }

        private void tbLitr_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            OilPay = Convert.ToDecimal(tbLitr.Text) * Convert.ToDecimal(tbOilPrice.Text);
            lbOilPay.Text = $"{OilPay} грн.";
            lbTotalPay.Text = $"{OilPay + CafePay} грн.";
            timer1.Enabled = true;
        }

        private void tbGrn_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false; 
            OilPay = Convert.ToDecimal(tbGrn.Text);
            lbOilPay.Text = $"{OilPay} грн.";
            lbTotalPay.Text = $"{OilPay + CafePay} грн.";
            timer1.Enabled = true;
        }

        private void cbHotDog_CheckedChanged(object sender, EventArgs e)
        {
            tbHotDogCount.Enabled = cbHotDog.Checked;
            tbHodDogPrice.Enabled = cbHotDog.Checked;
            if (!cbHotDog.Checked)
                tbHotDogCount.Text = "0";
            else
                tbHotDogCount.Focus();
        }

        private void cbGamburger_CheckedChanged(object sender, EventArgs e)
        {
            tbGamburgerCount.Enabled = cbGamburger.Checked;
            tbGamburgerPrice.Enabled = cbGamburger.Checked;
            if (!cbGamburger.Checked)
                tbGamburgerCount.Text = "0";
            else
                tbGamburgerCount.Focus();
        }

        private void cbFree_CheckedChanged(object sender, EventArgs e)
        {
            tbFreeCount.Enabled = cbFree.Checked;
            tbFreePrice.Enabled = cbFree.Checked;
            if (!cbFree.Checked)
                tbFreeCount.Text = "0";
            else
                tbFreeCount.Focus();
        }

        private void cbCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            tbCocaColaCount.Enabled = cbCocaCola.Checked;
            tbCocaColaPrice.Enabled = cbCocaCola.Checked;
            if (!cbCocaCola.Checked) 
                tbCocaColaCount.Text = "0";
            else
                tbCocaColaCount.Focus();
        }

        private void tbHotDogCount_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            CafePay = 0;
            if (cbHotDog.Checked)
                CafePay += Convert.ToDecimal(tbHodDogPrice.Text) * Convert.ToDecimal(tbHotDogCount.Text);
            if (cbGamburger.Checked)
                CafePay += Convert.ToDecimal(tbGamburgerPrice.Text) * Convert.ToDecimal(tbGamburgerCount.Text);
            if (cbFree.Checked)
                CafePay += Convert.ToDecimal(tbFreePrice.Text) * Convert.ToDecimal(tbFreeCount.Text);
            if (cbCocaCola.Checked)
                CafePay += Convert.ToDecimal(tbCocaColaPrice.Text) * Convert.ToDecimal(tbCocaColaCount.Text);
            lbCafePay.Text = $"{CafePay} грн.";
            lbTotalPay.Text = $"{OilPay + CafePay} грн.";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наступний клієнт?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AllOilPay += OilPay;
                AllCafePay += CafePay;
                OilPay = 0;
                CafePay = 0;
                MainForm_Shown(sender, EventArgs.Empty);
            }
            else
                timer1.Enabled = true;
        }
    }
}