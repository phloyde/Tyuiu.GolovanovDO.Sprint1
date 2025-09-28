using Tyuiu.GolovanovDO.Sprint1.Task4.V30.Lib;

namespace Tyuiu.GolovanovDO.Sprint1.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            res = Math.Round(res, 3);
            Assert.AreEqual(78.830, res);
        }
    }
}
