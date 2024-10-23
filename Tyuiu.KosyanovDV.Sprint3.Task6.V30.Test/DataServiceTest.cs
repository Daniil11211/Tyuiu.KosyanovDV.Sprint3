using Tyuiu.KosyanovDV.Sprint3.Task6.V30.Lib;
namespace Tyuiu.KosyanovDV.Sprint3.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDiv()
        {
            DataService ds = new DataService();
            int startvalue = 1;
            int endvalue = 2;
            int res = ds.GetSumTheDivisors(startvalue, endvalue);
            Assert.AreEqual(res, 3);
        }
    }
}