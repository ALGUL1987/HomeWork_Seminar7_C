// Сумма элементов главной диагонали


Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] GetMatrix(int m, int n, double minValue, double maxValue)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble() * 100 - 50), 2);
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

void SumMainDiagonal(double[,] matr)
{
    double summa = 0;
    int i = 0;
    int j = 0;
    while (i < matr.GetLength(0) && j < matr.GetLength(1))
    {
        summa = summa + matr[i, j];
        i++;
        j++;
    }
    Console.WriteLine($"Сумма элементов главной диагонали -> {Math.Round(summa, 2)}");
}

double[,] resultMatix = GetMatrix(n, m, -10, 10);
PrintMatrix(resultMatix);
SumMainDiagonal(resultMatix);