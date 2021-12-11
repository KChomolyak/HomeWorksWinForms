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
                runningPanel.Top += 50;

            if ((dy < 0) &&
                (e.X > runningPanel.Left) && (e.X < runningPanel.Left + runningPanel.Width) &&
                (e.Y > (runningPanel.Top + runningPanel.Height)) && (e.Y < (runningPanel.Top + runningPanel.Height + 50))) //mouse move up
                runningPanel.Top -= 50;

            if (dx > 0 &&
                (e.Y > runningPanel.Top) && (e.Y < runningPanel.Top + runningPanel.Height) &&
                (e.X > (runningPanel.Left - 50)) && (e.X < runningPanel.Left)) //mouse move right
                runningPanel.Left += 50;

            if (dx < 0 &&
                (e.Y > runningPanel.Top) && (e.Y < runningPanel.Top + runningPanel.Height) &&
                (e.X > (runningPanel.Left + runningPanel.Width)) && (e.X < (runningPanel.Left + runningPanel.Width + 50))) //mouse move left
                runningPanel.Left -= 50;

            xPrevious = dx; 
            yPrevious = dy;
        }
    }
}