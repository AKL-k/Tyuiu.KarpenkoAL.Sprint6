using Tyuiu.KarpenkoAL.Sprint6.Task4.V26.Lib;

namespace Tyuiu.KarpenkoAL.Sprint6.Task4.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private double[]? currentXValues;
        private double[]? currentYValues;

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult.Text = "";

                chartResult.Plot.Clear();

                currentXValues = new double[len];
                currentYValues = new double[len];

                string resultText = "";

                for (int i = 0; i < len; i++)
                {
                    int currentX = startStep + i;
                    currentXValues[i] = currentX;
                    currentYValues[i] = valueArray[i];

                    resultText += Convert.ToString(currentX) + "\t" + Convert.ToString(valueArray[i]) + "\r\n";
                }

                textBoxResult.Text = resultText;

                chartResult.Plot.Add.Scatter(currentXValues, currentYValues);
                chartResult.Plot.Title("График функции 5 - (3*х) +((1+Sin(х))/((2*х)-0,5))");
                chartResult.Plot.XLabel("Ось X");
                chartResult.Plot.YLabel("Ось Y");

                chartResult.Refresh();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-25-1 Карпенко Артём Леонидович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try 
            {
                string tempPath = Path.GetTempPath();
                string path = Path.Combine(tempPath, "OutPutFileTask4V26.txt");

                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show(" файл " + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();

                }
            }
            catch 
            {
                MessageBox.Show("Cбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
