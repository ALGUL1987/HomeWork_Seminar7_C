/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Write("Введите кол-во строк: ");
var m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
var n = Convert.ToInt32(Console.ReadLine());
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
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

void AverageColsMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum = matr[j, i] + sum;
        }
        Console.WriteLine($"Среднее арифметическое элементов в столцбе {i + 1} = {Math.Round(sum / m, 2)}");
    }
}
int[,] resultMatix = GetMatrix(m, n, 0, 10);
PrintMatrix(resultMatix);
AverageColsMatrix(resultMatix);