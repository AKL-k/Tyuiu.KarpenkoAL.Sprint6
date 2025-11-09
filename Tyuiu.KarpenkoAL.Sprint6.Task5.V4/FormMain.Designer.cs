namespace Tyuiu.KarpenkoAL.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelUp = new Panel();
            buttonHelp = new Button();
            buttonFileOpen = new Button();
            buttonDone = new Button();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelResult = new Panel();
            groupBoxResult = new GroupBox();
            dataGridViewResult = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnResult = new DataGridViewTextBoxColumn();
            splitterResult = new Splitter();
            panelLegend = new Panel();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelResult.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            panelLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // panelUp
            // 
            panelUp.Controls.Add(buttonHelp);
            panelUp.Controls.Add(buttonFileOpen);
            panelUp.Controls.Add(buttonDone);
            panelUp.Controls.Add(groupBoxTask);
            panelUp.Dock = DockStyle.Top;
            panelUp.Location = new Point(0, 0);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(1016, 92);
            panelUp.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = Color.DodgerBlue;
            buttonHelp.Location = new Point(876, 25);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(105, 58);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonFileOpen
            // 
            buttonFileOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFileOpen.BackColor = Color.FromArgb(128, 128, 255);
            buttonFileOpen.Location = new Point(736, 23);
            buttonFileOpen.Name = "buttonFileOpen";
            buttonFileOpen.Size = new Size(118, 60);
            buttonFileOpen.TabIndex = 2;
            buttonFileOpen.Text = "Открыть файл";
            buttonFileOpen.UseVisualStyleBackColor = false;
            buttonFileOpen.Click += buttonFileOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.Location = new Point(616, 23);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(99, 60);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(11, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(554, 86);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 20);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(542, 60);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести все целые числа.. Построить диаграмму по этим значениям.";
            // 
            // panelResult
            // 
            panelResult.Controls.Add(groupBoxResult);
            panelResult.Dock = DockStyle.Left;
            panelResult.Location = new Point(0, 92);
            panelResult.Name = "panelResult";
            panelResult.Padding = new Padding(5);
            panelResult.Size = new Size(253, 458);
            panelResult.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Location = new Point(8, 3);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(240, 451);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AllowUserToResizeColumns = false;
            dataGridViewResult.AllowUserToResizeRows = false;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { ColumnNumber, ColumnResult });
            dataGridViewResult.Location = new Point(10, 26);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(220, 417);
            dataGridViewResult.TabIndex = 1;
            // 
            // ColumnNumber
            // 
            ColumnNumber.HeaderText = "ColumnNumber";
            ColumnNumber.MinimumWidth = 6;
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.ReadOnly = true;
            ColumnNumber.Width = 30;
            // 
            // ColumnResult
            // 
            ColumnResult.HeaderText = "Columnres";
            ColumnResult.MinimumWidth = 6;
            ColumnResult.Name = "ColumnResult";
            ColumnResult.ReadOnly = true;
            ColumnResult.Width = 50;
            // 
            // splitterResult
            // 
            splitterResult.Location = new Point(253, 92);
            splitterResult.Name = "splitterResult";
            splitterResult.Size = new Size(4, 458);
            splitterResult.TabIndex = 2;
            splitterResult.TabStop = false;
            // 
            // panelLegend
            // 
            panelLegend.Controls.Add(chartDiag);
            panelLegend.Location = new Point(263, 95);
            panelLegend.Name = "panelLegend";
            panelLegend.Size = new Size(750, 453);
            panelLegend.TabIndex = 3;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            chartDiag.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(0, 0);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(750, 453);
            chartDiag.TabIndex = 0;
            chartDiag.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 550);
            Controls.Add(panelLegend);
            Controls.Add(splitterResult);
            Controls.Add(panelResult);
            Controls.Add(panelUp);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 4 | Карпенко А. Л.";
            panelUp.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelResult.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            panelLegend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Panel panelResult;
        private Splitter splitterResult;
        private Panel panelLegend;
        private Button buttonDone;
        private GroupBox groupBoxResult;
        private DataGridView dataGridViewResult;
        private Button buttonHelp;
        private Button buttonFileOpen;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
    }
}
