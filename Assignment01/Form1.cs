namespace Assignment01
{
    public partial class Assignment01Form : Form
    {
        public Assignment01Form()
        {
            InitializeComponent();
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            string text = "������� ����������\n���� ��������: 02.09.1978\n����������: �.�������.\n���������� ����������:\n�������: +38 (095) 076 - 03 - 09\n����������� �����: kchomolyak@gmail.com";
            int cntMsgBox = 3;
            int cntSymbols = text.Length;
            MessageBox.Show(text, $"������ (����� 1 �� {cntMsgBox})", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            text = "�������� ������:\n�������� �������, ���������� ���������� ����;\n������ � ��������� ���������, ���������� ��������� �����������;\n����������� ������� ������.";
            cntSymbols += text.Length;
            MessageBox.Show(text, $"������ (����� 2 �� {cntMsgBox})", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            text = "����������:\n������ ����� ������ � �0�. ������������ �����(5 �������) ��� ���� ������������ ��������� �������� ���� �� ����������� ����� �������� � ��������;\n������ � �������� 7 �������� ��������(��������� �� 50 % �������);\n���������� � ������� � �������� ���������� ������ ���������� �������� ������������.";
            cntSymbols += text.Length;
            MessageBox.Show(text, $"C������ ����� �������� �� ��������: {cntSymbols/cntMsgBox}", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}