using Tyuiu.ShakirovSA.Sprint1.Task6.V18.Lib;
namespace Tyuiu.ShakirovSA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = "123";
            Assert.IsTrue(ds.CheckNumber(a));
        }
    }
}
