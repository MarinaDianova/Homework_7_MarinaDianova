// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// ВАРИАНТ 1. С вводом координат как чисел

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

string FromPositionToElement(int[,] matrix, int row, int col)
{
    string element = "";
    if (matrix.GetLength(0) < row || matrix.GetLength(1) < col)
    {
        System.Console.WriteLine("Такого элемента нет");
    }
    else
    {
        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j <= col; j++)
            {
                if (i == row && j == col)
                {
                    element = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
    return element;
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
int searchRows = ReadInt("Введите номер ряда искомого элемента: ");
int SearchCols = ReadInt("Введите номер столбца искомого элементаы: ");
System.Console.WriteLine(FromPositionToElement(myMatrix, searchRows, SearchCols));
System.Console.WriteLine();
