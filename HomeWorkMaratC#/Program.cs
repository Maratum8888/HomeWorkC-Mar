
/*
//Задача2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(max < number2)
{
    Console.Write($"{number2} является большим, а {number1} является меньшим!");
}
else
{
     Console.Write($"{number1} является большим, а {number2} является меньшим!");
}
*/

/*
//Задача4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(max > number2)
{
    max = number1;
}

else
{
    max = number2;
}

if(max > number3)
{
    max = number1;
}
else
{
    max = number3;
}

Console.Write($"максимальное число - {max}");
*/


/*
//Задача6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.Write($"{number} - является четным!");
}
else
{
    Console.Write($"{number} - является не четным!");
}
*/

/*
//Задача8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current < number)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    
    current++;
}
*/

