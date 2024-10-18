using Tyuiu.KosyanovDV.Sprint3.Task2.V25.Lib;
namespace Tyuiu.KosyanovDV.Sprint3.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSum()
        {
            DataService ds = new DataService();
            int n = 5;
            int start = 1; 
            int end = 2;
            Assert.AreEqual(16.016, ds.GetSumSeries(n, start, end));
        }
    }
}