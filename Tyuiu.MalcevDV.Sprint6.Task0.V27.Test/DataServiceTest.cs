using Tyuiu.MalcevDV.Sprint6.Task0.V27.Lib;
namespace Tyuiu.MalcevDV.Sprint6.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int wait = -6;
            Assert.AreEqual(wait, ds.Calculate(4));
        }
    }
}
