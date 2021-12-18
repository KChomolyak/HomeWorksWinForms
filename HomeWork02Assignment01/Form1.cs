namespace HomeWork02Assignment01
{
    public partial class Form1 : Form
    {
        private string firstName { get => tbFirstName.Text; }
        private string name_ { get => tbName.Text; }
        private string surName { get => tbSurName.Text; }
        private string sex { get => cbSex.SelectedIndex == 0 ? "Male" : "Female"; }
        private DateTime birthday { get => dtpBirthDay.Value.Date; }
        private string familyState { get => cbFamily.SelectedIndex == 0 ? "Married" : "Single"; }
        private string additionInfo { get => tbAdditionalInfo.Text; }
            

        public Form1()
        {
            InitializeComponent();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbName.Text != "" && tbSurName.Text != "" && cbSex.SelectedIndex != -1 && cbFamily.SelectedIndex != -1 && dtpBirthDay.Value.Date <= DateTime.Now.Date)
                btSave.Enabled = true;
            else
                btSave.Enabled = false;
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string fileName = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(fileName, $"{firstName} {name_} {surName} {sex} {Convert.ToString(birthday.Date)} {familyState} {additionInfo}");
            MessageBox.Show("Дані збережено");
            tbFirstName.Text = "";
            tbName.Text = "";
            tbSurName.Text = "";
            cbSex.Text = "Виберіть...";
            dtpBirthDay.Value = DateTime.Now;
            cbFamily.Text = "Виберіть...";
            tbAdditionalInfo.Text = "";
        }
    }
}