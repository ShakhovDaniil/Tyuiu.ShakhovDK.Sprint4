using Tyuiu.ShakhovDK.Sprint4.Task1.V23.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #4                                                                              *");
Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                                          *");
Console.WriteLine("* Задание #1                                                                             *");
Console.WriteLine("* Вариант #23                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дан одномерный целочисленный массив на 17 элементов,\n" +
    "Заполненный значениями с клавиатуры в диапазоне от 4 до 9.\n" +
    "Подсчитать сумму четных элементов массива.");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("Введите кол-во элементов в массиве:");
int len = Convert.ToInt32(Console.ReadLine());
int[] numsArray = new int[len];
for (int i = 0; i < len; i++)
{
    Console.WriteLine($"Введите {i}-ый элемент массива:");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine($"Сумма чётных элементов равна {ds.Calculate(numsArray)}                                   ");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();