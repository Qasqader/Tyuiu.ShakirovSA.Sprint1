using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShakirovSA.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double term1 = Math.Sin(Math.Sqrt(x * x));
            double term2 = (Math.Cos(x * x)) / (3 * Math.Pow(x, 3));
            double term3 = Math.Sin(Math.Sqrt(x * x - 1));
            return Math.Round(term1 + term2 - term3 , 3);
        }
    }
}
