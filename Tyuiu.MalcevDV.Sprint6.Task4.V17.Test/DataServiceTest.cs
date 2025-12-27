using Tyuiu.MalcevDV.Sprint6.Task4.V17.Lib;

namespace Tyuiu.MalcevDV.Sprint6.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int len = 11;
            int startValue = -5;
            int stopValue = 5;
            double[] waitArray = new double[len];
            waitArray[0] = -0.62;
            waitArray[1] = -16.79;
            waitArray[2] = -17.77;
            waitArray[3] = -6.3;
            waitArray[4] = -5.04;
            waitArray[5] = -6;
            waitArray[6] = -7.85;
            waitArray[7] = -2.43;
            waitArray[8] = 5.91;
            waitArray[9] = 4.33;
            waitArray[10] = -11.82;
            double[] resArray = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
