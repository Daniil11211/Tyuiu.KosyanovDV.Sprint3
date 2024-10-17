using Tyuiu.KosyanovDV.Sprint3.Task1.V29.Lib;
namespace Tyuiu.KosyanovDV.Sprint3.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMult()
        {
            DataService ds = new DataService();
            double x = 0.25;
            int startValue = 1;
            int stopValue = 3;
            var res = ds.GetMultiplySeries(x, startValue, stopValue);
            Assert.AreEqual(9.58740234375, res);
        }
    }
}