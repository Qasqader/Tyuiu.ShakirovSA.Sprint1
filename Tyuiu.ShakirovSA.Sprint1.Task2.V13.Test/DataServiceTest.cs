using Tyuiu.ShakirovSA.Sprint1.Task2.V13.Lib;
namespace Tyuiu.ShakirovSA.Sprint1.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckConverMilesToKM()
        {
            DataService ds = new DataService();
            Assert.AreEqual(8.05, ds.ConvertMilesToKm(5));
        }
    }
}
