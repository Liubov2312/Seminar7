// Задача 47. Задайте двумерный массив размером m × n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2    -0,2
// 1   -3,3   8    -9,9
// 8    7,8  -7,1   9

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrixArray = FillMatrixDouble( m, n );
PrintMatrix(matrixArray);

double[,] FillMatrixDouble( int m, int n)
{
    double[,] arrayTable = new double[ m, n ];
    Random rnd = new Random();
    for (int i = 0; i < arrayTable.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTable.GetLength(1); j++)
        {
            arrayTable[i, j] = Math.Round(rnd.NextDouble()* (100 + 100) - 100, 2);
        }
    }
    return arrayTable;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine("]");
    }
}

