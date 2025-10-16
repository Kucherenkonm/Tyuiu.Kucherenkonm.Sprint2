using Tyuiu.Kucherenkonm.Sprint2.Task7.V8.Lib;
namespace Tyuiu.Kucherenkonm.Sprint2.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArena()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
