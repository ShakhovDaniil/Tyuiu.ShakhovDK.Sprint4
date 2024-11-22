using Tyuiu.ShakhovDK.Sprint4.Task5.V15.Lib;
Random rnd = new Random();
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #4                                                                              *");
Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                                  *");
Console.WriteLine("* Задание #5                                                                             *");
Console.WriteLine("* Вариант #15                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов,\n" +
    "Заполненный случайными значениями в диапазоне от -6 до 4.\n" +
    "Найти сумму положительных элементов.");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("* Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numsarray = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        numsarray[i, j] = rnd.Next(-6,4);
    }
}
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
Console.WriteLine($"Сумма положительных элементов равна {ds.Calculate(numsarray)}                            ");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();