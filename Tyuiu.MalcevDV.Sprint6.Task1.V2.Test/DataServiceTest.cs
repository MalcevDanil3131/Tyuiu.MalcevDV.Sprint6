using Tyuiu.MalcevDV.Sprint6.Task1.V2.Lib;
namespace Tyuiu.MalcevDV.Sprint6.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.IsNotNull(result);
            Assert.AreEqual(11, result.Length);
        }
    }
}
