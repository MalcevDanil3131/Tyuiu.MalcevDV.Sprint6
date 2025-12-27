using Tyuiu.MalcevDV.Sprint6.Task3.V2.Lib;

namespace Tyuiu.MalcevDV.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -12, -4, -20, 5, -5 }, { 2, 15, 1, -20, 7 }, { 15, -15, 2, 11, 5 }, { -19, -9, 16, 0, 1 }, { 17, 16, 5, 12, -8 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewNamedOne_MDV.ColumnCount = columns;
            dataGridViewNamedOne_MDV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewNamedOne_MDV.Columns[i].Width = 30;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewNamedOne_MDV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridViewResult_MDV.ColumnCount = columns;
            dataGridViewResult_MDV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_MDV.Columns[i].Width = 30;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_MDV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonHelp_MDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы Рппб-25-1 Мальцев Данил Вячеславович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
