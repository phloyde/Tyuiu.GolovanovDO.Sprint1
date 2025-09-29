using System;
using Tyuiu.GolovanovDO.Sprint1.Task7.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1| Выполнил: Голованов Д.О. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #07                                                             *");
        Console.WriteLine("* Вариант #08                                                             *");
        Console.WriteLine("* Выполнил Голованов Данила Олегович | ПИНб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        double x;
        Console.WriteLine("Введите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());
        double y;
        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadLine();
    }
}