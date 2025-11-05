
using System.Drawing.Drawing2D;
using Tyuiu.KarpenkoAL.Sprint6.Task3.V14.Lib;

namespace Tyuiu.KarpenkoAL.Sprint6.Task3.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mas2 = new int[5, 5] { { 1, 4, -5, -12, -8 },
                                          { -7, -20, 11, -13, 6 },
                                          { 2, -12, 1, -12, 3 },
                                          { -1, -7, -20, -6, 17 },
                                          { -3, 3, 2, 13, -17 } };

        private void FormMain_Load(object sender, EventArgs e) 
        {
            int rows = mas2.GetLength(0);
            int columns = mas2.GetLength(1);

            dataGridView2.ColumnCount = columns;
            dataGridView2.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView2.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(mas2[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-25-1 Карпенко Артём Леонидович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] resultMatrix = ds.Calculate(mas2);

            int rows = resultMatrix.GetLength(0);
            int columns = resultMatrix.GetLength(1);

            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(resultMatrix[i, j]);
                }
            }
        }
    }
}
