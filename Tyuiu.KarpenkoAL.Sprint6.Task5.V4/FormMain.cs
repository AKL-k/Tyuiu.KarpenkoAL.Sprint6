using System.Windows.Forms;
using Tyuiu.KarpenkoAL.Sprint6.Task5.V4.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.KarpenkoAL.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        private string path;
        public FormMain(string[] args)
        {
            InitializeComponent();
            path = args.Length > 0 ? args[0] : @"C:\DataSprint6\InPutDataFileTask5V4.txt";
        }

        DataService ds = new DataService();

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-25-1 Карпенко Артём Леонидович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {

            this.chartDiag.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartDiag.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag.Series[0].Points.Clear();

            double[] numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++) 
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonFileOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
