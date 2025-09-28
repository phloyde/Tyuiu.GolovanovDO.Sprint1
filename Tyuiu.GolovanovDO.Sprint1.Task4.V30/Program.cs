using Tyuiu.GolovanovDO.Sprint1.Task4.V30.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.Title = "Спринт #0| Выполнил: Голованов Д.О. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                            *");
        Console.WriteLine("* Задание #04                                                             *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил Голованов Данила Олегович | ПИНб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        double x;
        Console.WriteLine("Введите значение Х: ");
        x = Convert.ToInt32(Console.ReadLine());

        double y;
        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Ответ : " + ds.Calculate(x, y));
        Console.ReadLine();
    }
}