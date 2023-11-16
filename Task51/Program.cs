// Задайте двумерный массив. Найдите сумму элементов, находящихся на
// главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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

int SumMaidDMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (i == j)
           {
            sum = sum + matrix[i,j];
           }
        }
    }
    return sum;
}

int m = InputNumber("Введите число m: ");
int n = InputNumber("Введите число n: ");

int[,] matrix = new int[m, n];

matrix = FillMatrixWhithRandom(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(SumMaidDMatrix(matrix));


// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

// void printarray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
//     return;
// }

// int sumgiagonal(int[,] array, int min)
// {
//     int sum = 0;
//     for (int i = 0; i < min; i++)
//     {
//         sum = sum + array[i, i];
//     }
//     return sum;
// }

// int n = vvod("Введите количество строк в матрице: ");
// int m = vvod("Введите количество столбцов в матрице: ");

// int[,] arr = fillarray(n, m);

// printarray(arr);

// int min = n;

// if (min>m)
// {
//     min=m;
// }

// System.Console.WriteLine($"Сумма элементов на диагонали составила {sumgiagonal(arr,min)}");