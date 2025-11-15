namespace Tyuiu.KarpenkoAL.Sprint6.Task7.V23
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
            panelButton = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonFileLoad = new Button();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelIn = new Panel();
            groupBoxIn = new GroupBox();
            dataGridViewIn = new DataGridView();
            panelOut = new Panel();
            groupBoxOut = new GroupBox();
            dataGridViewOut = new DataGridView();
            openFileDialogLoadFile = new OpenFileDialog();
            toolTip = new ToolTip(components);
            saveFileDialog = new OpenFileDialog();
            panelButton.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelIn.SuspendLayout();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panelOut.SuspendLayout();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelButton
            // 
            panelButton.Controls.Add(buttonHelp);
            panelButton.Controls.Add(buttonSave);
            panelButton.Controls.Add(buttonDone);
            panelButton.Controls.Add(buttonFileLoad);
            panelButton.Dock = DockStyle.Top;
            panelButton.Location = new Point(0, 0);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(1359, 101);
            panelButton.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackgroundImage = Properties.Resources.d;
            buttonHelp.Location = new Point(1259, 15);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(88, 63);
            buttonHelp.TabIndex = 3;
            toolTip.SetToolTip(buttonHelp, "Информация об выполнителе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            buttonHelp.MouseEnter += buttonHelp_MouseEnter;
            // 
            // buttonSave
            // 
            buttonSave.BackgroundImage = Properties.Resources.imageпп;
            buttonSave.Location = new Point(226, 15);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(84, 63);
            buttonSave.TabIndex = 2;
            toolTip.SetToolTip(buttonSave, "Сохранить результат в файл OutPutFileTask7.csv\r\n");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            buttonSave.MouseEnter += buttonSave_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.BackgroundImage = Properties.Resources.imagef;
            buttonDone.Location = new Point(126, 15);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(79, 63);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Совершить изменение с файлом InPutFileTask7V23.csv по условию задания\r\n\r\n");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonFileLoad
            // 
            buttonFileLoad.BackgroundImage = Properties.Resources.imaged;
            buttonFileLoad.Location = new Point(13, 15);
            buttonFileLoad.Name = "buttonFileLoad";
            buttonFileLoad.Size = new Size(96, 63);
            buttonFileLoad.TabIndex = 0;
            toolTip.SetToolTip(buttonFileLoad, "Выберите нужный файл ");
            buttonFileLoad.UseVisualStyleBackColor = true;
            buttonFileLoad.Click += buttonFileLoad_Click;
            buttonFileLoad.MouseEnter += buttonFileLoad_MouseEnter;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 101);
            panelTask.Name = "panelTask";
            panelTask.Padding = new Padding(5);
            panelTask.Size = new Size(1359, 95);
            panelTask.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Dock = DockStyle.Fill;
            groupBoxTask.Location = new Point(5, 5);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1349, 85);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(11, 27);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(1293, 52);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelIn
            // 
            panelIn.Controls.Add(groupBoxIn);
            panelIn.Dock = DockStyle.Left;
            panelIn.Location = new Point(0, 196);
            panelIn.Name = "panelIn";
            panelIn.Padding = new Padding(5);
            panelIn.Size = new Size(686, 650);
            panelIn.TabIndex = 2;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(dataGridViewIn);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(5, 5);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(676, 640);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.AllowUserToResizeColumns = false;
            dataGridViewIn.AllowUserToResizeRows = false;
            dataGridViewIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.ColumnHeadersVisible = false;
            dataGridViewIn.Location = new Point(9, 23);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(657, 610);
            dataGridViewIn.TabIndex = 0;
            // 
            // panelOut
            // 
            panelOut.Controls.Add(groupBoxOut);
            panelOut.Dock = DockStyle.Fill;
            panelOut.Location = new Point(686, 196);
            panelOut.Name = "panelOut";
            panelOut.Padding = new Padding(5);
            panelOut.Size = new Size(673, 650);
            panelOut.TabIndex = 3;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(dataGridViewOut);
            groupBoxOut.Dock = DockStyle.Fill;
            groupBoxOut.Location = new Point(5, 5);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(663, 640);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.AllowUserToResizeColumns = false;
            dataGridViewOut.AllowUserToResizeRows = false;
            dataGridViewOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.ColumnHeadersVisible = false;
            dataGridViewOut.Location = new Point(8, 23);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(648, 610);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialogLoadFile
            // 
            openFileDialogLoadFile.FileName = "openFileDialogLoadFile";
            // 
            // toolTip
            // 
            toolTip.ForeColor = SystemColors.Highlight;
            toolTip.IsBalloon = true;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "saveFileDialog";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 846);
            Controls.Add(panelOut);
            Controls.Add(panelIn);
            Controls.Add(panelTask);
            Controls.Add(panelButton);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 23 | Карпенко А. Л.";
            panelButton.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelIn.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panelOut.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton;
        private Panel panelTask;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Panel panelIn;
        private GroupBox groupBoxIn;
        private DataGridView dataGridViewIn;
        private Panel panelOut;
        private GroupBox groupBoxOut;
        private DataGridView dataGridViewOut;
        private Button buttonSave;
        private Button buttonDone;
        private Button buttonFileLoad;
        private Button buttonHelp;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogLoadFile;
        private OpenFileDialog saveFileDialog;
    }
}
