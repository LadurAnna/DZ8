// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[][] buildArray(int m, int n)
// {
//     int[][] matrix = new int[m][];
//     Random rand = new Random();
//     for (int i = 0; i<m; i++)
//     {
//         matrix[i] = new int[n];
//         for (int j = 0; j<n; j++)
//         {
//             matrix[i][j]=rand.Next(0,100);
//         }
//     }
//     return matrix;
// }

// void printArray2d(int[][] array,int m, int n)
// {
//     for (int i = 0; i<m; i++)
//     {
//         for (int j = 0; j<n; j++)
//         {
//             Console.Write($"{array[i][j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void printArray1d(int[] array)
// {
//     for (int j = 0; j<array.Length; j++)
//     {            
//         Console.Write($"{array[j]}\t");
//     }
// }

// int[] sortArray(int[] array) 
// {
//     int temp;
//     for (int i = 0; i<array.Length; i++)
//     {
//         for (int j = i; j<array.Length; j++)
//         {
//             if (array[i]<array[j])
//             {
//                 temp = array[i];
//                 array[i]=array[j];
//                 array[j]=temp;
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[][] matrix = buildArray(m,n);
// printArray2d(matrix, m,n);
// for (int i = 0; i<n; i++)
// {
//     matrix[i] = sortArray(matrix[i]);
// }
// Console.WriteLine();
// printArray2d(matrix, m,n);

// ____________________________________________
// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку 
//  с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[][] matrix = buildArray(m, n);
// printArray2d(matrix, m, n);

// int[] temp_sm = new int[m];

// for (int i = 0; i < m; i++)
// {
//    temp_sm[i] = 0;
//    for (int j = 0; j < n; j++)
//    {
//        temp_sm[i] += matrix[i][j];
//    }
// }

// int min_sm = temp_sm[0];
// int min_index = 0;
// for (int k = 1; k < m; ++k)
// {
//    if (temp_sm[k] < min_sm)
//    {
//        min_sm = temp_sm[k];
//        min_index = k;
//    }
// }
// Console.WriteLine($"Наименьшая сумма в строке с номером: {min_index + 1}");
// // _____________________________________________
// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Console.WriteLine("Введите количество строк первой матрицы");
// int m1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов первой матрицы");
// int n1 = Convert.ToInt32(Console.ReadLine());

// int[][] matrix1 = buildArray(m1, n1);
// printArray2d(matrix1, m1, n1);


// Console.WriteLine("Введите количество строк второй матрицы");
// int m2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов второй матрицы");
// int n2 = Convert.ToInt32(Console.ReadLine());

// int[][] matrix2 = buildArray(m2, n2);
// printArray2d(matrix2, m2, n2);

// int[][] result_matrix = new int[m1][];
// for (int i = 0; i < m1; i++)
// {
//    result_matrix[i] = new int[n2];
//    for (int j = 0; j < n2; j++)
//    {
//        for (int k = 0; k < n1; k++)
//        {
//            result_matrix[i][j] += matrix1[i][k] * matrix2[k][j];
//        }
//    }
// }
// Console.WriteLine();
// printArray2d(result_matrix, m1, n2);


// // ___________________________________________
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array = new int[2, 2, 2];
// Random rand = new Random();
// for (int i = 0; i < 2; i++)
// {
//    for (int j = 0; j < 2; j++)
//    {
//        for (int k = 0; k < 2; k++)
//        {
//            array[i, j, k] = rand.Next(10, 100);
//        }
//    }
// }


// for (int i = 0; i < 2; i++)
// {
//    for (int j = 0; j < 2; j++)
//    {
//        for (int k = 0; k < 2; k++)
//        {
//            Console.Write($"{array[i,j,k]} ({i},{j},{k})\t");
//        }
//        Console.WriteLine();
//    }
// }
// _____________________________________________
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
// 	sqareMatrix[i, j] = temp;
// 	temp++;
// 	if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
// 		j++;
// 	else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
// 		i++;
// 	else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
// 		j--;
// 	else
// 		i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			if (array[i, j] / 10 <= 0)
// 				Console.Write($" {array[i, j]} ");

// 			else Console.Write($"{array[i, j]} ");
// 		}
// 		Console.WriteLine();
// 	}
// }