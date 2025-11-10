using Tyuiu.KarpenkoAL.Sprint6.Task6.V10.Lib;

namespace Tyuiu.KarpenkoAL.Sprint6.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask6V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V10.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "nXkwQYzgZ LlckTwkpaAGTvLPc"; 
            Assert.AreEqual(wait, res);
        }
    }
}
