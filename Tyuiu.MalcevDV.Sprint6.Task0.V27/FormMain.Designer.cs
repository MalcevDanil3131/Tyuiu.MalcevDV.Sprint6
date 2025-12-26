namespace Tyuiu.MalcevDV.Sprint6.Task0.V27
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
            groupBoxCondition_MDV = new GroupBox();
            pictureBoxCondition_MDV = new PictureBox();
            textBox1 = new TextBox();
            groupBoxVars_MDV = new GroupBox();
            labelVarX_MDV = new Label();
            textBoxVarX_MDV = new TextBox();
            groupBoxResult_MDV = new GroupBox();
            buttonInitials_MDV = new Button();
            buttonRun_MDV = new Button();
            label1 = new Label();
            textBoxResult_MDV = new TextBox();
            groupBoxCondition_MDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_MDV).BeginInit();
            groupBoxVars_MDV.SuspendLayout();
            groupBoxResult_MDV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_MDV
            // 
            groupBoxCondition_MDV.Controls.Add(pictureBoxCondition_MDV);
            groupBoxCondition_MDV.Controls.Add(textBox1);
            groupBoxCondition_MDV.Location = new Point(13, 12);
            groupBoxCondition_MDV.Name = "groupBoxCondition_MDV";
            groupBoxCondition_MDV.Size = new Size(776, 269);
            groupBoxCondition_MDV.TabIndex = 1;
            groupBoxCondition_MDV.TabStop = false;
            groupBoxCondition_MDV.Text = "Условие";
            // 
            // pictureBoxCondition_MDV
            // 
            pictureBoxCondition_MDV.BackgroundImage = (Image)resources.GetObject("pictureBoxCondition_MDV.BackgroundImage");
            pictureBoxCondition_MDV.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCondition_MDV.InitialImage = (Image)resources.GetObject("pictureBoxCondition_MDV.InitialImage");
            pictureBoxCondition_MDV.Location = new Point(585, 33);
            pictureBoxCondition_MDV.Name = "pictureBoxCondition_MDV";
            pictureBoxCondition_MDV.Size = new Size(166, 65);
            pictureBoxCondition_MDV.TabIndex = 1;
            pictureBoxCondition_MDV.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(512, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxVars_MDV
            // 
            groupBoxVars_MDV.Controls.Add(labelVarX_MDV);
            groupBoxVars_MDV.Controls.Add(textBoxVarX_MDV);
            groupBoxVars_MDV.Location = new Point(13, 304);
            groupBoxVars_MDV.Name = "groupBoxVars_MDV";
            groupBoxVars_MDV.Size = new Size(521, 134);
            groupBoxVars_MDV.TabIndex = 2;
            groupBoxVars_MDV.TabStop = false;
            groupBoxVars_MDV.Text = "Ввод данных";
            // 
            // labelVarX_MDV
            // 
            labelVarX_MDV.AutoSize = true;
            labelVarX_MDV.Location = new Point(183, 57);
            labelVarX_MDV.Name = "labelVarX_MDV";
            labelVarX_MDV.Size = new Size(89, 15);
            labelVarX_MDV.TabIndex = 1;
            labelVarX_MDV.Text = "Переменная X:";
            // 
            // textBoxVarX_MDV
            // 
            textBoxVarX_MDV.Location = new Point(183, 75);
            textBoxVarX_MDV.Name = "textBoxVarX_MDV";
            textBoxVarX_MDV.Size = new Size(135, 23);
            textBoxVarX_MDV.TabIndex = 0;
            textBoxVarX_MDV.KeyPress += textBoxVarX_MDV_KeyPress;
            // 
            // groupBoxResult_MDV
            // 
            groupBoxResult_MDV.Controls.Add(buttonInitials_MDV);
            groupBoxResult_MDV.Controls.Add(buttonRun_MDV);
            groupBoxResult_MDV.Controls.Add(label1);
            groupBoxResult_MDV.Controls.Add(textBoxResult_MDV);
            groupBoxResult_MDV.Location = new Point(564, 315);
            groupBoxResult_MDV.Name = "groupBoxResult_MDV";
            groupBoxResult_MDV.Size = new Size(224, 123);
            groupBoxResult_MDV.TabIndex = 3;
            groupBoxResult_MDV.TabStop = false;
            groupBoxResult_MDV.Text = "Вывод данных";
            // 
            // buttonInitials_MDV
            // 
            buttonInitials_MDV.Location = new Point(16, 75);
            buttonInitials_MDV.Name = "buttonInitials_MDV";
            buttonInitials_MDV.Size = new Size(43, 41);
            buttonInitials_MDV.TabIndex = 4;
            buttonInitials_MDV.Text = "?";
            buttonInitials_MDV.UseVisualStyleBackColor = true;
            buttonInitials_MDV.Click += buttonInitials_MDV_Click;
            // 
            // buttonRun_MDV
            // 
            buttonRun_MDV.Location = new Point(78, 75);
            buttonRun_MDV.Name = "buttonRun_MDV";
            buttonRun_MDV.Size = new Size(122, 41);
            buttonRun_MDV.TabIndex = 3;
            buttonRun_MDV.Text = "Выполнить";
            buttonRun_MDV.UseVisualStyleBackColor = true;
            buttonRun_MDV.Click += buttonRun_MDV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Результат:";
            label1.Click += label1_Click;
            // 
            // textBoxResult_MDV
            // 
            textBoxResult_MDV.Location = new Point(16, 46);
            textBoxResult_MDV.Name = "textBoxResult_MDV";
            textBoxResult_MDV.ReadOnly = true;
            textBoxResult_MDV.Size = new Size(184, 23);
            textBoxResult_MDV.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult_MDV);
            Controls.Add(groupBoxVars_MDV);
            Controls.Add(groupBoxCondition_MDV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 27 | Мальцев Д.В.";
            Load += Form1_Load;
            groupBoxCondition_MDV.ResumeLayout(false);
            groupBoxCondition_MDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_MDV).EndInit();
            groupBoxVars_MDV.ResumeLayout(false);
            groupBoxVars_MDV.PerformLayout();
            groupBoxResult_MDV.ResumeLayout(false);
            groupBoxResult_MDV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_MDV;
        private PictureBox pictureBoxCondition_MDV;
        private TextBox textBox1;
        private GroupBox groupBoxVars_MDV;
        private TextBox textBoxVarX_MDV;
        private Label label1;
        private Label labelVarX_MDV;
        private GroupBox groupBoxResult_MDV;
        private TextBox textBoxResult_MDV;
        private Button buttonInitials_MDV;
        private Button buttonRun_MDV;
    }
}
