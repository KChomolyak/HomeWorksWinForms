namespace Assignment04
{
    public partial class Assignment04Form : Form
    {
        private int xStart = 0;
        private int yStart = 0;
        private int num = 0;

        public Assignment04Form()
        {
            InitializeComponent();
        }

        private void Assignment04Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var s = sender as Form;
                if (s != null)
                {
                    if (e.Button.HasFlag(MouseButtons.Left))
                    {
                        xStart = e.X;
                        yStart = e.Y;
                    }
                }
                else
                {
                    var s1 = sender as GroupBox;
                    if (s1 != null)
                    {
                        xStart = e.X + s1.Left;
                        yStart = e.Y + s1.Top;
                    }
                }
            }
        }

        private void Assignment04Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xEnd;
            int yEnd;
            var s = sender as Form;
            if (s != null)
            {
                if (xStart > e.X) 
                {
                    xEnd = xStart;
                    xStart = e.X;
                }
                else
                    xEnd = e.X;
                if (yStart > e.Y)
                {
                    yEnd = yStart;
                    yStart = e.Y;
                }
                else
                    yEnd = e.Y;
            }
            else 
            {
                var s1 = sender as GroupBox;
                if (xStart > e.X + s1.Left) 
                {
                    xEnd = xStart;
                    xStart = e.X + s1.Left;
                }
                else
                    xEnd = e.X + s1.Left;
                if (yStart > e.Y + s1.Top)
                {
                    yEnd = yStart;
                    yStart = e.Y + s1.Top;
                }
                else
                    yEnd = e.Y + s1.Top;
            }

                if ((xEnd - xStart < 10) || (yEnd - yStart < 10))
                {
                    Text = "Ошибка. Минимальний размер \"статика\" 10х10! ";
                }
                else
                {
                    GroupBox gb = new GroupBox();
                    gb.Left = xStart;
                    gb.Top = yStart;
                    gb.Width = (xEnd - xStart);
                    gb.Height = (yEnd - yStart);
                    gb.BackColor = Color.White;
                    num++;
                    gb.Text = num.ToString();
                    gb.MouseDown += Assignment04Form_MouseDown;
                    gb.MouseUp += Assignment04Form_MouseUp;
                    gb.MouseClick += Assignment04Form_MouseClick;
                    gb.MouseDoubleClick += Assignment04Form_MouseDoubleClick;
                    Controls.Add(gb);
                }
            }
        }

        private void Assignment04Form_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var f = sender as Form;
                if (f == null)
                {
                    var gb = sender as GroupBox;
                    var gbMax = gb;
                    int x = e.X + gb.Left;
                    int y = e.Y + gb.Top;
                    foreach (Control c in this.Controls)
                    {
                        var gb1 = c as GroupBox;
                        if (gb1 != null)
                        {
                            if ((x > gb1.Left) && (x < gb1.Left + gb1.Width) && (y > gb1.Top) && (y < gb1.Top + gb1.Height))
                            {
                                if (Convert.ToInt32(gb1.Text) > Convert.ToInt32(gbMax.Text))
                                    gbMax = gb1;
                            }
                        }
                    }
                    Text = $"#{gbMax.Text}: X:{gbMax.Left}, Y:{gbMax.Top}";
                }
                else
                    Text = "";
            }

        }

        private void Assignment04Form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                var gb = sender as GroupBox;
                if (gb != null) 
                {
                    var gbMin = gb;
                    int x = e.X + gb.Left;
                    int y = e.Y + gb.Top;
                    foreach (Control c in this.Controls)
                    {
                        var gb1 = c as GroupBox;
                        if (gb1 != null)
                        {
                            if ((x > gb1.Left) && (x < gb1.Left + gb1.Width) && (y > gb1.Top) && (y < gb1.Top + gb1.Height))
                            {
                                if (Convert.ToInt32(gb1.Text) < Convert.ToInt32(gbMin.Text))
                                    gbMin = gb1;
                            }
                        }
                    }
                    Controls.Remove(gbMin);
                }
            }
        }
    }
}