using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GolovanovDO.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            var n = k - ((k / 7) * 7);
            if (n == 0)
            {
                n = 7;
                return n;
            }
            else
            {
                return n;
            }
        }
    }
}
