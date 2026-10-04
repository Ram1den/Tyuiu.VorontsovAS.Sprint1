using Tyuiu.VorontsovAS.Sprint1.Task2.V9.Lib;
namespace Tyuiu.VorontsovAS.Sprint1.Task2.V9
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
            Console.WriteLine("* Задание#2                                                               *");
            Console.WriteLine("* Вариант#9                                                               *");
            Console.WriteLine("* Выполнил: Воронцов Артём Сергеевич | СМАРТб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране              *");
            Console.WriteLine("* ФОРМУЛИРОВКА ЗАДАНИЯ:                                                   *");
            Console.WriteLine("* Известен радиус шара. Вычислить примерный объём шара.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int r;
            Console.WriteLine("Введите радиус:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Объём шара равен " + DS.CalculateVolumeCircle(r));
            Console.ReadLine();
        }
    }
}
