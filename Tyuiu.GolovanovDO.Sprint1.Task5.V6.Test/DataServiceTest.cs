using Tyuiu.GolovanovDO.Sprint1.Task5.V6.Lib;
namespace Tyuiu.GolovanovDO.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 84;
            var n = ds.Calculate(k);

            Assert.AreEqual(7, n);
            
        }
    }
}
