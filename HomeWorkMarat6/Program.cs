//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void NumberPositive(int num)
// {
//     int count = 0;
//     int current = 0;
//     while(current < num)
//     {
//         Console.WriteLine($"введите число: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         if(n > 0) 
//         {
//             count++;
//         }
//         current++;
//     }
//     Console.WriteLine($"чисел больше 0: {count}");
// }

// Console.Write("введите ваши числа: ");
// int M = Convert.ToInt32(Console.ReadLine());
// NumberPositive(M);



//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// void IntersectionPoint(double a1, double c1, double a2, double c2)
// {
//     double x = (a2 - a1) / (c1 - c2);
//     double y = c1 * (a2 - a1) / (c1 - c2) + a1;
//     if(a1 == a2)
//         Console.WriteLine($"точки пересечения параллельны");
//     else
//         Console.WriteLine($"точки пересечения ({x}, {y})");

// }


// Console.Write("введите координат b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите координат k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите координат b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите координат k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// IntersectionPoint(b1, k1, b2, k2);


