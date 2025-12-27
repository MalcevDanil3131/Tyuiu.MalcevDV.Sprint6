using System.Windows.Forms;
using System.Xml.Linq;
namespace Tyuiu.MalcevDV.Sprint6.Task5.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_MDV = new GroupBox();
            buttonAbout_MDV = new Button();
            buttonLaunch_MDV = new Button();
            buttonChoose_MDV = new Button();
            textBoxTask_MDV = new TextBox();
            groupBoxOutput_MDV = new GroupBox();
            dataGridViewOutput_MDV = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chartOutput_MDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_MDV.SuspendLayout();
            groupBoxOutput_MDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MDV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOutput_MDV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_MDV
            // 
            groupBoxTask_MDV.Controls.Add(buttonAbout_MDV);
            groupBoxTask_MDV.Controls.Add(buttonLaunch_MDV);
            groupBoxTask_MDV.Controls.Add(buttonChoose_MDV);
            groupBoxTask_MDV.Controls.Add(textBoxTask_MDV);
            groupBoxTask_MDV.Location = new Point(12, 12);
            groupBoxTask_MDV.Name = "groupBoxTask_MDV";
            groupBoxTask_MDV.Size = new Size(784, 94);
            groupBoxTask_MDV.TabIndex = 0;
            groupBoxTask_MDV.TabStop = false;
            groupBoxTask_MDV.Text = "Условие";
            // 
            // buttonAbout_MDV
            // 
            buttonAbout_MDV.Location = new Point(700, 12);
            buttonAbout_MDV.Name = "buttonAbout_MDV";
            buttonAbout_MDV.Size = new Size(75, 66);
            buttonAbout_MDV.TabIndex = 3;
            buttonAbout_MDV.Text = "Справка";
            buttonAbout_MDV.UseVisualStyleBackColor = true;
            buttonAbout_MDV.Click += buttonAbout_MDV_Click;
            // 
            // buttonLaunch_MDV
            // 
            buttonLaunch_MDV.Location = new Point(538, 12);
            buttonLaunch_MDV.Name = "buttonLaunch_MDV";
            buttonLaunch_MDV.Size = new Size(75, 66);
            buttonLaunch_MDV.TabIndex = 1;
            buttonLaunch_MDV.Text = "Запуск";
            buttonLaunch_MDV.UseVisualStyleBackColor = true;
            buttonLaunch_MDV.Click += buttonLaunch_MDV_Click;
            // 
            // buttonChoose_MDV
            // 
            buttonChoose_MDV.Location = new Point(619, 12);
            buttonChoose_MDV.Name = "buttonChoose_MDV";
            buttonChoose_MDV.Size = new Size(75, 66);
            buttonChoose_MDV.TabIndex = 2;
            buttonChoose_MDV.Text = "Открыть файл";
            buttonChoose_MDV.UseVisualStyleBackColor = true;
            buttonChoose_MDV.Click += buttonChoose_MDV_Click;
            // 
            // textBoxTask_MDV
            // 
            textBoxTask_MDV.BorderStyle = BorderStyle.None;
            textBoxTask_MDV.Location = new Point(6, 22);
            textBoxTask_MDV.Multiline = true;
            textBoxTask_MDV.Name = "textBoxTask_MDV";
            textBoxTask_MDV.ReadOnly = true;
            textBoxTask_MDV.Size = new Size(560, 66);
            textBoxTask_MDV.TabIndex = 1;
            textBoxTask_MDV.Text = resources.GetString("textBoxTask_MDV.Text");
            // 
            // groupBoxOutput_MDV
            // 
            groupBoxOutput_MDV.Controls.Add(dataGridViewOutput_MDV);
            groupBoxOutput_MDV.Location = new Point(12, 112);
            groupBoxOutput_MDV.Name = "groupBoxOutput_MDV";
            groupBoxOutput_MDV.Size = new Size(200, 326);
            groupBoxOutput_MDV.TabIndex = 0;
            groupBoxOutput_MDV.TabStop = false;
            groupBoxOutput_MDV.Text = "Вывод данных";
            // 
            // dataGridViewOutput_MDV
            // 
            dataGridViewOutput_MDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_MDV.Location = new Point(6, 22);
            dataGridViewOutput_MDV.Name = "dataGridViewOutput_MDV";
            dataGridViewOutput_MDV.Size = new Size(188, 298);
            dataGridViewOutput_MDV.TabIndex = 1;
            // 
            // chartOutput_MDV
            // 
            chartArea1.Name = "ChartArea1";
            chartOutput_MDV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOutput_MDV.Legends.Add(legend1);
            chartOutput_MDV.Location = new Point(346, 121);
            chartOutput_MDV.Name = "chartOutput_MDV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOutput_MDV.Series.Add(series1);
            chartOutput_MDV.Size = new Size(300, 300);
            chartOutput_MDV.TabIndex = 1;
            chartOutput_MDV.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartOutput_MDV);
            Controls.Add(groupBoxOutput_MDV);
            Controls.Add(groupBoxTask_MDV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 17 | Мальцев Д.В.";
            Load += FormMain_Load;
            groupBoxTask_MDV.ResumeLayout(false);
            groupBoxTask_MDV.PerformLayout();
            groupBoxOutput_MDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MDV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOutput_MDV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MDV;
        private TextBox textBoxTask_MDV;
        private GroupBox groupBoxOutput_MDV;
        private Button buttonAbout_MDV;
        private Button buttonLaunch_MDV;
        private Button buttonChoose_MDV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridViewOutput_MDV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutput_MDV;
    }
}