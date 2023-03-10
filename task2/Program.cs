// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1(строчка) 7 (столбец) -> такого числа в массиве нет


int[,] GetMatrix(int rows, int collums)
{
    int[,] matrix = new int[rows, collums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine("Заданный массив:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


void PrintFindElement(int[,] matrix)
{
    Console.Write("Введите позицию элемента через запятую: ");
    string[] position = (Console.ReadLine().Split(","));

    // Перевод из string массива в int массив
    int[] position_2 = new int[2];
    position_2[0] = Convert.ToInt32(position[0]);
    position_2[1] = Convert.ToInt32(position[1]);

    int row = position_2[0];
    int collum = position_2[1];

    if (row > matrix.GetLength(0) || collum > matrix.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"Результат: {matrix[row, collum]}");
    }
}


int[,] matrix = GetMatrix(5,7); // Зададим размер массива, например, 5х7


PrintFindElement(matrix);
PrintMatrix(matrix);

