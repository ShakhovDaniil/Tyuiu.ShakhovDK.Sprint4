using Tyuiu.ShakhovDK.Sprint4.Task7.V8.Lib;
DataService ds = new DataService();
int rows = 3;
int columns = 4;
int index = 0;
int[,] matrix = new int[rows, columns];
string str = "264795863157";
int res = ds.Calculate(rows, columns, str);
Console.Title = "Спринт #4 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #4                                                                              *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                *");
Console.WriteLine("* Задание #7                                                                             *");
Console.WriteLine("* Вариант #8                                                                             *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дана строка из одноразрядных цифр '264795863157'\n" +
    "Преобразуйте ее в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* '264795863157'                                                                         *");
Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{str[index]}\t");
        index++;
    }
    Console.Write("\n");
}
Console.WriteLine();
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine($"Сумма нечётных элементов равна {ds.Calculate(rows, columns, str)}                        ");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();