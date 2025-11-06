using Tyuiu.ZolotovaKA.Sprint2.Task4.V12.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Золотова К. А. | ИСПб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Золотова К. А. | ИСПб-24-1                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет требуемое значение       *");
        Console.WriteLine("* с использованием тернарного оператора, где пользователь                 *");
        Console.WriteLine("* вводит значение переменной X, Y с клавиатуры.                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение x");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Значение функции = " + ds.Calculate(x, y));
        Console.ReadKey();
    }
}
