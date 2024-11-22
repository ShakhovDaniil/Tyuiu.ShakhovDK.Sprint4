using Tyuiu.ShakhovDK.Sprint4.Task5.V15.Lib;
namespace Tyuiu.ShakhovDK.Sprint4.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] numsArray = new int[5, 5] { { 0, 0, 0, 0, 1 },
                                               { 0, 0, 0, 1, 0 },
                                               { 0, 0, 0, 1, 1 },
                                               { 0, 0, 1, 0, 0 },
                                               { 0, 0, 1, 1, 1 }, };
            int res = ds.Calculate(numsArray);
            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}
