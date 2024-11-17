using Tyuiu.ShakhovDK.Sprint4.Task2.V22.Lib;
Random rnd = new Random();
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #4                                                                              *");
Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                                  *");
Console.WriteLine("* Задание #2                                                                             *");
Console.WriteLine("* Вариант #22                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дан одномерный целочисленный массив на 13 элементов,\n" +
    "Заполненный случайными в диапазоне от 1 до 6.\n" +
    "Подсчитать произведение нечетных элементов массива.");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("Введите кол-во элементов в массиве:");
int len = Convert.ToInt32(Console.ReadLine());
int[] numsArray = new int[len];
for (int i = 0; i < len; i++)
{
    numsArray[i] = rnd.Next(1, 6);
}
Console.WriteLine("Массив:");
for (int i = 0; i < len; i++)
{
    Console.Write(numsArray[i] + " ");
}
Console.WriteLine("\n");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine($"Произведение нечётных элементов равно {ds.Calculate(numsArray)}                            ");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();