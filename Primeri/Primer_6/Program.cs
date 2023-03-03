// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

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

/// <summary>
/// Метод возвращает позицию найденого значения в двумерном массиве
/// </summary>
/// <param name="isNotFinde">параметр возвращает найдено искомое значение или нет </param>
/// <param name="row">строка найденной позиции</param>
/// <param name="col">колонка найденной позиции</param>
/// <param name="array"> двумерный массив</param>
/// <param name="element">искомый элемент</param>
/// <returns></returns>
(bool isNotFinde, int row, int col) FindePosition(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (element == array[i, j])
            {
                return (false, i, j);
            }
        }
    }
    return (true, -1, -1);
}

int InputUser(string message)
{
    System.Console.Write($"{message}  => ");
    return Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = GenerateArray(4, 4);
PrintArray(matrix);
int element = InputUser("Какое число ищем ?");
var result = FindePosition(matrix, element);
if (result.isNotFinde) Console.WriteLine("Такого элемента нет");
else Console.WriteLine($"индексы поискового элемента равны = ({result.row},{result.col})");
