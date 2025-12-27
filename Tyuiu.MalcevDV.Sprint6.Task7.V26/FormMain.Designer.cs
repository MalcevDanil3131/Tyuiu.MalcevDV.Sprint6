namespace Tyuiu.MalcevDV.Sprint6.Task7.V26
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            buttonOpen = new Button();
            buttonProcess = new Button();
            buttonInfo = new Button();
            labelIn = new Label();
            labelOut = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.Location = new Point(20, 78);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.Size = new Size(350, 260);
            dataGridViewIn.TabIndex = 0;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.Location = new Point(400, 78);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(350, 260);
            dataGridViewOut.TabIndex = 1;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(20, 20);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(140, 30);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Выбрать файл";
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonProcess
            // 
            buttonProcess.Location = new Point(180, 20);
            buttonProcess.Name = "buttonProcess";
            buttonProcess.Size = new Size(140, 30);
            buttonProcess.TabIndex = 3;
            buttonProcess.Text = "Обработать";
            buttonProcess.Click += buttonProcess_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(750, 20);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(30, 30);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "?";
            buttonInfo.Click += buttonInfo_Click;
            // 
            // labelIn
            // 
            labelIn.AutoSize = true;
            labelIn.Location = new Point(20, 53);
            labelIn.Name = "labelIn";
            labelIn.Size = new Size(101, 15);
            labelIn.TabIndex = 5;
            labelIn.Text = "Входная матрица";
            // 
            // labelOut
            // 
            labelOut.AutoSize = true;
            labelOut.Location = new Point(400, 53);
            labelOut.Name = "labelOut";
            labelOut.Size = new Size(60, 15);
            labelOut.TabIndex = 6;
            labelOut.Text = "Результат";
            // 
            // FormMain
            // 
            ClientSize = new Size(800, 350);
            Controls.Add(dataGridViewIn);
            Controls.Add(dataGridViewOut);
            Controls.Add(buttonOpen);
            Controls.Add(buttonProcess);
            Controls.Add(buttonInfo);
            Controls.Add(labelIn);
            Controls.Add(labelOut);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 26 | Мальцев Д.В.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}