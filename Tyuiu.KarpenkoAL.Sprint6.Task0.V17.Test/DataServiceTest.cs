using Tyuiu.KarpenkoAL.Sprint6.Task0.V17.Lib;


namespace Tyuiu.KarpenkoAL.Sprint6.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 6.695;
            Assert.AreEqual(wait, res);
        }
    }
}
