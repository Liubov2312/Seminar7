// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите номер строки позиции элемента");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите номер столбца позиции элемента");
int stlb = Convert.ToInt32(Console.ReadLine());

int[,] array = FillMatrix(m, n);
PrintMatrix(array);
FindNumInMatrix(str, stlb, array);


void FindNumInMatrix(int str, int stlb, int[,] matrix)
{
if (str > matrix.GetLength(0) || stlb > matrix.GetLength(1))
{
    Console.WriteLine("такого номера позиции в массиве нет");
}
else
{
    Console.WriteLine($"Такой элемент есть, это {matrix[str, stlb]}");
}
}


int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
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
