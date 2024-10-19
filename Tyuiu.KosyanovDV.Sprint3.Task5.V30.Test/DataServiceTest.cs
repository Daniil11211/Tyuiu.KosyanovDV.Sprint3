using Tyuiu.KosyanovDV.Sprint3.Task5.V30.Lib;
namespace Tyuiu.KosyanovDV.Sprint3.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumSum()
        {
            DataService ds = new DataService();
            int startvalue1 = 1;
            int startvalue2 = 1;
            int stopvalue1 = 2;
            int stopvalue2 = 2;
            int x = 2;
            var res = ds.GetSumSumSeries(x, startvalue1, startvalue2, stopvalue1, stopvalue2);
            Assert.AreEqual(res, 36);
        }
    }
}