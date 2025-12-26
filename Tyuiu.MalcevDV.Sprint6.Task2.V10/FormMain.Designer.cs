using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MalcevDV.Sprint6.Task2.V10
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_MDV = new GroupBox();
            textBoxUslovie_MDV = new TextBox();
            groupBoxData_MDV = new GroupBox();
            textBoxEnd_MDV = new TextBox();
            labelNamedTwo_MDV = new Label();
            textBoxStart_MDV = new TextBox();
            labelNamedOne_MDV = new Label();
            groupBoxRes_MDV = new GroupBox();
            dataGridViewFunction_MDV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            labelNamesThree_MDV = new Label();
            buttonHelp_MDV = new Button();
            buttonDone_MDV = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_MDV.SuspendLayout();
            groupBoxData_MDV.SuspendLayout();
            groupBoxRes_MDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MDV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_MDV
            // 
            groupBoxTask_MDV.Controls.Add(textBoxUslovie_MDV);
            groupBoxTask_MDV.Location = new Point(31, 29);
            groupBoxTask_MDV.Name = "groupBoxTask_MDV";
            groupBoxTask_MDV.Size = new Size(384, 205);
            groupBoxTask_MDV.TabIndex = 2;
            groupBoxTask_MDV.TabStop = false;
            groupBoxTask_MDV.Text = "Условие";
            // 
            // textBoxUslovie_MDV
            // 
            textBoxUslovie_MDV.BackColor = SystemColors.Menu;
            textBoxUslovie_MDV.Location = new Point(11, 22);
            textBoxUslovie_MDV.Multiline = true;
            textBoxUslovie_MDV.Name = "textBoxUslovie_MDV";
            textBoxUslovie_MDV.ReadOnly = true;
            textBoxUslovie_MDV.Size = new Size(337, 123);
            textBoxUslovie_MDV.TabIndex = 0;
            textBoxUslovie_MDV.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат выести в виде таблицы.";
            // 
            // groupBoxData_MDV
            // 
            groupBoxData_MDV.Controls.Add(textBoxEnd_MDV);
            groupBoxData_MDV.Controls.Add(labelNamedTwo_MDV);
            groupBoxData_MDV.Controls.Add(textBoxStart_MDV);
            groupBoxData_MDV.Controls.Add(labelNamedOne_MDV);
            groupBoxData_MDV.Location = new Point(31, 240);
            groupBoxData_MDV.Name = "groupBoxData_MDV";
            groupBoxData_MDV.Size = new Size(307, 99);
            groupBoxData_MDV.TabIndex = 3;
            groupBoxData_MDV.TabStop = false;
            groupBoxData_MDV.Text = "Ввод данных";
            // 
            // textBoxEnd_MDV
            // 
            textBoxEnd_MDV.Location = new Point(172, 47);
            textBoxEnd_MDV.Name = "textBoxEnd_MDV";
            textBoxEnd_MDV.Size = new Size(100, 23);
            textBoxEnd_MDV.TabIndex = 3;
            // 
            // labelNamedTwo_MDV
            // 
            labelNamedTwo_MDV.AutoSize = true;
            labelNamedTwo_MDV.Location = new Point(172, 29);
            labelNamedTwo_MDV.Name = "labelNamedTwo_MDV";
            labelNamedTwo_MDV.Size = new Size(75, 15);
            labelNamedTwo_MDV.TabIndex = 2;
            labelNamedTwo_MDV.Text = "Конец шага:";
            // 
            // textBoxStart_MDV
            // 
            textBoxStart_MDV.Location = new Point(15, 47);
            textBoxStart_MDV.Name = "textBoxStart_MDV";
            textBoxStart_MDV.Size = new Size(100, 23);
            textBoxStart_MDV.TabIndex = 1;
            // 
            // labelNamedOne_MDV
            // 
            labelNamedOne_MDV.AutoSize = true;
            labelNamedOne_MDV.Location = new Point(15, 29);
            labelNamedOne_MDV.Name = "labelNamedOne_MDV";
            labelNamedOne_MDV.Size = new Size(72, 15);
            labelNamedOne_MDV.TabIndex = 0;
            labelNamedOne_MDV.Text = "Старт шага:";
            // 
            // groupBoxRes_MDV
            // 
            groupBoxRes_MDV.Controls.Add(dataGridViewFunction_MDV);
            groupBoxRes_MDV.Controls.Add(labelNamesThree_MDV);
            groupBoxRes_MDV.Location = new Point(433, 29);
            groupBoxRes_MDV.Name = "groupBoxRes_MDV";
            groupBoxRes_MDV.Size = new Size(248, 375);
            groupBoxRes_MDV.TabIndex = 4;
            groupBoxRes_MDV.TabStop = false;
            groupBoxRes_MDV.Text = "Вывод данных:";
            // 
            // dataGridViewFunction_MDV
            // 
            dataGridViewFunction_MDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_MDV.Columns.AddRange(new DataGridViewColumn[] { X, Column1 });
            dataGridViewFunction_MDV.Location = new Point(20, 72);
            dataGridViewFunction_MDV.Name = "dataGridViewFunction_MDV";
            dataGridViewFunction_MDV.RowHeadersVisible = false;
            dataGridViewFunction_MDV.Size = new Size(189, 288);
            dataGridViewFunction_MDV.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "F(x)";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // labelNamesThree_MDV
            // 
            labelNamesThree_MDV.AutoSize = true;
            labelNamesThree_MDV.Location = new Point(20, 28);
            labelNamesThree_MDV.Name = "labelNamesThree_MDV";
            labelNamesThree_MDV.Size = new Size(63, 15);
            labelNamesThree_MDV.TabIndex = 1;
            labelNamesThree_MDV.Text = "Результат:";
            // 
            // buttonHelp_MDV
            // 
            buttonHelp_MDV.BackColor = SystemColors.HotTrack;
            buttonHelp_MDV.Location = new Point(203, 368);
            buttonHelp_MDV.Name = "buttonHelp_MDV";
            buttonHelp_MDV.Size = new Size(84, 56);
            buttonHelp_MDV.TabIndex = 6;
            buttonHelp_MDV.Text = "Справка";
            buttonHelp_MDV.UseVisualStyleBackColor = false;
            buttonHelp_MDV.Click += buttonHelp_MDV_Click;
            // 
            // buttonDone_MDV
            // 
            buttonDone_MDV.BackColor = Color.Lime;
            buttonDone_MDV.Location = new Point(306, 366);
            buttonDone_MDV.Name = "buttonDone_MDV";
            buttonDone_MDV.Size = new Size(92, 58);
            buttonDone_MDV.TabIndex = 7;
            buttonDone_MDV.Text = "Выполнить";
            buttonDone_MDV.UseVisualStyleBackColor = false;
            buttonDone_MDV.Click += buttonDone_MDV_Click;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(737, 75);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(300, 300);
            chartFunction.TabIndex = 8;
            chartFunction.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 458);
            Controls.Add(chartFunction);
            Controls.Add(buttonDone_MDV);
            Controls.Add(buttonHelp_MDV);
            Controls.Add(groupBoxRes_MDV);
            Controls.Add(groupBoxData_MDV);
            Controls.Add(groupBoxTask_MDV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 10 | Мальцев Д.В.";
            groupBoxTask_MDV.ResumeLayout(false);
            groupBoxTask_MDV.PerformLayout();
            groupBoxData_MDV.ResumeLayout(false);
            groupBoxData_MDV.PerformLayout();
            groupBoxRes_MDV.ResumeLayout(false);
            groupBoxRes_MDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MDV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MDV;
        private TextBox textBoxUslovie_MDV;
        private GroupBox groupBoxData_MDV;
        private TextBox textBoxEnd_MDV;
        private Label labelNamedTwo_MDV;
        private TextBox textBoxStart_MDV;
        private Label labelNamedOne_MDV;
        private GroupBox groupBoxRes_MDV;
        private Label labelNamesThree_MDV;
        private Button buttonHelp_MDV;
        private Button buttonDone_MDV;
        private DataGridView dataGridViewFunction_MDV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}