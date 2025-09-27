using Tyuiu.GolovanovDO.Sprint1.Task2.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #0| Выполнил: Голованов Д.О. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                            *");
        Console.WriteLine("* Задание #02                                                             *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил Голованов Данила Олегович | ПИНб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        int x;
        Console.WriteLine("Введите значение X:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Время в часах = " + x / 60);
        Console.ReadLine();
    }
}