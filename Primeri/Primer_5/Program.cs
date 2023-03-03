// Задача 4: Задайте двумерный массив. Введите элемент,
//  и найдите первое его вхождение, 
//  выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
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
            array[i, j] = random.Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

(int row, int col) FindPosition(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (element == array[i,j])
            {
                return(i,j);
            }
        }
    }
    return(-1, -1);
}

int InputUser(string message)
{
    System.Console.WriteLine($"{message} =>");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = GenerateArray(4,4);
PrintArray(matrix);
int element = InputUser("Какое число ищем?");
var result = FindPosition(matrix, element);
if (result.row == -1) System.Console.WriteLine("Такого элемента нет");
else Console.WriteLine($"Индексы поискового элемента равны = {result}");
