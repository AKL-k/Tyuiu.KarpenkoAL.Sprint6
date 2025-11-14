using Tyuiu.KarpenkoAL.Sprint6.Task7.V23.Lib;

namespace Tyuiu.KarpenkoAL.Sprint6.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask7V23.csv";

            string? directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory!);
            }

            int[,] result = ds.GetMatrix(path);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
