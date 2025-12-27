using Tyuiu.MalcevDV.Sprint6.Task6.V10.Lib;

namespace Tyuiu.MalcevDV.Sprint6.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = "nXkwQYzgZ LlckTwkpaAGTvLPc";
            string res = ds.CollectTextFromFile(@"C:\DataSprint5\InPutDataFileTask6V10.txt");
            Assert.AreEqual(wait, res);
        }
    }
}
