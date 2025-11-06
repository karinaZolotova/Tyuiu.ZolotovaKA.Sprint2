using Tyuiu.ZolotovaKA.Sprint2.Task3.V3.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Золотова К. А. | ИCПБ-24-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Золотова К. А. | ИCПБ-24-1                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*                                                                         *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        var result = ds.Calculate(x);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
