using Tyuiu.VorontsovAS.Sprint1.Task4.V27.Lib;

namespace Tyuiu.VorontsovAS.Sprint1.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService DS = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Воронцов А. С. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание#4                                                               *");
            Console.WriteLine("* Вариант#27                                                              *");
            Console.WriteLine("* Выполнил: Воронцов Артём Сергеевич | СМАРТб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экран                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x;
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            double y;
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Примерный ответ: " + DS.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
