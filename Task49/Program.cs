// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int InputNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrixWhithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] ObrabotkaMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if ((i %2 == 0)&&(j %2 == 0))
           {
            matrix[i,j] = matrix[i,j] * matrix[i,j];
           }
        }
    }
    return matrix;
}

int m = InputNumber("Введите число m: ");
int n = InputNumber("Введите число n: ");

int[,] matrix = new int[m, n];

matrix = FillMatrixWhithRandom(matrix);
PrintMatrix(matrix);
Console.WriteLine();
matrix = ObrabotkaMatrix(matrix);
PrintMatrix(matrix);

// Задача 49: Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int[,] fillarray(int n, int m)
// {
//     int[,] array = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int vvod(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(System.Console.ReadLine());
// }

// void printarray (int [,] array)
// {
//      for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
//     return;
// }

// int[,] changearray(int [,] array)
// {
    
//     for (int i = 0; i < array.GetLength(0); i=i+2)
//     {
//         for (int j = 0; j < array.GetLength(1); j=j+2)
//         {
//             array[i, j] = array[i, j]*array[i, j];
//         }
//     }
//     return array;
// }

// int n = vvod("Введите количество строк в матрице: ");
// int m = vvod("Введите количество столбцов в матрице: ");

// int[,] arr = fillarray(n, m);

// printarray (arr);

// arr=changearray(arr);

// System.Console.WriteLine();

// printarray (arr);

