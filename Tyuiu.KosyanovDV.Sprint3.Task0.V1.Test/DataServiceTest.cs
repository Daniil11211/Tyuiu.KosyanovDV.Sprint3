using Tyuiu.KosyanovDV.Sprint3.Task0.V1.Lib;
namespace Tyuiu.KosyanovDV.Sprint3.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSum()
        {
            DataService ds = new DataService();
            int x = 4;
            int startValue = 1;
            int stopValue = 3;
            var res = ds.GetSumSeries(x, startValue, stopValue);
            Assert.AreEqual(99, res);
        }
    }
}