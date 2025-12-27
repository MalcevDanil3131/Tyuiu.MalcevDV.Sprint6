using Tyuiu.MalcevDV.Sprint6.Task4.V17.Lib;

namespace Tyuiu.MalcevDV.Sprint6.Task4.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
           
        }



        private void buttonSoh_Click(object sender, EventArgs e)
        {
           
        }

        private void chartRes_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStop_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonINF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы Рппб-25-1 Мальцев Данил Вячеславович");
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);

                int len = stopValue - startValue + 1;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartRes.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartRes.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes.Text = "";

                chartRes.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartRes.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxRes.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSoh_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4.txt" });
                File.WriteAllText(path, textBoxRes.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
