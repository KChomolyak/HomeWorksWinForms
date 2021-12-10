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
            string text = "Чомоляк Константин\nДата рождения: 02.09.1978\nПроживание: г.Ужгород.\nКонтактная информация:\nТелефон: +38 (095) 076 - 03 - 09\nЭлектронная почта: kchomolyak@gmail.com";
            int cntMsgBox = 3;
            int cntSymbols = text.Length;
            MessageBox.Show(text, $"Резюме (часть 1 из {cntMsgBox})", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            text = "Ключевые навыки:\nАктивные продажи, расширение клиентской базы;\nРабота с ключевыми клиентами, устранение возникших разногласий;\nРуководство отделом продаж.";
            cntSymbols += text.Length;
            MessageBox.Show(text, $"Резюме (часть 2 из {cntMsgBox})", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            text = "Достижения:\nСоздал отдел продаж с «0». Впоследствии отдел(5 человек) под моим руководством регулярно выполнял план по привлечению новых клиентов и продажам;\nПривел в компанию 7 ключевых клиентов(совокупно до 50 % заказов);\nРазработал и внедрил в компании технологию продаж технически сложного оборудования.";
            cntSymbols += text.Length;
            MessageBox.Show(text, $"Cреднее число символов на странице: {cntSymbols/cntMsgBox}", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}