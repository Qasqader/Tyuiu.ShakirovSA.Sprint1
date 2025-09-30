using Tyuiu.ShakirovSA.Sprint1.Task7.V16.Lib;
namespace Tyuiu.ShakirovSA.Sprint1.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid ()
        {
            DataService ds = new DataService ();
            double x = 1;
            double res = 1.022;
            Assert.AreEqual(res, ds.Calculate(x));
        }
    }
}
