using Tyuiu.KarpenkoAL.Sprint6.Task2.V28.Lib;

namespace Tyuiu.KarpenkoAL.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-25-1 Карпенко Артём Леонидович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NumberInput(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e) 
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                dataGridViewFunctionTab.Rows.Clear();

                chartResult.Plot.Clear();

                double[] xValues = new double[len];
                double[] yValues = new double[len];

                for (int i = 0; i < len; i++)
                {
                    int currentX = startStep + i;
                    xValues[i] = currentX;
                    yValues[i] = valueArray[i];

                    dataGridViewFunctionTab.Rows.Add(Convert.ToString(currentX), Convert.ToString(valueArray[i]));
                }

                chartResult.Plot.Add.Scatter(xValues, yValues);
                chartResult.Plot.Title("График функции ((sin(x)-(2*x))/((3*x)-1))+sin(x)-(3*x)+2");
                chartResult.Plot.XLabel("Ось X");
                chartResult.Plot.YLabel("Ось Y");

                chartResult.Refresh();
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
