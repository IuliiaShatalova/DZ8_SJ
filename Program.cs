// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows,columns];


// void FillMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,5);
//         }
//     }
// }

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void RearangeMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1)-1; j++)
//         {
//             for (int m = 0; m < matrix.GetLength(1)-1; m++)
//             {
//                 if (matrix[i,m] <= matrix[i,m+1])
//                 {
//                     int temp = 0;
//                     temp = matrix[i,m];
//                     matrix[i,m] = matrix[i,m+1];
//                     matrix[i,m+1] = temp;      
//                 }
//             }
//         }
//     }
// }

// FillMatrix();
// PrintMatrix();
// Console.WriteLine();
// RearangeMatrix();
// PrintMatrix();



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows,columns];
// int minSum = int.MaxValue; 

// int rowIndex = 0;


// void FillMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,5);
//         }
//     }
// }

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SumOfTheRow()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum = sum + matrix[i,j];
//         }
//         Console.WriteLine(sum);
//         if (sum < minSum)
//         {
//             minSum = sum;
//             rowIndex = i;
//         }       
//     }
// }

// FillMatrix();
// PrintMatrix();
// Console.WriteLine();
// SumOfTheRow();
// Console.WriteLine($"номер строки с минимальной суммой: {rowIndex}");


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.WriteLine("Введите количество строк матрицы A");
// int rowsA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы A");
// int columnsA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество строк матрицы B");
// int rowsB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы B");
// int columnsB = Convert.ToInt32(Console.ReadLine());

// int[,] matrixA = new int[rowsA,columnsA];
// int[,] matrixB = new int[rowsB,columnsB];
// int[,] matrixC = new int[rowsA,columnsB];



// void FillMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,5);
//         }
//     }
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillMatrixC ()
// {
//     if (columnsA == rowsB)
//     {
//         for (int i = 0; i < rowsA; i++)
//         {
//            for (int j = 0; j < columnsB; j++)
//            {
//             int sum = 0;
//             for (int z = 0; z < columnsB; z++)
//             {
//                 sum += matrixA[i,j] * matrixB[j,z];
//             }
//             matrixC[i,j] = sum;
//            }
//         }
//     }
//     else { Console.WriteLine("Умножение не может быть произведено");}
// }

// FillMatrix(matrixA);
// Console.WriteLine("Матрица A:");
// PrintMatrix(matrixA);
// Console.WriteLine();
// FillMatrix(matrixB);
// Console.WriteLine("Матрица B:");
// PrintMatrix(matrixB);
// Console.WriteLine();
// FillMatrixC();
// Console.WriteLine("Матрица C:");
// PrintMatrix(matrixC);

// Боже, вроде верно))


// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// Console.WriteLine("Введите количество строк матрицы");
// int dimensionX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы");
// int dimensionY = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите глубину матрицы");
// int dimensionZ = Convert.ToInt32(Console.ReadLine());

// int multOfDimensions = dimensionX * dimensionY * dimensionZ;
// int[,,] matrix = new int[dimensionX,dimensionY,dimensionZ];

// void GenerateNambers()
// {
//     int count = 10;
//     {
//         for (int i = 0; i <matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 for (int z = 0; z < matrix.GetLength(2); z++)
//                 {
//                     matrix[z,i,j] += count;
//                     count +=3;
//                 }
//             }
//         }
//     }
// }

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.WriteLine();   
//             for (int z = 0; z < matrix.GetLength(2); z++)
//             {
//                 Console.Write($"{matrix[i,j,z]}({i},{j},{z})");
//             }
//         }
//         Console.WriteLine();   
//     }
//     Console.WriteLine();   
// }

// if(multOfDimensions < 90)
// {
//     GenerateNambers();
//     PrintMatrix();
// }
// else
// {
//     Console.WriteLine("Заполнение невозможно");  
// }





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] matrix = new int[4,4];


// void FillMatrix()
// {
//     for (int i = 0; i < 1; i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }


// void FillMatrix2()
// {
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 3; j < 4; j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void FillMatrix3()
// {
//     for (int i = 3; i < 4; i++)
//     {
//         for (int j = 2; j != -1; j--)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void FillMatrix4()
// {
//     for (int i = 2; i != 0; i--)
//     {
//         for (int j = 0; j < 1; j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void FillMatrix5()
// {
//     for (int i = 1; i < 2; i++)
//     {
//         for (int j = 1; j < 3; j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void FillMatrix6()
// {
//     for (int i = 2; i < 3; i++)
//     {
//         for (int j = 2; j < 3; j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void FillMatrix7()
// {
//     for (int i = 2; i < 3; i++)
//     {
//         for (int j = 1; j != 0; j--)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// FillMatrix();
// FillMatrix2();
// FillMatrix3();
// FillMatrix4();
// FillMatrix5();
// FillMatrix6();
// FillMatrix7();
// PrintMatrix();




