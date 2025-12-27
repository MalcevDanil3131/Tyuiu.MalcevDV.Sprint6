using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.MalcevDV.Sprint6.Task3.V2
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
            groupBoxTask_MDV = new GroupBox();
            textBoxUslovie_MDV = new TextBox();
            groupBoxRes_MDV = new GroupBox();
            dataGridViewResult_MDV = new DataGridView();
            labelNamesThree_MDV = new Label();
            buttonDone_MDV = new Button();
            buttonHelp_MDV = new Button();
            groupBoxData_MDV = new GroupBox();
            dataGridViewNamedOne_MDV = new DataGridView();
            groupBoxTask_MDV.SuspendLayout();
            groupBoxRes_MDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MDV).BeginInit();
            groupBoxData_MDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNamedOne_MDV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_MDV
            // 
            groupBoxTask_MDV.Controls.Add(textBoxUslovie_MDV);
            groupBoxTask_MDV.Location = new Point(12, 12);
            groupBoxTask_MDV.Name = "groupBoxTask_MDV";
            groupBoxTask_MDV.Size = new Size(339, 162);
            groupBoxTask_MDV.TabIndex = 3;
            groupBoxTask_MDV.TabStop = false;
            groupBoxTask_MDV.Text = "Условие";
            // 
            // textBoxUslovie_MDV
            // 
            textBoxUslovie_MDV.BackColor = SystemColors.Menu;
            textBoxUslovie_MDV.Location = new Point(8, 20);
            textBoxUslovie_MDV.Multiline = true;
            textBoxUslovie_MDV.Name = "textBoxUslovie_MDV";
            textBoxUslovie_MDV.ReadOnly = true;
            textBoxUslovie_MDV.Size = new Size(331, 136);
            textBoxUslovie_MDV.TabIndex = 0;
            textBoxUslovie_MDV.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\n-12  -4 -20   5  -5\r\n   2  15   1 -20   7\r\n  15 -15   2  11   5\r\n -19  -9  16   0   1\r\n  17  16   5  12  -8";
            // 
            // groupBoxRes_MDV
            // 
            groupBoxRes_MDV.Controls.Add(dataGridViewResult_MDV);
            groupBoxRes_MDV.Controls.Add(labelNamesThree_MDV);
            groupBoxRes_MDV.Location = new Point(487, 23);
            groupBoxRes_MDV.Name = "groupBoxRes_MDV";
            groupBoxRes_MDV.Size = new Size(225, 295);
            groupBoxRes_MDV.TabIndex = 5;
            groupBoxRes_MDV.TabStop = false;
            groupBoxRes_MDV.Text = "Вывод данных:";
            // 
            // dataGridViewResult_MDV
            // 
            dataGridViewResult_MDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MDV.Location = new Point(20, 46);
            dataGridViewResult_MDV.Name = "dataGridViewResult_MDV";
            dataGridViewResult_MDV.ReadOnly = true;
            dataGridViewResult_MDV.RowHeadersVisible = false;
            dataGridViewResult_MDV.Size = new Size(180, 199);
            dataGridViewResult_MDV.TabIndex = 2;
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
            // buttonDone_MDV
            // 
            buttonDone_MDV.BackColor = Color.Lime;
            buttonDone_MDV.Location = new Point(542, 369);
            buttonDone_MDV.Name = "buttonDone_MDV";
            buttonDone_MDV.Size = new Size(90, 46);
            buttonDone_MDV.TabIndex = 8;
            buttonDone_MDV.Text = "Выполнить";
            buttonDone_MDV.UseVisualStyleBackColor = false;
            buttonDone_MDV.Click += buttonDone_Click;
            // 
            // buttonHelp_MDV
            // 
            buttonHelp_MDV.BackColor = Color.FromArgb(255, 224, 192);
            buttonHelp_MDV.Location = new Point(437, 371);
            buttonHelp_MDV.Name = "buttonHelp_MDV";
            buttonHelp_MDV.Size = new Size(84, 44);
            buttonHelp_MDV.TabIndex = 9;
            buttonHelp_MDV.Text = "Справка";
            buttonHelp_MDV.UseVisualStyleBackColor = false;
            buttonHelp_MDV.Click += buttonHelp_MDV_Click;
            // 
            // groupBoxData_MDV
            // 
            groupBoxData_MDV.Controls.Add(dataGridViewNamedOne_MDV);
            groupBoxData_MDV.Location = new Point(45, 199);
            groupBoxData_MDV.Name = "groupBoxData_MDV";
            groupBoxData_MDV.Size = new Size(252, 239);
            groupBoxData_MDV.TabIndex = 10;
            groupBoxData_MDV.TabStop = false;
            groupBoxData_MDV.Text = "Ввод данных";
            // 
            // dataGridViewNamedOne_MDV
            // 
            dataGridViewNamedOne_MDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNamedOne_MDV.Location = new Point(28, 34);
            dataGridViewNamedOne_MDV.Name = "dataGridViewNamedOne_MDV";
            dataGridViewNamedOne_MDV.ReadOnly = true;
            dataGridViewNamedOne_MDV.RowHeadersVisible = false;
            dataGridViewNamedOne_MDV.Size = new Size(180, 199);
            dataGridViewNamedOne_MDV.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 450);
            Controls.Add(groupBoxData_MDV);
            Controls.Add(buttonHelp_MDV);
            Controls.Add(buttonDone_MDV);
            Controls.Add(groupBoxRes_MDV);
            Controls.Add(groupBoxTask_MDV);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 2 | Новикова В. А.";
            Load += FormMain_Load;
            groupBoxTask_MDV.ResumeLayout(false);
            groupBoxTask_MDV.PerformLayout();
            groupBoxRes_MDV.ResumeLayout(false);
            groupBoxRes_MDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MDV).EndInit();
            groupBoxData_MDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNamedOne_MDV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MDV;
        private TextBox textBoxUslovie_MDV;
        private GroupBox groupBoxRes_MDV;
        private DataGridView dataGridViewResult_MDV;
        private Label labelNamesThree_MDV;
        private Button buttonDone_MDV;
        private Button buttonHelp_MDV;
        private GroupBox groupBoxData_MDV;
        private DataGridView dataGridViewNamedOne_MDV;
    }
}