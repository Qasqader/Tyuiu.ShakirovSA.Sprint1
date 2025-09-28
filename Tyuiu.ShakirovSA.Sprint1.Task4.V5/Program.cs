using Tyuiu.ShakirovSA.Sprint1.Task4.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x , y;
        Console.WriteLine("Введите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Результатом являеется " + ds.Calculate(x, y));
        Console.ReadLine();
    }
}