using Tyuiu.MalcevDV.Sprint6.Task0.V27.Lib;

namespace Tyuiu.MalcevDV.Sprint6.Task0.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonRun_MDV_Click(object sender, EventArgs e)
        {
            var ds = new DataService();
            try
            {
                var result = ds.Calculate(int.Parse(textBoxVarX_MDV.Text));
                textBoxResult_MDV.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInitials_MDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы Рппб-25-1 Мальцев Данил Вячеславович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxVarX_MDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
