using Tyuiu.Kucherenkonm.Sprint2.Task1.V8.Lib;
namespace Tyuiu.Kucherenkonm.Sprint2.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, false, false, false };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
