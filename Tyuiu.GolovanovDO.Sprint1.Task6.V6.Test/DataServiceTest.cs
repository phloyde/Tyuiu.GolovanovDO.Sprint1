using Tyuiu.GolovanovDO.Sprint1.Task6.V6.Lib;
namespace Tyuiu.GolovanovDO.Sprint1.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string letter = "hello world example";
            DataService ds = new DataService();
            
            var res = ds.DeleteFirstLetter(letter);
            Assert.AreEqual("ello orld xample", res);
        }
    }
}
