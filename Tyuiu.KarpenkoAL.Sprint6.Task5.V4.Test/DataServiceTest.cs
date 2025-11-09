using Tyuiu.KarpenkoAL.Sprint6.Task5.V4.Lib;

namespace Tyuiu.KarpenkoAL.Sprint6.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask5V4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask5V4.txt";
            var res = ds.LoadFromDataFile(path);
            double[] wait = { -1, 3, -1, -3, 0, -5, 6, 7, -7, 8, -8, -9, 10, -10, 0 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
