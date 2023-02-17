// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// ВАРИАНТ 2. С вводом координат массивом и случайной генерацией размера исходного массива

int GenerateSize(string text)
{
    Random rand = new Random();
    int size = rand.Next(1, 10);
    System.Console.WriteLine(text + size);
    return size;
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

int rows = GenerateSize("Количество строк в матрице: ");
int cols = GenerateSize("Количество столбцов в матрице: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();

metka:
System.Console.WriteLine("Введите через пробел требуемые координаты (номер строки и номер столбца): ");
int[]? arrayCoord = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
if (arrayCoord.Length != 2)
{
    System.Console.WriteLine("Координаты введёны некоректно ");
    goto metka;
}

System.Console.WriteLine(FromPositionToElement(myMatrix, arrayCoord[0], arrayCoord[1]));
System.Console.WriteLine();