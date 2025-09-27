using Tyuiu.ShakirovSA.Sprint1.Task3.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x;
        Console.WriteLine("Введите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Результатом вычислений являеется " + ds.MultiplyOfDigits(x));
        Console.ReadLine();
    }
}