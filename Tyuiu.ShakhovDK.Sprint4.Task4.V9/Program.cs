using Tyuiu.ShakhovDK.Sprint4.Task4.V9.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #4                                                                              *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                                           *");
Console.WriteLine("* Задание #4                                                                             *");
Console.WriteLine("* Вариант #9                                                                             *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов,\n" +
    "Заполненный значениями с клавиатуры в диапазоне от 1 до 8.\n" +
    "Найдите сумму четных элементов массива.");
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
        Console.WriteLine($"Введите ({i}, {j}) элемент массива: ");
        numsarray[i, j] = Convert.ToInt32(Console.ReadLine());

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
Console.WriteLine($"Сумма чётных элементов равна {ds.Calculate(numsarray)}                            ");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();