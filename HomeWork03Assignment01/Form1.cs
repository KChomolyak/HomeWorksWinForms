using System;
using System.IO;
using System.Text;
namespace HomeWork03Assignment01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                var f = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                progressBar1.Minimum = 0;
                progressBar1.Maximum = (int)fi.Length ;
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                label1.Text = $"{progressBar1.Minimum}";
                label1.Visible = true;
                label2.Text = $"{progressBar1.Maximum}";                
                label2.Visible = true;

                while (f.ReadByte() != -1) 
                    progressBar1.Value++;
                f.Close();

            }
        }
    }
}