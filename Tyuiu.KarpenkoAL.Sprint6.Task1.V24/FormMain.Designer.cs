using System.Windows.Forms;

namespace Tyuiu.KarpenkoAL.Sprint6.Task1.V24
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
            groupBoxWithRequirements = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxStepsInput = new GroupBox();
            groupBoxStopStep = new GroupBox();
            textBoxStopStep = new TextBox();
            groupBoxStartStep = new GroupBox();
            textBoxStartStep = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxAnswer1 = new GroupBox();
            groupBoxAnswer2 = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxWithRequirements.SuspendLayout();
            groupBoxStepsInput.SuspendLayout();
            groupBoxStopStep.SuspendLayout();
            groupBoxStartStep.SuspendLayout();
            groupBoxAnswer1.SuspendLayout();
            groupBoxAnswer2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxWithRequirements
            // 
            groupBoxWithRequirements.Controls.Add(textBoxTask);
            groupBoxWithRequirements.Location = new Point(12, 12);
            groupBoxWithRequirements.Name = "groupBoxWithRequirements";
            groupBoxWithRequirements.Size = new Size(458, 129);
            groupBoxWithRequirements.TabIndex = 0;
            groupBoxWithRequirements.TabStop = false;
            groupBoxWithRequirements.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(446, 101);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию (sin(x) / x + 1.7) - cos(x)*4x - 6  на заданном диапазоне.\r\nРезультат вывести в виде таблицы. ";
            // 
            // groupBoxStepsInput
            // 
            groupBoxStepsInput.Controls.Add(groupBoxStopStep);
            groupBoxStepsInput.Controls.Add(groupBoxStartStep);
            groupBoxStepsInput.Location = new Point(12, 147);
            groupBoxStepsInput.Name = "groupBoxStepsInput";
            groupBoxStepsInput.Size = new Size(224, 93);
            groupBoxStepsInput.TabIndex = 1;
            groupBoxStepsInput.TabStop = false;
            groupBoxStepsInput.Text = "Ввод данных";
            // 
            // groupBoxStopStep
            // 
            groupBoxStopStep.Controls.Add(textBoxStopStep);
            groupBoxStopStep.Location = new Point(115, 22);
            groupBoxStopStep.Name = "groupBoxStopStep";
            groupBoxStopStep.Size = new Size(103, 60);
            groupBoxStopStep.TabIndex = 1;
            groupBoxStopStep.TabStop = false;
            groupBoxStopStep.Text = "Конец шага:";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(0, 22);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(103, 23);
            textBoxStopStep.TabIndex = 0;
            textBoxStopStep.KeyPress += NumberInput;
            // 
            // groupBoxStartStep
            // 
            groupBoxStartStep.Controls.Add(textBoxStartStep);
            groupBoxStartStep.Location = new Point(6, 22);
            groupBoxStartStep.Name = "groupBoxStartStep";
            groupBoxStartStep.Size = new Size(103, 60);
            groupBoxStartStep.TabIndex = 0;
            groupBoxStartStep.TabStop = false;
            groupBoxStartStep.Text = "Старт шага:";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(0, 22);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(103, 23);
            textBoxStartStep.TabIndex = 0;
            textBoxStartStep.KeyPress += NumberInput;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LawnGreen;
            buttonDone.Location = new Point(372, 197);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 43);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MediumTurquoise;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(300, 197);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(66, 43);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxAnswer1
            // 
            groupBoxAnswer1.Controls.Add(groupBoxAnswer2);
            groupBoxAnswer1.Location = new Point(476, 12);
            groupBoxAnswer1.Name = "groupBoxAnswer1";
            groupBoxAnswer1.Size = new Size(232, 292);
            groupBoxAnswer1.TabIndex = 4;
            groupBoxAnswer1.TabStop = false;
            groupBoxAnswer1.Text = "Вывод данных";
            // 
            // groupBoxAnswer2
            // 
            groupBoxAnswer2.Controls.Add(textBoxResult);
            groupBoxAnswer2.Location = new Point(0, 22);
            groupBoxAnswer2.Name = "groupBoxAnswer2";
            groupBoxAnswer2.Size = new Size(232, 270);
            groupBoxAnswer2.TabIndex = 0;
            groupBoxAnswer2.TabStop = false;
            groupBoxAnswer2.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(220, 242);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 316);
            Controls.Add(groupBoxAnswer1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxStepsInput);
            Controls.Add(groupBoxWithRequirements);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 24 | Карпенко А. Л.";
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            groupBoxStepsInput.ResumeLayout(false);
            groupBoxStopStep.ResumeLayout(false);
            groupBoxStopStep.PerformLayout();
            groupBoxStartStep.ResumeLayout(false);
            groupBoxStartStep.PerformLayout();
            groupBoxAnswer1.ResumeLayout(false);
            groupBoxAnswer2.ResumeLayout(false);
            groupBoxAnswer2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWithRequirements;
        private TextBox textBoxTask;
        private GroupBox groupBoxStepsInput;
        private GroupBox groupBoxStartStep;
        private TextBox textBoxStartStep;
        private GroupBox groupBoxStopStep;
        private TextBox textBoxStopStep;
        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBoxAnswer1;
        private GroupBox groupBoxAnswer2;
        private TextBox textBoxResult;


    }
}
