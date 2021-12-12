namespace Assignment05
{
    public partial class Form1 : Form
    {
        private int xPrevious;
        private int yPrevious;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var dx = e.X - xPrevious;
            var dy = e.Y - yPrevious;
            if (dy > 0 &&
                (e.X > runningPanel.Left) && (e.X < runningPanel.Left + runningPanel.Width) &&
                (e.Y > (runningPanel.Top - 50)) && (e.Y < runningPanel.Top)) //mouse move down
            {
                if (runningPanel.Top + runningPanel.Height + 100 > ClientSize.Height)
                    runningPanel.Top = 70;
                else
                    runningPanel.Top += 50;
            }
            if ((dy < 0) &&
                (e.X > runningPanel.Left) && (e.X < runningPanel.Left + runningPanel.Width) &&
                (e.Y > (runningPanel.Top + runningPanel.Height)) && (e.Y < (runningPanel.Top + runningPanel.Height + 50))) //mouse move up
            {
                if (runningPanel.Top < 100)
                    runningPanel.Top = ClientSize.Height - runningPanel.Height - 70;
                else
                    runningPanel.Top -= 50;
            }

            if (dx > 0 &&
                (e.Y > runningPanel.Top) && (e.Y < runningPanel.Top + runningPanel.Height) &&
                (e.X > (runningPanel.Left - 50)) && (e.X < runningPanel.Left)) //mouse move right
            {
                if (runningPanel.Left + runningPanel.Width + 100 > ClientSize.Width)
                    runningPanel.Left = 70;
                else
                    runningPanel.Left += 50;
            }
            if (dx < 0 &&
                (e.Y > runningPanel.Top) && (e.Y < runningPanel.Top + runningPanel.Height) &&
                (e.X > (runningPanel.Left + runningPanel.Width)) && (e.X < (runningPanel.Left + runningPanel.Width + 50))) //mouse move left
            {
                if (runningPanel.Left < 100)
                    runningPanel.Left = ClientSize.Width - runningPanel.Width - 70;
                else
                    runningPanel.Left -= 50;
            }

            xPrevious = e.X; 
            yPrevious = e.Y;
        }
    }
}