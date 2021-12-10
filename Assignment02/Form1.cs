namespace Assignment02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbMin_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(tbMin.Text);
            }
            catch (OverflowException)
            {
                tbMin.Text = "1";
                MessageBox.Show("Введено невірне число", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (FormatException) 
            {
                tbMin.Text = "1";
                MessageBox.Show("Потрібно ввести число", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (num >= Convert.ToInt32(tbMax.Text)) 
            {
                tbMin.Text = "1";
                MessageBox.Show("Мінімальне значення повинно бути меншим за максимальне", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbMax_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(tbMax.Text);
            }
            catch (OverflowException)
            {
                tbMax.Text = "2000";
                MessageBox.Show("Введено невірне число", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FormatException)
            {
                tbMax.Text = "2000";
                MessageBox.Show("Потрібно ввести число", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (num <= Convert.ToInt32(tbMin.Text))
            {
                tbMax.Text = "2000";
                MessageBox.Show("Максимальне значення повинно бути більшим за мінімальне", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbMyNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbMyNumber.Text != "")
            {
                int num = 0;
                try
                {
                    num = Convert.ToInt32(tbMyNumber.Text);
                }
                catch (OverflowException)
                {
                    tbMyNumber.Text = "";
                    MessageBox.Show("Введено невірне число", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (FormatException)
                {
                    tbMyNumber.Text = "";
                    MessageBox.Show("Потрібно ввести число", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (num < Convert.ToInt32(tbMin.Text)|| num > Convert.ToInt32(tbMax.Text))
                {
                    tbMyNumber.Text = "";
                    MessageBox.Show($"Значення повинно бути між {tbMin.Text} та {tbMax.Text}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btStart.Enabled = true;
                }
            }
            else
            {
                btStart.Enabled = false;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int count = 0;
            do
            {
                count++;
            } while (rnd.Next(Convert.ToInt32(tbMin.Text), Convert.ToInt32(tbMax.Text)) != Convert.ToInt32(tbMyNumber.Text));
            MessageBox.Show($"Число відгадано з {count} спроби", "Ура!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btStart.Enabled = false;
            btRetry.Enabled = true;
        }

        private void btRetry_Click(object sender, EventArgs e)
        {
            tbMin.Text = "1";
            tbMax.Text = "2000";
            tbMyNumber.Text = "";
            btRetry.Enabled = false;
            btStart.Enabled = false;
        }
    }
}