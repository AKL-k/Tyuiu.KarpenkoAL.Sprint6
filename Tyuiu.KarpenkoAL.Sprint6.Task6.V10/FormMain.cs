using System.IO;
using Tyuiu.KarpenkoAL.Sprint6.Task6.V10.Lib;

namespace Tyuiu.KarpenkoAL.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string? path;

        private void buttonFileLoad_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(path);
            groupBoxIn.Text = groupBoxIn.Text + " " + openFileDialogTask.FileName;

            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                textBoxOut.Text = ds.CollectTextFromFile(path!);
            }
            catch
            {
                MessageBox.Show("Вы инвалид, что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
