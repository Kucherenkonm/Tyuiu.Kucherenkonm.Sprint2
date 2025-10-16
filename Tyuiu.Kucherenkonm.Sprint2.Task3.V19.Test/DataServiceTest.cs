using Tyuiu.Kucherenkonm.Sprint2.Task3.V19.Lib;
namespace Tyuiu.Kucherenkonm.Sprint2.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.556;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -22;
            double res = ds.Calculate(x);
            double wait = 0.956;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -24;
            double res = ds.Calculate(x);
            double wait = -263.958;
            Assert.AreEqual(wait, res);
        }
    }
}
