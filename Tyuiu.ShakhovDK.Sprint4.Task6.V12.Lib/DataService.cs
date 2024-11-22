using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShakhovDK.Sprint4.Task6.V12.Lib
{
    public class DataService : ISprint4Task6V12
    {
        public string[] Calculate(string[] array)
        {
            string[] res_array = Array.FindAll(array, s => s.Length == 7);
            return res_array;
        }
    }
}
