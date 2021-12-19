namespace HomeWork02Assignment04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbDay_TextChanged(object sender, EventArgs e)
        {
            DateTime res;
            try 
            {
                //                res = Convert.ToDateTime($"{tbDay.Text}.{tbMonth.Text}.{tbYear.Text}"); 
                res = new DateTime(Convert.ToInt32(tbYear.Text), Convert.ToInt32(tbMonth.Text), Convert.ToInt32(tbDay.Text));
            }
            catch
            {
                label3.Text = "Введено некоректну дату";
                label3.Visible = true;
                monthCalendar1.Visible = false;
                return;
            }
            if (res > monthCalendar1.MinDate && res < monthCalendar1.MaxDate)
            {
                label3.Visible = false;
                monthCalendar1.SetDate(res);
                monthCalendar1.Visible = true;
            }
            else
            {
                label3.Text = $"Дата має бути в діапазоні від {monthCalendar1.MinDate.Day}.{monthCalendar1.MinDate.Month}.{monthCalendar1.MinDate.Year} до {monthCalendar1.MaxDate.Day}.{monthCalendar1.MaxDate.Month}.{monthCalendar1.MaxDate.Year}";
                label3.Visible = true;
                monthCalendar1.Visible = false;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now.AddYears(-100);
            monthCalendar1.MaxDate = DateTime.Now;
        }
    }
}