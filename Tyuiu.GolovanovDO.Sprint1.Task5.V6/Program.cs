using Tyuiu.GolovanovDO.Sprint1.Task5.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #0| Выполнил: Голованов Д.О. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
        Console.WriteLine("* Задание #05                                                             *");
        Console.WriteLine("* Вариант #06                                                             *");
        Console.WriteLine("* Выполнил Голованов Данила Олегович | ПИНб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n               *");
        Console.WriteLine("* значение 1,2,...,7 в зависимости от того, на какой день недели          *");
        Console.WriteLine("* приходится k-й день невисокосного года, в котором 1 января – понедельник*");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        int k;
        Console.WriteLine("Введите значение K :");
        k = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("K-й день был : " + ds.Calculate(k) + "-м днем недели");
    }
}