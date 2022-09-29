
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

// void ShowNums(int m, int n)
// {
//     if(n > m) ShowNums(m, n - 1);
//     Console.Write(n + " ");
// }
// Console.WriteLine("введите первое число: ");
// int min = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("введите второе число: ");
// int num = Convert.ToInt32(Console.ReadLine()); 
// ShowNums(min, num);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumOfDigits(int m, int n)
// {
//     if(n > m) return SumOfDigits(m, n - 1) + n;
//     else return m;
// }
// Console.WriteLine("введите первое число: ");
// int min = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("введите второе число: ");
// int num = Convert.ToInt32(Console.ReadLine()); 
// Console.Write(SumOfDigits(min, num));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

// int FuncAkkerman(int n, int m)
// {
//     if(n == 0) return m + 1;
//     else if(n > 0 && m == 0) return FuncAkkerman(n - 1, 1);
//     else if(n > 0 && m > 0) return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));
//     else return 0;
// }

// Console.WriteLine("введите первое число: ");
// int first = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("введите второе число: ");
// int second = Convert.ToInt32(Console.ReadLine()); 
// Console.Write(FuncAkkerman(second, first));

// эту задачу делал не сам, не до конца вник ....