using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShakhovDK.Sprint4.Task0.V21.Lib
{
    public class DataService : ISprint4Task0V21
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count += array[i];
                }
            }
            return count;
        }
    }
}
