using Tyuiu.ShakirovSA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.ShakirovSA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckSecondsToHours()
        {
            DataService ds = new DataService();
            int time = 13257;
            int wait = 3;
            Assert.AreEqual(wait,ds.SecondsToHours(time));
        }
    }
}
