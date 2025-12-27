using Tyuiu.MalcevDV.Sprint6.Task5.V17.Lib;

namespace Tyuiu.MalcevDV.Sprint6.Task5.V17
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V17.txt");

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonLaunch_MDV_Click(object sender, EventArgs e)
        {
            dataGridViewOutput_MDV.ColumnCount = 2;
            dataGridViewOutput_MDV.Columns[0].Width = 20;
            dataGridViewOutput_MDV.Columns[1].Width = 50;

            this.chartOutput_MDV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartOutput_MDV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartOutput_MDV.Series[0].Points.Clear();

            double[] numMDVss = new double[ds.len];

            numMDVss = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMDVss.Length; i++)
            {
                dataGridViewOutput_MDV.Rows.Add(Convert.ToString(i), Convert.ToString(numMDVss[i]));
                chartOutput_MDV.Series[0].Points.AddXY(i, numMDVss[i]);
            }
        }

        private void buttonChoose_MDV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonAbout_MDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы Рппб-25-1 Мальцев Данил Вячеславович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
