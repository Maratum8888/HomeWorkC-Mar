
//Задача: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2Array()
{
    Console.Write("введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите максимальноезначение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) 
        {
            newArray[i, j] = Math.Round((new Random().Next(minValue, maxValue + 1)) + (new Random().NextDouble()), 2);
        }  

    }
    return newArray;
}

void Show2Array(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)   
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();    // чтобы переходить после цикла на след строку
    } 
    Console.WriteLine();
}

double[,] newArray = CreateRandom2Array();
Show2Array(newArray);
*/



//Задача: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

// void FindPosition(int[,] array)
// {
//     Console.Write("Введите позицию 1: "); 
//     int x = Convert.ToInt32(Console.ReadLine()); 
//     Console.Write("Введите позицию 2: "); 
//     int y = Convert.ToInt32(Console.ReadLine()); 

//     if (x > array.GetLength(0) || y > array.GetLength(1))
//         Console.WriteLine($"Элемента с позицией ({x} , {y}) - не существует");
//     else Console.WriteLine($"Элемент с  позицией ({x} , {y}) - {array[x, y]}");
// }

// int[,] newArray = CreateRandom2Array();
// Show2Array(newArray);
// FindPosition(newArray);




//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

// void Show2Darray(int[,] array)
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

// double[] AverageNum(int[,] array)
// {
//     double[] Array1D = new double[array.GetLength(1)];
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             Array1D[j] = (Array1D[j] + (array[i,j]));
//         }
//         Array1D[j] /= array.GetLength(0);
//     }
//     return Array1D;
// }

// void ShowArray(double[] array) // объявляем метод
// {
//     Console.Write($"Массив: ");  // пишем что это массив
//     for(int i = 0; i < array.Length; i++) // цикл перебора
//     {
//         if(i == array.Length - 1) Console.Write(Math.Round((array[i]),2)); // последняя строка без запятой
//         else Console.Write(Math.Round(array[i], 2) + " | "); // объявляем цикл
//     }
//     Console.WriteLine(); // пустая строка
// }

// int[,] newArray = CreateRandom2Array();
// Show2Darray(newArray);
// ShowArray(AverageNum(newArray));








