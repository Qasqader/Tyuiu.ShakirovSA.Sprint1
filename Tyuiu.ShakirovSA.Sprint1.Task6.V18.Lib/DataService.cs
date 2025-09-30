using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShakirovSA.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            if (int.TryParse(value, out var number))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
