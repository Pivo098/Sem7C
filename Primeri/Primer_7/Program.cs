// Задача 5: Задайте двумерный массив. Найдите максимальный элемент массива и среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Максимальный элемент массива 9
// Среднее арифметическое 4.25

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(2, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}

int InputUser(string message)
{
    System.Console.Write($"{message}  => ");
    return Convert.ToInt32(Console.ReadLine());
}

int MaxElement(int[,] array)
{
    int max = array[0, 0];
    foreach (var item in array)
    {
        if (max < item) max = item;
    }
    return max;
}

double Average(int[,] array)
{
    double result = 0;
    foreach (var item in array)
    {
        result += item;
    }
    return result / array.Length;
}

int[,] matrix = GenerateArray(4, 4);
PrintArray(matrix);
Console.WriteLine($"Среднее арифметическое = {Average(matrix)}");
Console.WriteLine($"Максимальный элемент в массиве = {MaxElement(matrix)}");