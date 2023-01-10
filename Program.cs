// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int [,] CreatArray (int rows, int cols, int minValue, int maxValue)
// {
// int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//             array[i, j] = new Random().Next(minValue,maxValue);
//     }
//     return array;
// }
// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j]} ");
//         System.Console.WriteLine();
//     }
// }

// // int[,] CreatNewArray(int[,] array)
// // {
// //     int temp;
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1) ; j++)
// //         {
// //             for (int k = 0; k < array.GetLength(1)-1; k++)
// //             {
// //                 if (array[j, k] < array[j, k + 1])
// //                 {
// //                     temp = array[j, k + 1];
// //                     array[j, k + 1] = array[j, k];
// //                     array[j, k] = temp;
// //                 }
// //             }
// //         }
// //     }
// //     return array;
// // }
// System.Console.WriteLine("Please enter size massive");
// System.Console.Write("Enter the length of the string: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter the line height ");
// int cols = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter the minimum value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter the maximum value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int [,] array = CreatArray (rows, cols, minValue, maxValue);
// ShowArray(array);
// System.Console.WriteLine();
// int[,] newArray = CreatNewArray (array);
// ShowArray(newArray);


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


/* 1 - Способ.
void SmallestRow(int[,] array)
{
    int minString = 0;
    int minSumString = 0;
    for (int i = 0, j = 0; j < array.GetLength(1); j++)
        minSumString += array[i, j];
    System.Console.WriteLine(minSumString);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int maxSumString = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            maxSumString += array[i, j];
        System.Console.WriteLine(maxSumString);
        if (minSumString > maxSumString)
        {
            maxSumString = minSumString;
            minString = i;
        }
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minString + 1} строка");
}
*/
//2 -  Способ
// int SmallestRow(int[,] array)
// {
//     int minString = 0;
//     int minSumString = 0;
//     for (int i = 0, j = 0; j < array.GetLength(1); j++)
//         minSumString += array[i, j];
//     System.Console.WriteLine(minSumString);
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int maxSumString = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//             maxSumString += array[i, j];
//         System.Console.WriteLine(maxSumString);
//         if (minSumString > maxSumString)
//         {
//             maxSumString = minSumString;
//             minString = i;
//         }
//     }
//     return minString + 1;
// }

// int minString = SmallestRow(array);
// System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minString} строка");

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int [,] CreatMatrix (int rows1, int cols1, int minValue1, int maxValue1)
// {
// int[,] matrix = new int[rows1, cols1];
//     for (int i = 0; i < rows1; i++)
//         for (int j = 0; j < cols1; j++)
//             matrix[i, j] = new Random().Next(minValue1,maxValue1);
//     return matrix;
// }
// void ShowMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j]} ");
//         System.Console.WriteLine();
// }

// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {
//     int[,] newMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     if (matrixA.GetLength(1) != matrixB.GetLength(0))
//         System.Console.WriteLine("Число столбцов матрицы A не равно числу строк матрицы B, значит, матрицу A нельзя умножить на матрицу B");
//     else
//     {
//         for (int i = 0; i < newMatrix.GetLength(0); i++)
//             for (int j = 0; j < newMatrix.GetLength(1); j++)
//                 for (int k = 0; k < matrixA.GetLength(10); k++)
//                     newMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
//     }
//     return newMatrix;
// }
// System.Console.WriteLine("Please enter size matrix");
// System.Console.Write("Enter the length of the string matrix A: ");
// int rowsA = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter the line height matrix A: ");
// int colsA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Second matrix:");
// System.Console.Write("Enter the length of the string matrix B: ");
// int rowsB = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter the line height matrix B: ");
// int colsB = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter the minimum value: ");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter the maximum value: ");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());
// int [,] matrixA = CreatMatrix (rowsA, colsA, minValue1, maxValue1);
// System.Console.WriteLine("First matrix:");
// ShowMatrix(matrixA);
// System.Console.WriteLine("Second matrix:");
// int [,] matrixB = CreatMatrix (rowsB, colsB, minValue1, maxValue1);
// ShowMatrix(matrixB);
// System.Console.WriteLine("The product of the matrices is equal to: ");
// ShowMatrix(MatrixMultiplication(matrixA, matrixB));


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] CreatArray(int measurement, int rows, int cols)
// {
//     int[] temp = new int[measurement * rows * cols];
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         for (int j = 0; j < i; j++)
//             while (temp[i] == temp[j])
//             {
//                 temp[i] = new Random().Next(10, 100);
//                 j = 0;
//             }
//     }
//     int count = 0;
//     int[,,] array = new int[measurement, rows, cols];
//     for (int i = 0; i < measurement; i++)
//         for (int j = 0; j < rows; j++)
//             for (int k = 0; k < cols; k++)
//             {
//                 array[i, j, k] = temp[count];
//                 count++;
//             }
//     return array;
// }

// void ShowArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine($"Страница = {(i+1)} ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//                 System.Console.Write($"{array[i, j, k]} ({i},{j},{k}) \t");
//         System.Console.WriteLine(); 
//         }
//     System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Please enter size massive");
// int measurement = 3;
// System.Console.Write("Enter the length of the string: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter the line height: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,,] array = CreatArray (measurement, rows, cols);
// ShowArray(array);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreatArray(int rows, int cols)
{
    int number = 1;
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows / 2; i++)
    {
        for (int j = i; j < rows - i; j++)
            array[i, j] = number++;
        for (int k = i + 1; k < cols - i; k++)
            array[k, cols - i - 1] = number++;
        for (int x = rows - i - 2; x >= i; x--)
            array[cols - i - 1, x] = number++;
        for (int y = cols - i - 2; y > i; y--)
            array[y, i] = number++;
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < 10)
                System.Console.Write($"0{array[i, j]} ");
            else
                System.Console.Write($"{array[i, j]} ");
        System.Console.WriteLine();
    }
}
int rows = 4;
int cols = 4;
int[,] array = CreatArray(rows, cols);
ShowArray(array);
System.Console.WriteLine();