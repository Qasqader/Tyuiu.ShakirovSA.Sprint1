using Tyuiu.ShakirovSA.Sprint1.Task1.V23.Lib;
namespace Tyuiu.ShakirovSA.Sprint1.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double a = 10;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(5.24 , res);
        }
    }
}
