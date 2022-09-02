/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue) // int[] - метод, который будет возвращать массив, 
//CreateRandomArray - название массив
{
   int[] newArray = new int[size]; // создам массив, в который кладем размер size

   for(int i = 0; i < size; i++) // цикл
      newArray[i] = new Random().Next(minValue, maxValue + 1);// создаем - обращаемся к нашему элементу по индексу 
      //и зап рандом
   return newArray;   
}

void ShowArray(int[] array)// метод, где в качест аргумента (массив)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");// сразу выводим в консоль элемент массива
    Console.WriteLine(); 
}

int ThreeDigitNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

int[] myArray = CreateRandomArray(12, 100, 1000);
ShowArray(myArray);

Console.WriteLine($"количество четных элементов  в массиве - {ThreeDigitNum(myArray)}");
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue) // int[] - метод, который будет возвращать массив, 
//CreateRandomArray - название массив
{
   int[] newArray = new int[size]; // создам массив, в который кладем размер size

   for(int i = 0; i < size; i++) // цикл
      newArray[i] = new Random().Next(minValue, maxValue + 1);// создаем - обращаемся к нашему элементу по индексу 
      //и зап рандом
   return newArray;   
}

void ShowArray(int[] array)// метод, где в качест аргумента (массив)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");// сразу выводим в консоль элемент массива
    Console.WriteLine(); 
}

int SumOdd(int[] array)
{
    
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
        sum = array[i] + sum ; 
    }
    return sum;
}

int[] myArray = CreateRandomArray(4, 1, 10);
ShowArray(myArray);

Console.WriteLine($"сумма элементов на нечетных позициях в массиве - {SumOdd(myArray)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] CreateRandomArray(int size, int minValue, int maxValue) // int[] - метод, который будет возвращать массив, 
//CreateRandomArray - название массив
{
   double[] newArray = new double[size]; // создам массив, в который кладем размер size

   for(int i = 0; i < size; i++) // цикл
      newArray[i] = Math.Round((new Random().Next(minValue, maxValue + 1)) + (new Random().NextDouble()), 2);// создаем - обращаемся к нашему элементу по индексу 
      //и зап рандом
   return newArray;   
}

void ShowArray(double[] array)// метод, где в качест аргумента (массив)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");// сразу выводим в консоль элемент массива
    Console.WriteLine(); 
}

double RealsNumbersSum(double[] array)
{
    double max = array[0];
    double min = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max ) max = array[i];
        else
            if(array[i] < min ) min = array[i];
        
    
    }
    double result = Math.Round(max - min, 2);// команда для сокращения числа до сотых
    return result;
}

Console.Write("введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("введите первый элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("введите последний элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine($"разница между максимальным и минимальным элементов массива - {RealsNumbersSum(myArray)}");





