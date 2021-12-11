namespace Assignment03
{
    public partial class Assignment03Form : Form
    {
        public Assignment03Form()
        {
            InitializeComponent();
        }

        private void Assignment03Form_MouseClick(object sender, MouseEventArgs e)
        {
            var f = sender as Form;
            if (f != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (Control.ModifierKeys == Keys.Control)
                    {
                        f.Close();
                    }
                    String message = "";
                    if ((e.X < 10) || (e.Y < 10) || (e.X > f.ClientSize.Width - 10) || (e.Y > f.ClientSize.Height - 10))
                    {
                        message = "����� ��������� ������� ��������� ��������������";
                    }
                    else if ((e.X == 10) || (e.Y == 10) || (e.X == f.ClientSize.Width - 10) || (e.Y == f.ClientSize.Height - 10))
                    {
                        message = "����� ��������� �� ������� ��������� ��������������";
                    }
                    else if ((e.X > 10) && (e.Y > 10) && (e.X < f.ClientSize.Width - 10) && (e.Y < f.ClientSize.Height - 10)) 
                    {
                        message = "����� ��������� ������ ��������� ��������������";
                    }
                    MessageBox.Show(message);
                }
                if (e.Button == MouseButtons.Right)
                {
                        f.Text = $"������ = {f.ClientSize.Width}, ������ = {f.ClientSize.Height}";
                }
            }
        }

        private void Assignment03Form_MouseMove(object sender, MouseEventArgs e)
        {
            var f = sender as Form;
            if (f != null)
                f.Text = $"X: {e.X}, Y: {e.Y}";
        }
    }
}