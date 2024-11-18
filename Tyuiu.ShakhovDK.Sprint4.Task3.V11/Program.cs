using Tyuiu.ShakhovDK.Sprint4.Task3.V11.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #4                                                                              *");
Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                                            *");
Console.WriteLine("* Задание #3                                                                             *");
Console.WriteLine("* Вариант #11                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов,\n" +
    "Заполненный статическими значениями в диапазоне от 4 до 9.\n" +
    "Подсчитайте количество нечетных элементов во всем массиве.");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
int[,] numsarray = new int[5, 5] { { 8, 6, 9, 4, 5 },
                                   { 9, 4, 8, 5, 6 },
                                   { 9, 7, 9, 8, 4 },
                                   { 4, 6, 5, 7, 8 },
                                   { 6, 6, 7, 6, 4 } };
int rows = numsarray.GetUpperBound(0) + 1;
int columns = numsarray.Length / rows;
Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numsarray[i, j]}\t");
    }
    Console.Write("\n");
}
Console.Write("\n");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine($"Количество нечётных элементов равно {ds.Calculate(numsarray)}                            ");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();