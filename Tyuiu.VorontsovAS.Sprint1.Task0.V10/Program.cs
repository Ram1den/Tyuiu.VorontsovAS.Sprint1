using Tyuiu.VorontsovAS.Sprint1.Task0.V10.Lib;
namespace Tyuiu.VorontsovAS.Sprint1.Task0.V10;

class Program
{
    static void Main(string[] args)
    {
        DataService DS = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Воронцов А. С. | СМАРТб-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Задание#0                                                               *");
        Console.WriteLine("* Вариант#10                                                              *");
        Console.WriteLine("* Выполнил: Воронцов Артём Сергеевич | СМАРТб-26-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение (3/6-4)*3               *");
        Console.WriteLine("* и печатает результат на экране.                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* (3 / 6 - 4) * 3                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(DS.Calculate());
        Console.ReadLine();

    }
}
