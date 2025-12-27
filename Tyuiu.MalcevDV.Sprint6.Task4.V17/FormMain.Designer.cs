
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.MalcevDV.Sprint6.Task4.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxRes = new TextBox();
            buttonDone = new Button();
            buttonSoh = new Button();
            buttonINF = new Button();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox4 = new GroupBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(3, 29);
            textBoxRes.Margin = new Padding(2, 1, 2, 1);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(211, 337);
            textBoxRes.TabIndex = 0;
            textBoxRes.TextChanged += textBox1_TextChanged;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Crimson;
            buttonDone.Location = new Point(636, 19);
            buttonDone.Margin = new Padding(2, 1, 2, 1);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(81, 54);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonRes_Click;
            // 
            // buttonSoh
            // 
            buttonSoh.BackColor = Color.CornflowerBlue;
            buttonSoh.Location = new Point(725, 19);
            buttonSoh.Margin = new Padding(2, 1, 2, 1);
            buttonSoh.Name = "buttonSoh";
            buttonSoh.Size = new Size(81, 54);
            buttonSoh.TabIndex = 2;
            buttonSoh.Text = "Сохранить";
            buttonSoh.UseVisualStyleBackColor = false;
            buttonSoh.Click += buttonSoh_Click_1;
            // 
            // buttonINF
            // 
            buttonINF.BackColor = Color.Coral;
            buttonINF.ForeColor = Color.Black;
            buttonINF.Location = new Point(886, 21);
            buttonINF.Margin = new Padding(2, 1, 2, 1);
            buttonINF.Name = "buttonINF";
            buttonINF.Size = new Size(81, 52);
            buttonINF.TabIndex = 3;
            buttonINF.Text = "Справка";
            buttonINF.UseVisualStyleBackColor = false;
            buttonINF.Click += buttonINF_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 26);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(612, 67);
            textBox2.TabIndex = 4;
            textBox2.Text = "Протабулировать функцию  на заданном диапазоне от 5 до 5.";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(16, 14);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(380, 94);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxRes);
            groupBox2.Location = new Point(6, 115);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(215, 363);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "вывод";
            // 
            // chartRes
            // 
            chartArea3.Name = "ChartArea1";
            chartRes.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartRes.Legends.Add(legend3);
            chartRes.Location = new Point(234, 115);
            chartRes.Margin = new Padding(2, 1, 2, 1);
            chartRes.Name = "chartRes";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartRes.Series.Add(series3);
            chartRes.Size = new Size(733, 357);
            chartRes.TabIndex = 8;
            chartRes.Text = "chart1";
            chartRes.Click += chartRes_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxStop);
            groupBox4.Controls.Add(textBoxStart);
            groupBox4.Location = new Point(404, 14);
            groupBox4.Margin = new Padding(2, 1, 2, 1);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2, 1, 2, 1);
            groupBox4.Size = new Size(228, 84);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "ввод данных";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(121, 59);
            textBoxStop.Margin = new Padding(2, 1, 2, 1);
            textBoxStop.Multiline = true;
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(110, 25);
            textBoxStop.TabIndex = 1;
            textBoxStop.TextChanged += textBoxStop_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.AccessibleName = "textBoxStart";
            textBoxStart.Location = new Point(0, 59);
            textBoxStart.Margin = new Padding(2, 1, 2, 1);
            textBoxStart.Multiline = true;
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(110, 25);
            textBoxStart.TabIndex = 0;
            textBoxStart.TextChanged += textBoxStart_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 484);
            Controls.Add(groupBox4);
            Controls.Add(chartRes);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonINF);
            Controls.Add(buttonSoh);
            Controls.Add(buttonDone);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 17 | Мальцев Д.В.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private TextBox textBoxRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
        private Button buttonDone;
        private Button buttonSoh;
        private Button buttonINF;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
    }
}