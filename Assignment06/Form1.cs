namespace Assignment06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            cbYear.SelectedIndexChanged -= cbYear_SelectedIndexChanged; 
            DateTime dt = DateTime.Now;
            for(int i = 1; i < dt.Year + 100; i++) 
            {
                cbYear.Items.Add(i.ToString());
            }
            cbYear.SelectedItem = dt.Year.ToString();
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMonth.SelectedIndexChanged -= cbMonth_SelectedIndexChanged;
            lbResult.Text = "";
            cbDay.SelectedIndexChanged -= cbDay_SelectedIndexChanged;
            cbDay.Items.Clear();
            cbDay.Text = "";
            cbDay.Enabled = false;
            cbDay.SelectedIndexChanged += cbDay_SelectedIndexChanged;
            DateTime dt = DateTime.Now;
            cbMonth.Items.Clear();
            cbMonth.Items.Add("Січень");
            cbMonth.Items.Add("Лютий");
            cbMonth.Items.Add("Березень");
            cbMonth.Items.Add("Квітень");
            cbMonth.Items.Add("Травень");
            cbMonth.Items.Add("Червень");
            cbMonth.Items.Add("Липень");
            cbMonth.Items.Add("Серпень");
            cbMonth.Items.Add("Вересень");
            cbMonth.Items.Add("Жовтень");
            cbMonth.Items.Add("Листопад");
            cbMonth.Items.Add("Грудень");
            cbMonth.SelectedIndex = dt.Month-1;
            cbMonth.Enabled = true;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
        }


        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay.SelectedIndexChanged -= cbDay_SelectedIndexChanged;
            lbResult.Text = ""; 
            DateTime dt;
            dt = Convert.ToDateTime($"1/{cbMonth.SelectedIndex + 1}/{cbYear.Text}");
            int countDay = 0;
            if (dt.Month == 1 || dt.Month == 3 || dt.Month == 5 || dt.Month == 7 || dt.Month == 8 || dt.Month == 10 || dt.Month == 12)
                countDay = 31;
            if (dt.Month == 4 || dt.Month == 6 || dt.Month == 9 || dt.Month == 11)
                countDay = 30;
            if (dt.Month == 2)
            { 
                countDay = 29;
                if (dt.Year % 4 == 0)
                    countDay--;
                if (dt.Year % 100 == 0)
                    countDay++;
            }
            cbDay.Items.Clear();
            for (int i = 1; i < countDay + 1; i++)
                cbDay.Items.Add(i.ToString());
            if (dt.Year == DateTime.Now.Year && dt.Month == DateTime.Now.Month)
                cbDay.SelectedItem = DateTime.Now.Day.ToString();
            else
                cbDay.SelectedItem = "1";
           
            cbDay.Enabled = true;
            cbDay.SelectedIndexChanged += cbDay_SelectedIndexChanged;
        }



        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbResult.Text = ""; 
            DateTime dt = Convert.ToDateTime($"{cbDay.Text}/{cbMonth.SelectedIndex+1}/{cbYear.Text}");

            if (dt.Day == DateTime.Now.Day && dt.Month == DateTime.Now.Month && dt.Year == DateTime.Now.Year)
                lbResult.Text = "Сьогодні ";
            else
            {
                lbResult.Text = $"{cbDay.Text}-го";
                switch (cbMonth.SelectedIndex) 
                {
                    case 0:
                        lbResult.Text += " січня ";
                        break;
                    case 1:
                        lbResult.Text += " лютого ";
                        break;
                    case 2:
                        lbResult.Text += " березня ";
                        break;
                    case 3:
                        lbResult.Text += " квітня ";
                        break;
                    case 4:
                        lbResult.Text += " травня ";
                        break;
                    case 5:
                        lbResult.Text += " червня ";
                        break;
                    case 6:
                        lbResult.Text += " липня ";
                        break;
                    case 7:
                        lbResult.Text += " серпня ";
                        break;
                    case 8:
                        lbResult.Text += " вересня ";
                        break;
                    case 9:
                        lbResult.Text += " жовтня ";
                        break;
                    case 10:
                        lbResult.Text += " листопада ";
                        break;
                    case 11:
                        lbResult.Text += " грудня ";
                        break;
                }
                lbResult.Text += $"{cbYear.Text} року ";
                if (dt < DateTime.Now)
                {
                    if ((int)(dt.DayOfWeek) == 0 || (int)(dt.DayOfWeek) == 3 || (int)(dt.DayOfWeek) == 5 || (int)(dt.DayOfWeek) == 6)
                        lbResult.Text += "була ";
                    else
                        lbResult.Text += "був ";
                }
                else
                    lbResult.Text += "буде ";
            }
            switch ((int)(dt.DayOfWeek))
            {
                case 0:
                    lbResult.Text += "неділя";
                    break;
                case 1:
                    lbResult.Text += "понеділок";
                    break;
                case 2:
                    lbResult.Text += "вівторок";
                    break;
                case 3:
                    lbResult.Text += "середа";
                    break;
                case 4:
                    lbResult.Text += "четвер";
                    break;
                case 5:
                    lbResult.Text += "п'ятниця";
                    break;
                case 6:
                    lbResult.Text += "субота";
                    break;
            }

        }
    }
}