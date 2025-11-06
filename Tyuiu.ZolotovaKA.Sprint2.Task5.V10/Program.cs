using Tyuiu.ZolotovaKA.Sprint2.Task5.V10.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Золотова К. А. | ИСПб-24-1 ";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Золотова К. А. | ИСПб-24-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
        Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
        Console.WriteLine("* определить дату предыдущего дня. Заданный год не является високосным.   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("  ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите год: ");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите день:");
        int n = Convert.ToInt32(Console.ReadLine());

        string res = ds.FindDateOfPreviousDay(g, m, n);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"Дата предыдущего дня: {res}");
        Console.ReadLine();
    }
}
