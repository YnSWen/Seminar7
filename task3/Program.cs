// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetMatrix(int rows, int collums)
{
    int[,] matr = new int[rows, collums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            matr[i, j] = new Random().Next(10);
        }
    }
    return matr;
}

double[] FindAverageInCollums(int[,] matr)
{
    double[] avers = new double[matr.GetLength(1)];
    int j2 = 0; // j2 - индекс для результатирующего массива(avers)
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int i = 0;
        double average = 0;
        while (i < matr.GetLength(0))
        {
            average = average + matr[i, j];
            i++;
        }
        avers[j2] = Math.Round(average / i, 1);
        j2++;

    }
    return avers;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}




int[,] matrix = GetMatrix(3, 5); // Зададим матрице размер, например 3х5
double[] averages = FindAverageInCollums(matrix);
PrintMatrix(matrix);
Console.WriteLine($"[{String.Join("; ", averages)}]");