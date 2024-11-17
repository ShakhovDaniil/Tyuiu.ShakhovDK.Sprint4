using Tyuiu.ShakhovDK.Sprint4.Task2.V22.Lib;
namespace Tyuiu.ShakhovDK.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsarray = new int[13] { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7 };
            int res = ds.Calculate(numsarray);
            long wait = 496125;
            Assert.AreEqual(wait, res);
        }
    }
}