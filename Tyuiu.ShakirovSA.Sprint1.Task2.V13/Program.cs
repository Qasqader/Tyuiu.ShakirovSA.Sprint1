using Tyuiu.ShakirovSA.Sprint1.Task2.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x;
        Console.WriteLine("Введите значение X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" X милей  в км = " + ds.ConvertMilesToKm(x));
        Console.ReadLine();
    }
}