using Tyuiu.KosyanovDV.Sprint3.Task7.V7.Lib;
namespace Tyuiu.KosyanovDV.Sprint3.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMassFunc()
        {
            
            DataService ds = new DataService();
            
            int start = -2;
            int end = 2;
            
            int len = (end - start) + 1;

            double[] valueResArray; 
            valueResArray = new double[len];

            valueResArray[0] = 0.0;
            valueResArray[1] = 4.08;
            valueResArray[2] = 1.50;
            valueResArray[3] = -2.28;
            valueResArray[4] = -6.52;

            double[] res = new double[len];
            res = ds.GetMassFunction(start, end);
            
            CollectionAssert.AreEqual(valueResArray, res);
        }
    }
}