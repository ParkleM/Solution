using System;
using Implementation2;
using System.Windows.Forms;

namespace GUI2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringUtils stringUtils;
            try
            {
                stringUtils = new StringUtils(textBox1.Text);
            }
            catch
            {
                ShowErrorBox("Некоректный путь!");
                return;
            }

            string fileText = stringUtils.ReadFile();

            try
            {
                TextResult textResult = stringUtils.GetTextResult(fileText);

                textBox3.Text = textResult.RealCount.ToString();
                textBox4.Text = textResult.RealSum.ToString();
                textBox5.Text = textResult.IntegerCount.ToString();
                textBox6.Text = textResult.IntegerSum.ToString();
            }
            catch
            {
                ShowErrorBox("Ошибка чтения файла!");
                return;
            }

            textBox2.Text = fileText.Replace("\n", Environment.NewLine);
            ShowInformationBox("Файл успешно загружен!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ShowInformationBox(string text)
        {
            MessageBox.Show(
                text,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        private void ShowErrorBox(string text)
        {
            MessageBox.Show(
                text,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }
    }
}
