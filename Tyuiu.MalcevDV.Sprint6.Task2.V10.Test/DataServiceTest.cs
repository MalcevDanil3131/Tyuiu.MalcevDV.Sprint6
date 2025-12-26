using Tyuiu.MalcevDV.Sprint6.Task2.V10.Lib;

namespace Tyuiu.MalcevDV.Sprint6.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startVal = -5;
            int stopVal = 5;
            int len = stopVal - startVal + 1;

            double[] WaitArray;
            WaitArray = new double[len];

            WaitArray[0] = -19.62;
            WaitArray[1] = -17.12;
            WaitArray[2] = -18.15;
            WaitArray[3] = -63.13;
            WaitArray[4] = -24.92;
            WaitArray[5] = -5;
            WaitArray[6] = -1.46;
            WaitArray[7] = 1.57;
            WaitArray[8] = 6.38;
            WaitArray[9] = 32.78;
            WaitArray[10] = 225.11;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startVal, stopVal);
            CollectionAssert.AreEqual(WaitArray, res);
        }
    }
}
