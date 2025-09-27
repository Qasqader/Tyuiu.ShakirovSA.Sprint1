using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShakirovSA.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int intNumber = (int) number;
            int a = intNumber / 100;
            int b = (intNumber / 10) % 10;
            int c = intNumber % 10;
            double res = a * b * c;
            return Math.Round(res, 3);
        }
    }
}
