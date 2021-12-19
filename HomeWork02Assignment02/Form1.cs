namespace HomeWork02Assignment02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime first, second;
            int res = 0;
            if (dateTimePicker1.Value < dateTimePicker2.Value) 
            {
                first = dateTimePicker1.Value.Date;
                second = dateTimePicker2.Value.Date;
            } 
            else
            {
                first = dateTimePicker2.Value.Date;
                second = dateTimePicker1.Value.Date;
            }
            while (first.AddDays(res)<second)
            {
                res++;
            }
            label3.Text=$"Кількість днів між {first.Day}.{first.Month}.{first.Year} та {second.Day}.{second.Month}.{second.Year}: {res}";
            label3.Visible = true;
        }
    }
}