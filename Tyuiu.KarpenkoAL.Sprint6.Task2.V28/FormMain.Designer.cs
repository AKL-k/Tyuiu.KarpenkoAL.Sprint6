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
            groupBoxDataOutput = new GroupBox();
            groupBoxResult = new GroupBox();
            chartResult = new FormsPlot();
            DataGridViewFunctionTab_X = new DataGridViewTextBoxColumn();
            DataGridViewFunctionTab_Fx = new DataGridViewTextBoxColumn();
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
            groupBoxWithRequirements.Location = new Point(14, 16);
            groupBoxWithRequirements.Margin = new Padding(3, 4, 3, 4);
            groupBoxWithRequirements.Name = "groupBoxWithRequirements";
            groupBoxWithRequirements.Padding = new Padding(3, 4, 3, 4);
            groupBoxWithRequirements.Size = new Size(523, 172);
            groupBoxWithRequirements.TabIndex = 0;
            groupBoxWithRequirements.TabStop = false;
            groupBoxWithRequirements.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(7, 29);
            textBoxTask.Margin = new Padding(3, 4, 3, 4);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(509, 133);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать фукнцию ((sin(x)-(2*x))/((3*x)-1))+sin(x)-(3*x)+2 на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции";
            // 
            // groupBoxDataInput
            // 
            groupBoxDataInput.Controls.Add(groupBoxStopStep);
            groupBoxDataInput.Controls.Add(groupBoxStartStep);
            groupBoxDataInput.Location = new Point(21, 279);
            groupBoxDataInput.Margin = new Padding(3, 4, 3, 4);
            groupBoxDataInput.Name = "groupBoxDataInput";
            groupBoxDataInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxDataInput.Size = new Size(256, 124);
            groupBoxDataInput.TabIndex = 1;
            groupBoxDataInput.TabStop = false;
            groupBoxDataInput.Text = "Ввод данных:";
            // 
            // groupBoxStopStep
            // 
            groupBoxStopStep.Controls.Add(textBoxStopStep);
            groupBoxStopStep.Location = new Point(131, 29);
            groupBoxStopStep.Margin = new Padding(3, 4, 3, 4);
            groupBoxStopStep.Name = "groupBoxStopStep";
            groupBoxStopStep.Padding = new Padding(3, 4, 3, 4);
            groupBoxStopStep.Size = new Size(118, 87);
            groupBoxStopStep.TabIndex = 1;
            groupBoxStopStep.TabStop = false;
            groupBoxStopStep.Text = "Конец шага";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(0, 29);
            textBoxStopStep.Margin = new Padding(3, 4, 3, 4);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(117, 27);
            textBoxStopStep.TabIndex = 0;
            textBoxStopStep.KeyPress += NumberInput;
            // 
            // groupBoxStartStep
            // 
            groupBoxStartStep.Controls.Add(textBoxStartStep);
            groupBoxStartStep.Location = new Point(7, 29);
            groupBoxStartStep.Margin = new Padding(3, 4, 3, 4);
            groupBoxStartStep.Name = "groupBoxStartStep";
            groupBoxStartStep.Padding = new Padding(3, 4, 3, 4);
            groupBoxStartStep.Size = new Size(118, 87);
            groupBoxStartStep.TabIndex = 0;
            groupBoxStartStep.TabStop = false;
            groupBoxStartStep.Text = "Старт шага";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(0, 29);
            textBoxStartStep.Margin = new Padding(3, 4, 3, 4);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(117, 27);
            textBoxStartStep.TabIndex = 0;
            textBoxStartStep.KeyPress += NumberInput;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            buttonHelp.Location = new Point(336, 308);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 57);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = System.Drawing.Color.LawnGreen;
            buttonDone.Location = new Point(418, 308);
            buttonDone.Margin = new Padding(3, 4, 3, 4);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(112, 57);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // dataGridViewFunctionTab
            // 
            dataGridViewFunctionTab.AllowUserToResizeColumns = false;
            dataGridViewFunctionTab.AllowUserToResizeRows = false;
            dataGridViewFunctionTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunctionTab.Columns.AddRange(new DataGridViewColumn[] { DataGridViewFunctionTab_X, DataGridViewFunctionTab_Fx });
            dataGridViewFunctionTab.Location = new Point(7, 29);
            dataGridViewFunctionTab.Margin = new Padding(3, 4, 3, 4);
            dataGridViewFunctionTab.Name = "dataGridViewFunctionTab";
            dataGridViewFunctionTab.RowHeadersVisible = false;
            dataGridViewFunctionTab.RowHeadersWidth = 51;
            dataGridViewFunctionTab.Size = new Size(137, 328);
            dataGridViewFunctionTab.TabIndex = 4;
            // 
            // groupBoxDataOutput
            // 
            groupBoxDataOutput.Controls.Add(groupBoxResult);
            groupBoxDataOutput.Location = new Point(544, 16);
            groupBoxDataOutput.Margin = new Padding(3, 4, 3, 4);
            groupBoxDataOutput.Name = "groupBoxDataOutput";
            groupBoxDataOutput.Padding = new Padding(3, 4, 3, 4);
            groupBoxDataOutput.Size = new Size(618, 387);
            groupBoxDataOutput.TabIndex = 5;
            groupBoxDataOutput.TabStop = false;
            groupBoxDataOutput.Text = "Вывод данных";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartResult);
            groupBoxResult.Controls.Add(dataGridViewFunctionTab);
            groupBoxResult.Location = new Point(0, 29);
            groupBoxResult.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult.Size = new Size(618, 357);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат:";
            // 
            // chartResult
            // 
            chartResult.DisplayScale = 1.25F;
            chartResult.Location = new Point(151, 29);
            chartResult.Margin = new Padding(3, 4, 3, 4);
            chartResult.Name = "chartResult";
            chartResult.Size = new Size(467, 328);
            chartResult.TabIndex = 5;
            // 
            // DataGridViewFunctionTab_X
            // 
            DataGridViewFunctionTab_X.HeaderText = "X";
            DataGridViewFunctionTab_X.MinimumWidth = 6;
            DataGridViewFunctionTab_X.Name = "DataGridViewFunctionTab_X";
            DataGridViewFunctionTab_X.ReadOnly = true;
            DataGridViewFunctionTab_X.Width = 50;
            // 
            // DataGridViewFunctionTab_Fx
            // 
            DataGridViewFunctionTab_Fx.HeaderText = "F(X)";
            DataGridViewFunctionTab_Fx.MinimumWidth = 6;
            DataGridViewFunctionTab_Fx.Name = "DataGridViewFunctionTab_Fx";
            DataGridViewFunctionTab_Fx.ReadOnly = true;
            DataGridViewFunctionTab_Fx.Width = 60;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 419);
            Controls.Add(groupBoxDataOutput);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxDataInput);
            Controls.Add(groupBoxWithRequirements);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
        private FormsPlot chartResult;
        private DataGridViewTextBoxColumn DataGridViewFunctionTab_X;
        private DataGridViewTextBoxColumn DataGridViewFunctionTab_Fx;
    }
}
