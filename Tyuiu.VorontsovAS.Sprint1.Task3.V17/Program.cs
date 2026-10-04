using Tyuiu.VorontsovAS.Sprint1.Task3.V17.Lib;
namespace Tyuiu.VorontsovAS.Sprint1.Task3.V17
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
            Console.WriteLine("* Задание#3                                                               *");
            Console.WriteLine("* Вариант#17                                                              *");
            Console.WriteLine("* Выполнила: Воронцов Артём Сергеевич | СМАРТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране              *");
            Console.WriteLine("* ФОРМУЛИРОВКА ЗАДАНИЯ:                                                   *");
            Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых трех       *");
            Console.WriteLine("* цифр дробной части заданного вещественного числа цифра 0.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double n;
            Console.WriteLine("Введите число");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (DS.ZeroCheck(n) == true)
                {
                Console.WriteLine("Нули есть");
                }
            else
            {
                Console.WriteLine("Нулей нет");
            }
            Console.ReadLine();
        }
    }
}
