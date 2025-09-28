using Tyuiu.ShakirovSA.Sprint1.Task4.V5.Lib;
namespace Tyuiu.ShakirovSA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            double x = Math.Round((1 / Math.Abs(2 + Math.Sqrt(4))), 3); ;
            Assert.AreEqual(x, ds.Calculate(2, 4));
        }
    }
}
