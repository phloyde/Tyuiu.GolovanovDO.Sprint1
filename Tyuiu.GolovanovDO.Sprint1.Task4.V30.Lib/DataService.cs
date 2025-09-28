using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GolovanovDO.Sprint1.Task4.V30.Lib
{
    public class DataService : ISprint1Task4V30
    {
        public double Calculate(double x, double y)
        {
            var res = ((x + Math.Pow(y, 3)) / (Math.Pow(Math.E, 2 - y)));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
