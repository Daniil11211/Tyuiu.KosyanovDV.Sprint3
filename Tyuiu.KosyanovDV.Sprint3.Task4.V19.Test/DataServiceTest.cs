using Tyuiu.KosyanovDV.Sprint3.Task4.V19.Lib;
namespace Tyuiu.KosyanovDV.Sprint3.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMult()
        {
            DataService ds = new DataService();
            int startvalue = -3;
            int stopvalue = -2;
            double res = ds.Calculate(startvalue, stopvalue);
            Assert.AreEqual(res, 1.662);
        }
    }
}