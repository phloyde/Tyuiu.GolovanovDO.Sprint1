using Tyuiu.GolovanovDO.Sprint1.Task7.V8.Lib;
namespace Tyuiu.GolovanovDO.Sprint1.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-2.308, res);

        }
    }
}
