using Tyuiu.KosyanovDV.Sprint3.Task3.V21.Lib;
namespace Tyuiu.KosyanovDV.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckReplace()
        {
            DataService ds = new DataService();
            string str = "f3g5ht g4j 34kg4";
            char item = 'e';
            string res = ds.ReplaceNumOnChar(str, item);
            Assert.AreEqual("fegeht gej eekge", res);
        }
    }
}