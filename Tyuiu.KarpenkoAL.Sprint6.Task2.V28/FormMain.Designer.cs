using ScottPlot;
using ScottPlot.WinForms;
using System.Windows.Forms;

namespace Tyuiu.KarpenkoAL.Sprint6.Task2.V28
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
            groupBoxDataInput = new GroupBox();
            groupBoxStopStep = new GroupBox();
            textBoxStopStep = new TextBox();
            groupBoxStartStep = new GroupBox();
            textBoxStartStep = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            dataGridViewFunctionTab = new DataGridView();
            DataGridViewFunctionTab_X = new DataGridViewTextBoxColumn();
            DataGridViewFunctionTab_Fx = new DataGridViewTextBoxColumn();
            groupBoxDataOutput = new GroupBox();
            groupBoxResult = new GroupBox();
            chartResult = new FormsPlot();
            groupBoxWithRequirements.SuspendLayout();
            groupBoxDataInput.SuspendLayout();
            groupBoxStopStep.SuspendLayout();
            groupBoxStartStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunctionTab).BeginInit();
            groupBoxDataOutput.SuspendLayout();
            groupBoxResult.SuspendLayout();
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
            textBoxTask.Text = "Протабулировать фукнцию ((sin(x)-(2*x))/((3*x)-1))+sin(x)-(3*x)+2 на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции";
            // 
            // groupBoxDataInput
            // 
            groupBoxDataInput.Controls.Add(groupBoxStopStep);
            groupBoxDataInput.Controls.Add(groupBoxStartStep);
            groupBoxDataInput.Location = new Point(18, 209);
            groupBoxDataInput.Name = "groupBoxDataInput";
            groupBoxDataInput.Size = new Size(224, 93);
            groupBoxDataInput.TabIndex = 1;
            groupBoxDataInput.TabStop = false;
            groupBoxDataInput.Text = "Ввод данных:";
            // 
            // groupBoxStopStep
            // 
            groupBoxStopStep.Controls.Add(textBoxStopStep);
            groupBoxStopStep.Location = new Point(115, 22);
            groupBoxStopStep.Name = "groupBoxStopStep";
            groupBoxStopStep.Size = new Size(103, 65);
            groupBoxStopStep.TabIndex = 1;
            groupBoxStopStep.TabStop = false;
            groupBoxStopStep.Text = "Конец шага";
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
            groupBoxStartStep.Size = new Size(103, 65);
            groupBoxStartStep.TabIndex = 0;
            groupBoxStartStep.TabStop = false;
            groupBoxStartStep.Text = "Старт шага";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(0, 22);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(103, 23);
            textBoxStartStep.TabIndex = 0;
            textBoxStartStep.KeyPress += NumberInput;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            buttonHelp.Location = new Point(294, 231);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(66, 43);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = System.Drawing.Color.LawnGreen;
            buttonDone.Location = new Point(366, 231);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 43);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // dataGridViewFunctionTab
            // 
            dataGridViewFunctionTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunctionTab.Columns.AddRange(new DataGridViewColumn[] { DataGridViewFunctionTab_X, DataGridViewFunctionTab_Fx });
            dataGridViewFunctionTab.Location = new Point(6, 22);
            dataGridViewFunctionTab.Name = "dataGridViewFunctionTab";
            dataGridViewFunctionTab.RowHeadersVisible = false;
            dataGridViewFunctionTab.Size = new Size(120, 246);
            dataGridViewFunctionTab.TabIndex = 4;
            // 
            // DataGridViewFunctionTab_X
            // 
            DataGridViewFunctionTab_X.HeaderText = "X";
            DataGridViewFunctionTab_X.Name = "DataGridViewFunctionTab_X";
            DataGridViewFunctionTab_X.ReadOnly = true;
            DataGridViewFunctionTab_X.Width = 50;
            // 
            // DataGridViewFunctionTab_Fx
            // 
            DataGridViewFunctionTab_Fx.HeaderText = "F(X)";
            DataGridViewFunctionTab_Fx.Name = "DataGridViewFunctionTab_Fx";
            DataGridViewFunctionTab_Fx.ReadOnly = true;
            DataGridViewFunctionTab_Fx.Width = 50;
            // 
            // groupBoxDataOutput
            // 
            groupBoxDataOutput.Controls.Add(groupBoxResult);
            groupBoxDataOutput.Location = new Point(476, 12);
            groupBoxDataOutput.Name = "groupBoxDataOutput";
            groupBoxDataOutput.Size = new Size(541, 290);
            groupBoxDataOutput.TabIndex = 5;
            groupBoxDataOutput.TabStop = false;
            groupBoxDataOutput.Text = "Вывод данных";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartResult);
            groupBoxResult.Controls.Add(dataGridViewFunctionTab);
            groupBoxResult.Location = new Point(0, 22);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(541, 268);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат:";
            // 
            // chartResult
            // 
            chartResult.Location = new Point(132, 22);
            chartResult.Name = "chartResult";
            chartResult.Size = new Size(409, 246);
            chartResult.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 314);
            Controls.Add(groupBoxDataOutput);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxDataInput);
            Controls.Add(groupBoxWithRequirements);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 28 | Карпенко А. Л.";
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            groupBoxDataInput.ResumeLayout(false);
            groupBoxStopStep.ResumeLayout(false);
            groupBoxStopStep.PerformLayout();
            groupBoxStartStep.ResumeLayout(false);
            groupBoxStartStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunctionTab).EndInit();
            groupBoxDataOutput.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWithRequirements;
        private TextBox textBoxTask;
        private GroupBox groupBoxDataInput;
        private GroupBox groupBoxStartStep;
        private GroupBox groupBoxStopStep;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private Button buttonHelp;
        private Button buttonDone;
        private DataGridView dataGridViewFunctionTab;
        private GroupBox groupBoxDataOutput;
        private GroupBox groupBoxResult;
        private DataGridViewTextBoxColumn DataGridViewFunctionTab_X;
        private DataGridViewTextBoxColumn DataGridViewFunctionTab_Fx;
        private FormsPlot chartResult;
    }
}
