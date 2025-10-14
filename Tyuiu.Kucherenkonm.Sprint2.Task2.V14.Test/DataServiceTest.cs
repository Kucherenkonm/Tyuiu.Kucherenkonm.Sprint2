using Tyuiu.Kucherenkonm.Sprint2.Task2.V14.Lib;
namespace Tyuiu.Kucherenkonm.Sprint2.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 11;
            int y = 2;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
