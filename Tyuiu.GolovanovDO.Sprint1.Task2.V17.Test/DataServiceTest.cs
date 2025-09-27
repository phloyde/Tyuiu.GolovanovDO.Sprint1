using Tyuiu.GolovanovDO.Sprint1.Task2.V17.Lib;

namespace Tyuiu.GolovanovDO.Sprint1.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 60;
            var res = x / 60;
            Assert.AreEqual(1, res);
        }
    }
}
