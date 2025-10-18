using System.Resources;
using System.Windows.Forms;

namespace Tyuiu.KarpenkoAL.Sprint6.Task0.V17
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
            pictureBoxFormula = new PictureBox();
            groupBoxValuesInput = new GroupBox();
            groupBoxOfValue_x = new GroupBox();
            textBoxValue_x_Input = new TextBox();
            groupBoxWithAnswer = new GroupBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxWithRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxValuesInput.SuspendLayout();
            groupBoxOfValue_x.SuspendLayout();
            groupBoxWithAnswer.SuspendLayout();
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
            groupBoxWithRequirements.Size = new Size(273, 172);
            groupBoxWithRequirements.TabIndex = 0;
            groupBoxWithRequirements.TabStop = false;
            groupBoxWithRequirements.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(7, 28);
            textBoxTask.Margin = new Padding(3, 4, 3, 4);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(266, 135);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = Properties.Resources.pictureBoxFormula_Image;
            pictureBoxFormula.Location = new Point(412, 61);
            pictureBoxFormula.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(71, 54);
            pictureBoxFormula.TabIndex = 2;
            pictureBoxFormula.TabStop = false;
            // 
            // groupBoxValuesInput
            // 
            groupBoxValuesInput.Controls.Add(groupBoxOfValue_x);
            groupBoxValuesInput.Location = new Point(14, 196);
            groupBoxValuesInput.Margin = new Padding(3, 4, 3, 4);
            groupBoxValuesInput.Name = "groupBoxValuesInput";
            groupBoxValuesInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxValuesInput.Size = new Size(347, 124);
            groupBoxValuesInput.TabIndex = 3;
            groupBoxValuesInput.TabStop = false;
            groupBoxValuesInput.Text = "Ввод данных";
            // 
            // groupBoxOfValue_x
            // 
            groupBoxOfValue_x.Controls.Add(textBoxValue_x_Input);
            groupBoxOfValue_x.Location = new Point(7, 29);
            groupBoxOfValue_x.Margin = new Padding(3, 4, 3, 4);
            groupBoxOfValue_x.Name = "groupBoxOfValue_x";
            groupBoxOfValue_x.Padding = new Padding(3, 4, 3, 4);
            groupBoxOfValue_x.Size = new Size(118, 80);
            groupBoxOfValue_x.TabIndex = 0;
            groupBoxOfValue_x.TabStop = false;
            groupBoxOfValue_x.Text = "Переменная X:";
            // 
            // textBoxValue_x_Input
            // 
            textBoxValue_x_Input.Location = new Point(1, 53);
            textBoxValue_x_Input.Margin = new Padding(3, 4, 3, 4);
            textBoxValue_x_Input.Name = "textBoxValue_x_Input";
            textBoxValue_x_Input.Size = new Size(117, 27);
            textBoxValue_x_Input.TabIndex = 0;
            textBoxValue_x_Input.KeyPress += NumberInput;
            // 
            // groupBoxWithAnswer
            // 
            groupBoxWithAnswer.Controls.Add(groupBoxResult);
            groupBoxWithAnswer.Location = new Point(368, 196);
            groupBoxWithAnswer.Margin = new Padding(3, 4, 3, 4);
            groupBoxWithAnswer.Name = "groupBoxWithAnswer";
            groupBoxWithAnswer.Padding = new Padding(3, 4, 3, 4);
            groupBoxWithAnswer.Size = new Size(168, 124);
            groupBoxWithAnswer.TabIndex = 4;
            groupBoxWithAnswer.TabStop = false;
            groupBoxWithAnswer.Text = "Вывод данных:";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(7, 29);
            groupBoxResult.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult.Size = new Size(154, 60);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(0, 33);
            textBoxResult.Margin = new Padding(3, 4, 3, 4);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(154, 27);
            textBoxResult.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(424, 359);
            buttonDone.Margin = new Padding(3, 4, 3, 4);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(112, 57);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(368, 359);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(49, 57);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 432);
            Controls.Add(buttonHelp);
            Controls.Add(pictureBoxFormula);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxWithAnswer);
            Controls.Add(groupBoxValuesInput);
            Controls.Add(groupBoxWithRequirements);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 17 | Карпенко А. Л.";
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxValuesInput.ResumeLayout(false);
            groupBoxOfValue_x.ResumeLayout(false);
            groupBoxOfValue_x.PerformLayout();
            groupBoxWithAnswer.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWithRequirements;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxValuesInput;
        private GroupBox groupBoxWithAnswer;
        private GroupBox groupBoxOfValue_x;
        private TextBox textBoxValue_x_Input;
        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private TextBox textBoxTask;
    }
}
