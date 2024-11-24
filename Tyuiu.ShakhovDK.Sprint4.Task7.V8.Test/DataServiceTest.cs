using Tyuiu.ShakhovDK.Sprint4.Task7.V8.Lib;
namespace Tyuiu.ShakhovDK.Sprint4.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 4;
            int[,] matrix = new int[rows, columns];
            string str = "264795863157";
            int res = ds.Calculate(rows, columns, str);
            int wait = 37;
            Assert.AreEqual(wait, res);
        }
    }
}
