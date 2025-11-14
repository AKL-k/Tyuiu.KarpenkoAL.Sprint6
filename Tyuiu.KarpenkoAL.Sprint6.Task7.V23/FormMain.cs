using System.IO;
using System.Text;
using Tyuiu.KarpenkoAL.Sprint6.Task7.V23.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.KarpenkoAL.Sprint6.Task7.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            buttonDone.Enabled = false;
            buttonSave.Enabled = false;
        }

        DataService ds = new DataService();

        string? path;

        private void buttonFileLoad_Click(object sender, EventArgs e)
        {
            openFileDialogLoadFile.ShowDialog();
            path = openFileDialogLoadFile.FileName;

            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length; 

            int[,] originalMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';'); 
                for (int j = 0; j < columns; j++)
                {
                    originalMatrix[i, j] = int.Parse(values[j]);
                }
            }

            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = columns;
            dataGridViewOut.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn.Columns[i].Width = 50;
                dataGridViewOut.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = originalMatrix[r, c];
                }
            }

            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] modifiedMatrix = ds.GetMatrix(path!);

            int rows = modifiedMatrix.GetLength(0);
            int columns = modifiedMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = modifiedMatrix[r, c];
                }
            }

            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FileName = "OutPutFileTask7.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string tempPath = Path.GetTempPath();
                string sourceFile = Path.Combine(tempPath, "OutPutFileTask7.csv");
                string destFile = saveFileDialog.FileName;

                File.Copy(sourceFile, destFile, true);
                MessageBox.Show("Файл успешно сохранен: " + destFile);
            }
        }

        private void buttonFileLoad_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Справка";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
