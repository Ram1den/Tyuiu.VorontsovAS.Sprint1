using Tyuiu.VorontsovAS.Sprint1.Task5.V1.Lib;

namespace Tyuiu.VorontsovAS.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService DS = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Воронцов А. С. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание#5                                                               *");
            Console.WriteLine("* Вариант#1                                                               *");
            Console.WriteLine("* Выполнил: Воронцов Артём Сергеевич | СМАРТб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите координату х для первой точки");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y для первой точки");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату х для второй точки");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y для второй точки");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Примерный ответ: " + DS.DistanceBetweenDots(x1, x2, y1, y2));
            Console.ReadLine();
        }
    }
}
