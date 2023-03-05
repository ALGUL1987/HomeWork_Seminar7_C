/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1(строчка) 7 (столбец) -> такого числа в массиве нет
*/
Console.Write("Введите кол-во строк: ");
var m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
var n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер элемента матрицы (2 числа разделенные пробелом): ");
string[] array = Console.ReadLine().Split(" ");

double[,] GetMatrix(int m, int n, double minValue, double maxValue)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble() * 100 - 50), 1);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matr)
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
void PositionMatrix(double[,] matr)
{
    if (Convert.ToInt32(array[0]) >= m && Convert.ToInt32(array[1]) >= n)
    {
        Console.WriteLine($"Индекса {Convert.ToInt32(array[0])},{Convert.ToInt32(array[1])} не существует");
    }
    else
        for (int i = 0; i < 1; i++)
        {
            i = Convert.ToInt32(array[0]);
            for (int j = 0; j < 1; j++)
            {
                j = Convert.ToInt32(array[1]);
                Console.WriteLine($"Результат запроса по индексу {i},{j} -> {matr[i, j]}");
            }
        }
}

double[,] resultMatix = GetMatrix(m, n, 0, 100);
PrintMatrix(resultMatix);
PositionMatrix(resultMatix);