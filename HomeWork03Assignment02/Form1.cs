using System.Xml;

namespace HomeWork03Assignment02
{
    public partial class Form1 : Form
    {
        private int editedItem = -1;
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialogTXT.ShowDialog() == DialogResult.OK) 
            {
                TextWriter txtFile = new StreamWriter(saveFileDialogTXT.FileName);
                foreach (var item in listBox1.Items)
                    txtFile.WriteLine(item.ToString());
                txtFile.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (btAddEdit.Text == "Додати")
            {
                listBox1.Items.Add($"{tbName.Text}\t{tbFirstName.Text}\t{tbEMail.Text}\t{mtbPhone.Text}");
            }
            else
            {
                if (editedItem != -1)
                {
                    listBox1.Items.RemoveAt(editedItem);
                    listBox1.Items.Insert(editedItem, $"{tbName.Text}\t{tbFirstName.Text}\t{tbEMail.Text}\t{mtbPhone.Text}");
                    btAddEdit.Text = "Додати";
                    editedItem = -1;
                }
            }
            tbName.Text = "";
            tbFirstName.Text = "";
            tbEMail.Text = "";
            mtbPhone.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Text = "";
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbFirstName.Text != "" && tbEMail.ForeColor != Color.Red && mtbPhone.ForeColor != Color.Red)
            {
                btAddEdit.Enabled = true;
            }
        }

        private void tbEMail_TextChanged(object sender, EventArgs e)
        {
            if (tbEMail.Text.Contains('@') && tbEMail.Text.Contains('.') && tbEMail.Text[tbEMail.Text.Length-1]!='.')
            {
                tbEMail.ForeColor = tbName.ForeColor;
                tbName_TextChanged(sender, e);
            }
            else
            {
                tbEMail.ForeColor = Color.Red;
                btAddEdit.Enabled = false;
            }
        }

        private void mtbPhone_TextChanged(object sender, EventArgs e)
        {
            if (mtbPhone.Text.Length == 14)
            {
                mtbPhone.ForeColor = tbName.ForeColor;
                tbName_TextChanged(sender, e);
            }
            else
            {
                mtbPhone.ForeColor = Color.Red;
                btAddEdit.Enabled = false;
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var lb = sender as ListBox;
            if (lb != null)
            {
                if (listBox1.SelectedItem != null)
                {
                    editedItem = listBox1.SelectedIndex;
                    string tempstr = listBox1.SelectedItem.ToString();
                    int pos = tempstr.IndexOf("\t");
                    tbName.Text = tempstr.Substring(0,pos);
                    tempstr = tempstr.Substring(pos+1);
                    pos = tempstr.IndexOf("\t");
                    tbFirstName.Text = tempstr.Substring(0, pos);
                    tempstr = tempstr.Substring(pos + 1);
                    pos = tempstr.IndexOf("\t");
                    tbEMail.Text = tempstr.Substring(0, pos);
                    mtbPhone.Text = tempstr.Substring(pos + 1);
                    btAddEdit.Text = "Редагувати";
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                btDelete.Enabled = true;
            else
                btDelete.Enabled = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (editedItem != -1)
            {
                tbName.Text = "";
                tbFirstName.Text = "";
                tbEMail.Text = "";
                mtbPhone.Text = "";
                editedItem = -1;
            }
        }
        private void btSaveXML_Click(object sender, EventArgs e)
        {
            if (saveFileDialogXML.ShowDialog() == DialogResult.OK)
            {
                XmlWriter xmlWriter = XmlWriter.Create(saveFileDialogXML.FileName);

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Peoples");
                int no=0;
                foreach (var item in listBox1.Items)
                {
                    xmlWriter.WriteStartElement("Anketa"+no.ToString());
                    no++;
                    string tempstr = item.ToString();
                    int pos = tempstr.IndexOf("\t");
                    xmlWriter.WriteAttributeString("Name", tempstr.Substring(0, pos));
                    tempstr = tempstr.Substring(pos + 1);
                    pos = tempstr.IndexOf("\t");
                    xmlWriter.WriteAttributeString("FirstName", tempstr.Substring(0, pos));
                    tempstr = tempstr.Substring(pos + 1);
                    pos = tempstr.IndexOf("\t");
                    xmlWriter.WriteAttributeString("E-Mail", tempstr.Substring(0, pos));
                    xmlWriter.WriteAttributeString("PhoneNumber", tempstr.Substring(pos + 1));
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.Close();
            }

        }
    }
}