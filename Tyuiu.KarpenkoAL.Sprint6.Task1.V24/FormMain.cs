using Tyuiu.KarpenkoAL.Sprint6.Task1.V24.Lib;

namespace Tyuiu.KarpenkoAL.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Карпенко Артём Леонидович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep,stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    x     |   f(x)    |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+-----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++) 
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   | ", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
