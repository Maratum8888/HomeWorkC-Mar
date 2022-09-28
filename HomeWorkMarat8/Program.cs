
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateRandom2Array()
// {
//     Console.Write("введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());

//     Console.Write("введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("введите максимальноезначение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2Array(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void DescendingRow(int[,] array)
// {
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if(array[i, k] < array[i, k + 1]) 
//                     {
//                         int temp;
//                         temp =  array[i, k];
//                         array[i, k] = array[i, k + 1];
//                         array[i, k + 1] = temp;           
//                     }
//             }        
//         }   
//     }
// }    

// int[,] newArray = CreateRandom2Array();
// Show2Array(newArray);
// DescendingRow(newArray);
// Show2Array(newArray);
 


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] CreateRandom2Array()
// {
//     Console.Write("введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());

//     Console.Write("введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("введите максимальноезначение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2Array(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int FindMinSum(int[,] array)
// {
//     int indexSumMin = 0;
//     int sumRow = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int temp = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp =  temp + array[i, j];   
//         }
//         if(i == 0)
//         {
//             sumRow = temp;  
             
//         }
//         if(temp < sumRow)
//         {
//             indexSumMin = i;
//             sumRow = temp;
//         } 

//     }
//     return indexSumMin;
// }

// int[,] newArray = CreateRandom2Array();
// Show2Array(newArray);
// Console.WriteLine(FindMinSum(newArray));
 


 // int SumFind (int[,] array, int i)
// {
//     int sum = 0;
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     Console.WriteLine($"Сумма элементов по {i} строке: {sum}; ");
//     return sum;
// }

// void MinSumElem (int [,] array)
// {
//     int minSum = 0;
//     int sumLine = SumFind(array, 0);
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int temp = SumFind(array, i);
//         if(sumLine > temp)
//         {
//             sumLine = temp;
//             minSum = i;

//         }

//     }
//     Console.WriteLine($"\n{minSum} - строкa с наименьшей суммой ({sumLine}) элементов ");
// }








// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreateRandom2Array()
// {
//     Console.Write("введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());

//     Console.Write("введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("введите максимальноезначение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2Array(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] Multiplication(int[,] array1, int[,] array2)
// {
//     int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
//     for(int i = 0; i < array1.GetLength(0); i++)
//         for(int j = 0; j < array1.GetLength(1); j++)
//             for(int k = 0; k < array1.GetLength(1); k++)
//             {
//                 newArray[i,j] += array1[i,k] * array2[k,j];
//             }
//     return newArray;
// }

// int[,] userArray1 = CreateRandom2Array();
// Show2Array(userArray1);
// int[,] userArray2 = CreateRandom2Array();
// Show2Array(userArray2);
// Show2Array(Multiplication(userArray1, userArray2));





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)