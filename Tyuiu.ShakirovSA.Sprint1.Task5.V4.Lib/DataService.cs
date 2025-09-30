using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShakirovSA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            var result = Convert.ToInt32(time / 3600);
            return result;
        }
    }
}
