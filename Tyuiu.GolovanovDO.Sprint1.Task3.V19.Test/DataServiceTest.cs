using Tyuiu.GolovanovDO.Sprint1.Task3.V19.Lib;
namespace Tyuiu.GolovanovDO.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 3;
            double y1 = 3;
            double x2 = 5;
            double y2 = 5;
            var res = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.AreEqual(true, res);
        }
    }
}
