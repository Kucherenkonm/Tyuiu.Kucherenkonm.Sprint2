using Tyuiu.Kucherenkonm.Sprint2.Task6.V8.Lib;
namespace Tyuiu.Kucherenkonm.Sprint2.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int m = 2;

            Assert.AreEqual("01.01", ds.FindDateOfPreviousDay(m, 1));
            Assert.AreEqual("01.02", ds.FindDateOfPreviousDay(m, 2));
            Assert.AreEqual("01.03", ds.FindDateOfPreviousDay(m, 3));
            Assert.AreEqual("01.04", ds.FindDateOfPreviousDay(m, 4));
            Assert.AreEqual("01.05", ds.FindDateOfPreviousDay(m, 5));
            Assert.AreEqual("01.06", ds.FindDateOfPreviousDay(m, 6));
            Assert.AreEqual("01.07", ds.FindDateOfPreviousDay(m, 7));
            Assert.AreEqual("01.08", ds.FindDateOfPreviousDay(m, 8));
            Assert.AreEqual("01.09", ds.FindDateOfPreviousDay(m, 9));
            Assert.AreEqual("01.10", ds.FindDateOfPreviousDay(m, 10));
            Assert.AreEqual("01.11", ds.FindDateOfPreviousDay(m, 11));
            Assert.AreEqual("01.12", ds.FindDateOfPreviousDay(m, 12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(1, -1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(32, 13);
            });
        }
        
    }
}
