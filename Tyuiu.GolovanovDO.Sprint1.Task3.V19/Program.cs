using Tyuiu.GolovanovDO.Sprint1.Task3.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #0| Выполнил: Голованов Д.О. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                            *");
        Console.WriteLine("* Задание #03                                                             *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил Голованов Данила Олегович | ПИНб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая печатает true или false                     *");
        Console.WriteLine("* в зависимости от того, может ли шахматная фигура «Слон»                 *");
        Console.WriteLine("* с одного заданного поля шахматной доски перейти за один ход на другое.  *");
        Console.WriteLine("* Пользователь задаёт координаты двух ячеек шахматной доски               *");
        Console.WriteLine("* (x1 и y1, x2 и y2, каждое в диапазоне от 1 до 8).                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        double x1;
        Console.WriteLine("Введите значение Х1:");
        x1 = Convert.ToInt32(Console.ReadLine());
        double y1;
        Console.WriteLine("Введите значение Y1:");
        y1 = Convert.ToInt32(Console.ReadLine());

        double x2;
        Console.WriteLine("Введите значение Х2:");
        x2 = Convert.ToInt32(Console.ReadLine());
        double y2;
        Console.WriteLine("Введите значение Y2:");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Слон может ходить так: " + ds.ElephCanMove(x1, x2, y1, y2));
        Console.ReadLine();
    }
}