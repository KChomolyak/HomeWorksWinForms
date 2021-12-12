namespace Assignment07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mtbDate_Leave(object sender, EventArgs e)
        {
            string str = mtbDate.Text;
            DateTime dt;
            try
            {
                if (str[1] == ' ')
                {
                    mtbDate.Text = $"0{str[0]}.01.2021 00:00";
                    dt = Convert.ToDateTime($"{str[0]}/01/2021 0:00");
                }
                else if (str[3] == ' ')
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.01.2021 00:00";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/01/2021 0:00");
                }
                else if (str[4] == ' ')
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.0{str[3]}.2021 00:00";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/{str[3]}/2021 0:00");
                }
                else if (str[6] == ' ')
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.{str[3]}{str[4]}.2021 00:00";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/{str[3]}{str[4]}/2021 0:00");
                }
                else if (str[7] == ' ')
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.{str[3]}{str[4]}.200{str[6]} 00:00";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/{str[3]}{str[4]}/200{str[6]} 0:00");
                }
                else if (str[8] == ' ')
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.{str[3]}{str[4]}.20{str[6]}{str[7]} 00:00";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/{str[3]}{str[4]}/20{str[6]}{str[7]} 0:00");
                }
                else if (str[9] == ' ')
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.{str[3]}{str[4]}.2{str[6]}{str[7]}{str[8]} 00:00";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/{str[3]}{str[4]}/2{str[6]}{str[7]}{str[8]} 0:00");
                }
                else if (str[11] == ' ')
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.{str[3]}{str[4]}.{str[6]}{str[7]}{str[8]}{str[9]} 00:00";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/{str[3]}{str[4]}/{str[6]}{str[7]}{str[8]}{str[9]} 0:00");
                }
                else if (str[12] == ' ')
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.{str[3]}{str[4]}.{str[6]}{str[7]}{str[8]}{str[9]} 0{str[11]}:00";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/{str[3]}{str[4]}/{str[6]}{str[7]}{str[8]}{str[9]} {str[11]}:00");
                }
                else if (str.Length ==14)
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.{str[3]}{str[4]}.{str[6]}{str[7]}{str[8]}{str[9]} {str[11]}{str[12]}:00";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/{str[3]}{str[4]}/{str[6]}{str[7]}{str[8]}{str[9]} {str[11]}{str[12]}:00");
                }
                else if (str.Length == 15)
                {
                    mtbDate.Text = $"{str[0]}{str[1]}.{str[3]}{str[4]}.{str[6]}{str[7]}{str[8]}{str[9]} {str[11]}{str[12]}:0{str[14]}";
                    dt = Convert.ToDateTime($"{str[0]}{str[1]}/{str[3]}{str[4]}/{str[6]}{str[7]}{str[8]}{str[9]} {str[11]}{str[12]}:0{str[14]}");
                }
                else
                    dt = Convert.ToDateTime(str);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Невірно вказана дата", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbDate.Text = "";
                groupBox1.Enabled = false;
                mtbDate.Focus();
                return;
            }
            groupBox1.Enabled = true;
        }

        private void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYear.Checked)
            {
                var years = (DateTime.Now - Convert.ToDateTime(mtbDate.Text)).TotalDays / 365.2425;
                if (DateTime.Now > Convert.ToDateTime(mtbDate.Text))
                {
                    lbResult.Text = $"Пройшло {years} років";
                }
                else
                {
                    lbResult.Text = $"Залишилося {-1 * years} років";
                }
            }
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonth.Checked)
            {
                var month = (DateTime.Now - Convert.ToDateTime(mtbDate.Text)).TotalDays / 365.2425 * 12;
                if (DateTime.Now > Convert.ToDateTime(mtbDate.Text))
                {
                    lbResult.Text = $"Пройшло {month} місяців";
                }
                else
                {
                    lbResult.Text = $"Залишилося {-1 * month} місяців";
                }
            }
        }

        private void mtbDate_TextChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            rbYear.Checked = false;
            rbMonth.Checked = false;
            rbDay.Checked = false;
            rbMinutes.Checked = false;
            rbSeconds.Checked = false;
            lbResult.Text = "";
        }

        private void rbDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDay.Checked)
            {
                var days = (DateTime.Now - Convert.ToDateTime(mtbDate.Text)).TotalDays;
                if (DateTime.Now > Convert.ToDateTime(mtbDate.Text))
                {
                    if ((int)days % 10 == 1 && (int)days % 100 != 11)
                        lbResult.Text = $"Пройшов {(int)days} ";
                    else
                        lbResult.Text = $"Пройшло {(int)days} ";
                }
                else
                {
                    days *= -1;
                    if ((int)days % 10 == 1 && (int)days % 100 != 11)
                        lbResult.Text = $"Залишився {(int)days} ";
                    else
                        lbResult.Text = $"Залишилося {(int)days} ";
                }
                if ((int)days % 10 == 1 && (int)days % 100 != 11)
                    lbResult.Text += "день";
                else if ((((int)days % 10 == 2) || ((int)days % 10 == 3) || ((int)days % 10 == 4)) && !(((int)days % 100 == 12) || ((int)days % 100 == 13) || ((int)days % 100 == 14)))
                    lbResult.Text += "дні";
                else
                    lbResult.Text += "днів";
            }
        }

        private void rbMinutes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinutes.Checked)
            {
                var minutes = (DateTime.Now - Convert.ToDateTime(mtbDate.Text)).TotalDays * 24 * 60;
                if (DateTime.Now > Convert.ToDateTime(mtbDate.Text))
                {
                    if ((int)minutes % 10 == 1 && (int)minutes % 100 != 11)
                        lbResult.Text = $"Пройшла {(int)minutes} ";
                    else
                        lbResult.Text = $"Пройшли {(int)minutes} ";
                }
                else
                {
                    minutes *= -1;
                    if ((int)minutes % 10 == 1 && (int)minutes % 100 != 11)
                        lbResult.Text = $"Залишилася {(int)minutes} ";
                    else
                        lbResult.Text = $"Залишилися {(int)minutes} ";
                }
                if ((int)minutes % 10 == 1 && (int)minutes % 100 != 11)
                    lbResult.Text += "хвилина";
                else if ((((int)minutes % 10 == 2) || ((int)minutes % 10 == 3) || ((int)minutes % 10 == 4)) && !(((int)minutes % 100 == 12) || ((int)minutes % 100 == 13) || ((int)minutes % 100 == 14)))
                    lbResult.Text += "хвилини";
                else
                    lbResult.Text += "хвилин";
            }
        }

        private void rbSeconds_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSeconds.Checked)
            {
                var seconds = (DateTime.Now - Convert.ToDateTime(mtbDate.Text)).TotalDays * 24 * 60 * 60;
                if (DateTime.Now > Convert.ToDateTime(mtbDate.Text))
                {
                    if ((int)seconds % 10 == 1 && (int)seconds % 100 != 11)
                        lbResult.Text = $"Пройшла {(int)seconds} ";
                    else
                        lbResult.Text = $"Пройшли {(int)seconds} ";
                }
                else
                {
                    seconds *= -1;
                    if ((int)seconds % 10 == 1 && (int)seconds % 100 != 11)
                        lbResult.Text = $"Залишилася {(int)seconds} ";
                    else
                        lbResult.Text = $"Залишилися {(int)seconds} ";
                }
                if ((int)seconds % 10 == 1 && (int)seconds % 100 != 11)
                    lbResult.Text += "секунда";
                else if ((((int)seconds % 10 == 2) || ((int)seconds % 10 == 3) || ((int)seconds % 10 == 4)) && !(((int)seconds % 100 == 12) || ((int)seconds % 100 == 13) || ((int)seconds % 100 == 14)))
                    lbResult.Text += "секунди";
                else
                    lbResult.Text += "секунд";
            }
        }
    }
}