using Tyuiu.ShakirovSA.Sprint1.Task3.V13.Lib;
namespace Tyuiu.ShakirovSA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckMultiplyOfDigits()
        {
            DataService ds = new DataService();
            double number = 357;
            double res = 105;
            Assert.AreEqual(res, ds.MultiplyOfDigits(number));
        }
    }
}
