using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.MalcevDV.Sprint6.Task1.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelFormula = new Label();
            labelStart = new Label();
            textBoxStart = new TextBox();
            labelStop = new Label();
            textBoxStop = new TextBox();
            buttonHelp = new Button();
            buttonCalculate = new Button();
            richTextBoxResult = new RichTextBox();
            groupBoxCondition_DDE = new GroupBox();
            groupBoxInput_DDE = new GroupBox();
            groupBoxOutput_DDE = new GroupBox();
            groupBoxCondition_DDE.SuspendLayout();
            groupBoxInput_DDE.SuspendLayout();
            groupBoxOutput_DDE.SuspendLayout();
            SuspendLayout();
            // 
            // labelFormula
            // 
            labelFormula.AutoSize = true;
            labelFormula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula.Location = new Point(7, 19);
            labelFormula.Margin = new Padding(4, 0, 4, 0);
            labelFormula.Name = "labelFormula";
            labelFormula.Size = new Size(254, 20);
            labelFormula.TabIndex = 1;
            labelFormula.Text = "F(x) = (5x + 2.5)/(sin(x) + 2) + 2x + 2";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(7, 19);
            labelStart.Margin = new Padding(4, 0, 4, 0);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(72, 15);
            labelStart.TabIndex = 3;
            labelStart.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(7, 36);
            textBoxStart.Margin = new Padding(4, 3, 4, 3);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(129, 23);
            textBoxStart.TabIndex = 4;
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(144, 19);
            labelStop.Margin = new Padding(4, 0, 4, 0);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(75, 15);
            labelStop.TabIndex = 5;
            labelStop.Text = "Конец шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(144, 36);
            textBoxStop.Margin = new Padding(4, 3, 4, 3);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(131, 23);
            textBoxStop.TabIndex = 6;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.ForeColor = SystemColors.ActiveCaptionText;
            buttonHelp.Location = new Point(302, 365);
            buttonHelp.Margin = new Padding(4, 3, 4, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(119, 27);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = SystemColors.ActiveCaption;
            buttonCalculate.ForeColor = Color.Black;
            buttonCalculate.Location = new Point(302, 332);
            buttonCalculate.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(119, 27);
            buttonCalculate.TabIndex = 8;
            buttonCalculate.Text = "Выполнить";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.BackColor = SystemColors.ScrollBar;
            richTextBoxResult.Location = new Point(7, 22);
            richTextBoxResult.Margin = new Padding(4, 3, 4, 3);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(274, 350);
            richTextBoxResult.TabIndex = 10;
            richTextBoxResult.Text = "";
            richTextBoxResult.WordWrap = false;
            // 
            // groupBoxCondition_DDE
            // 
            groupBoxCondition_DDE.Controls.Add(labelFormula);
            groupBoxCondition_DDE.Location = new Point(12, 12);
            groupBoxCondition_DDE.Name = "groupBoxCondition_DDE";
            groupBoxCondition_DDE.Size = new Size(409, 307);
            groupBoxCondition_DDE.TabIndex = 11;
            groupBoxCondition_DDE.TabStop = false;
            groupBoxCondition_DDE.Text = "Условие";
            // 
            // groupBoxInput_DDE
            // 
            groupBoxInput_DDE.Controls.Add(labelStart);
            groupBoxInput_DDE.Controls.Add(labelStop);
            groupBoxInput_DDE.Controls.Add(textBoxStart);
            groupBoxInput_DDE.Controls.Add(textBoxStop);
            groupBoxInput_DDE.Location = new Point(12, 325);
            groupBoxInput_DDE.Name = "groupBoxInput_DDE";
            groupBoxInput_DDE.Size = new Size(283, 65);
            groupBoxInput_DDE.TabIndex = 12;
            groupBoxInput_DDE.TabStop = false;
            groupBoxInput_DDE.Text = "Ввод данных ";
            // 
            // groupBoxOutput_DDE
            // 
            groupBoxOutput_DDE.Controls.Add(richTextBoxResult);
            groupBoxOutput_DDE.Location = new Point(427, 12);
            groupBoxOutput_DDE.Name = "groupBoxOutput_DDE";
            groupBoxOutput_DDE.Size = new Size(288, 378);
            groupBoxOutput_DDE.TabIndex = 13;
            groupBoxOutput_DDE.TabStop = false;
            groupBoxOutput_DDE.Text = "Вывод данных ";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 402);
            Controls.Add(groupBoxOutput_DDE);
            Controls.Add(buttonCalculate);
            Controls.Add(groupBoxInput_DDE);
            Controls.Add(groupBoxCondition_DDE);
            Controls.Add(buttonHelp);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | Tаск 1 | Вариант 2 | Мальцев Д.В. ";
            groupBoxCondition_DDE.ResumeLayout(false);
            groupBoxCondition_DDE.PerformLayout();
            groupBoxInput_DDE.ResumeLayout(false);
            groupBoxInput_DDE.PerformLayout();
            groupBoxOutput_DDE.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private GroupBox groupBoxCondition_DDE;
        private GroupBox groupBoxInput_DDE;
        private GroupBox groupBoxOutput_DDE;
    }
}