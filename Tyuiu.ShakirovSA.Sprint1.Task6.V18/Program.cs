using Tyuiu.ShakirovSA.Sprint1.Task6.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string x;
        Console.WriteLine("Введите значение X: ");
        x = Console.ReadLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (ds.CheckNumber(x) == true)
        {
            Console.WriteLine("Значение X является натуральным числом");
        }
        else
        {
            Console.WriteLine("Значение X не является натуральным числом");
        }
                Console.ReadLine();
    }
}