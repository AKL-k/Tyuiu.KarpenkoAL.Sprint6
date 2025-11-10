namespace Tyuiu.KarpenkoAL.Sprint6.Task6.V10
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons = new Panel();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonFileLoad = new Button();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelIn = new Panel();
            groupBoxIn = new GroupBox();
            textBoxIn = new TextBox();
            panelOut = new Panel();
            groupBoxOut = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelButtons.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelIn.SuspendLayout();
            groupBoxIn.SuspendLayout();
            panelOut.SuspendLayout();
            groupBoxOut.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonHelp);
            panelButtons.Controls.Add(buttonDone);
            panelButtons.Controls.Add(buttonFileLoad);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1296, 82);
            panelButtons.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackgroundImage = Properties.Resources.d;
            buttonHelp.Location = new Point(1192, 13);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(87, 60);
            buttonHelp.TabIndex = 2;
            toolTip.SetToolTip(buttonHelp, "Информация об выполнителе\r\n");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackgroundImage = Properties.Resources.imagef;
            buttonDone.Location = new Point(138, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(81, 63);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Вывести слова из файла InPutFileTask6V10.txt \r\nв соответствии с условием задания\r\n");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonFileLoad
            // 
            buttonFileLoad.BackgroundImage = Properties.Resources.imaged;
            buttonFileLoad.Location = new Point(15, 12);
            buttonFileLoad.Name = "buttonFileLoad";
            buttonFileLoad.Size = new Size(95, 63);
            buttonFileLoad.TabIndex = 0;
            toolTip.SetToolTip(buttonFileLoad, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonFileLoad.UseVisualStyleBackColor = true;
            buttonFileLoad.Click += buttonFileLoad_Click;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 82);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1296, 99);
            panelTask.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(9, 8);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1276, 82);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Location = new Point(3, 23);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(1270, 56);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelIn
            // 
            panelIn.Controls.Add(groupBoxIn);
            panelIn.Dock = DockStyle.Left;
            panelIn.Location = new Point(0, 181);
            panelIn.Name = "panelIn";
            panelIn.Size = new Size(633, 420);
            panelIn.TabIndex = 2;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(textBoxIn);
            groupBoxIn.Location = new Point(7, 7);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(621, 408);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 23);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(615, 382);
            textBoxIn.TabIndex = 0;
            // 
            // panelOut
            // 
            panelOut.Controls.Add(groupBoxOut);
            panelOut.Dock = DockStyle.Right;
            panelOut.Location = new Point(632, 181);
            panelOut.Name = "panelOut";
            panelOut.Size = new Size(664, 420);
            panelOut.TabIndex = 3;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(textBoxOut);
            groupBoxOut.Location = new Point(6, 7);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(651, 409);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод";
            // 
            // textBoxOut
            // 
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(3, 23);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(645, 383);
            textBoxOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTip
            // 
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 601);
            Controls.Add(panelOut);
            Controls.Add(panelIn);
            Controls.Add(panelTask);
            Controls.Add(panelButtons);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 10 | Карпенко А. Л.";
            panelButtons.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelIn.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            panelOut.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            groupBoxOut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Panel panelTask;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Panel panelIn;
        private Panel panelOut;
        private GroupBox groupBoxIn;
        private TextBox textBoxIn;
        private GroupBox groupBoxOut;
        private TextBox textBoxOut;
        private Button buttonFileLoad;
        private Button buttonDone;
        private Button buttonHelp;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}
